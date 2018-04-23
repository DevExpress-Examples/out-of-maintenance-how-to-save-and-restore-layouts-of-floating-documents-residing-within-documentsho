using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;

namespace DXApplication2 {
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm {
        Dictionary<BaseView, IDocumentsHostWindow> hostsMap = new Dictionary<BaseView, IDocumentsHostWindow>();
        MyUserSettings settings;
        string mainFilePath = "Main.xml";
        public Main() {
            InitializeComponent();
            LoadSettings(); 
        }
        void LoadSettings() {
            settings = new MyUserSettings();
            if(settings.Hosts == null)
                settings.Hosts = new BindingList<Host>();
        }
        void OnQueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            e.Control = GetUserControl(e.Document.Caption);
        }
        Random r = new Random(100000);
        XtraUserControl GetUserControl(string caption) {
            XtraUserControl userControl = new XtraUserControl();
            userControl.Name = caption;
            userControl.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            TextEdit edit = new TextEdit()
            {
                Dock = DockStyle.Top,
                Parent = userControl,
                Text = caption
            };
            return userControl;
        }
        void OnRegisterDocumentsHostWindow(object sender, DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs e) {
            hostsMap.Add(e.HostWindow.DocumentManager.View, e.HostWindow);
        }
        void OnUnregisterDocumentsHostWindow(object sender, DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs e) {
            hostsMap.Remove(e.HostWindow.DocumentManager.View);
        }
        void OnSaveLayout(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            tabbedView1.SaveLayoutToXml(mainFilePath);
            settings.Hosts.Clear();
            foreach(var pair in hostsMap) {
                Form hostWindow = (Form)pair.Value;
                var hostId = GetHostID(pair.Key);
                settings.Hosts.Add(new Host() {
                    HostID = hostId,
                    HostBounds = hostWindow.Bounds,
                    FormState = hostWindow.WindowState
                });
                pair.Key.SaveLayoutToXml(GetFilePath(pair.Key));
            }
            settings.Save();
        }
        string GetFilePath(BaseView view) {
            return string.Format("Host_{0}.xml", GetHostID(view));
        }
        string GetHostID(BaseView view) {
            return string.Join(",", view.Documents.Select(d => d.ControlName));
        }
        void OnRestoreLayout(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(File.Exists(mainFilePath))
                tabbedView1.RestoreLayoutFromXml(mainFilePath);
            RestoreFloatContainers();
            foreach(var pair in hostsMap) {
                Form hostWindow = (Form)pair.Value;
                string filePath = GetFilePath(pair.Key);
                if(File.Exists(filePath))
                    pair.Key.RestoreLayoutFromXml(filePath);
                Host host = settings.Hosts.FirstOrDefault(h => h.HostID == GetHostID(pair.Key));
                if(host != null){
                    hostWindow.Bounds = host.HostBounds;
                    hostWindow.WindowState = host.FormState;
                }
            }
        }
        void RestoreFloatContainers() {  
            foreach(Host host in settings.Hosts) {
                string[] controlNames = host.HostID.Split(',');
                BaseDocument[] documents = tabbedView1.Documents.Where(doc => controlNames.Contains(doc.ControlName)).ToArray();
                tabbedView1.AddFloatingDocumentsHost(documents);
            }
        }
    }
}