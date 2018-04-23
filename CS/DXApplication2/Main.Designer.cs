namespace DXApplication2 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup();
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document4 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document5 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document6 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document7 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document8 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document8)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(787, 144);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save Float Layouts";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSaveLayout);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Restore Float Layouts";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRestoreLayout);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Layout";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1,
            this.document2,
            this.document3,
            this.document4,
            this.document5,
            this.document6,
            this.document7,
            this.document8});
            this.tabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost;
            this.tabbedView1.RegisterDocumentsHostWindow += new DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventHandler(this.OnRegisterDocumentsHostWindow);
            this.tabbedView1.UnregisterDocumentsHostWindow += new DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventHandler(this.OnUnregisterDocumentsHostWindow);
            this.tabbedView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.OnQueryControl);
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1,
            this.document2,
            this.document3,
            this.document4,
            this.document5,
            this.document6,
            this.document7,
            this.document8});
            // 
            // document1
            // 
            this.document1.Caption = "document1";
            this.document1.ControlName = "document1";
            // 
            // document2
            // 
            this.document2.Caption = "document2";
            this.document2.ControlName = "document2";
            // 
            // document3
            // 
            this.document3.Caption = "document3";
            this.document3.ControlName = "document3";
            // 
            // document4
            // 
            this.document4.Caption = "document4";
            this.document4.ControlName = "document4";
            // 
            // document5
            // 
            this.document5.Caption = "document5";
            this.document5.ControlName = "document5";
            // 
            // document6
            // 
            this.document6.Caption = "document6";
            this.document6.ControlName = "document6";
            // 
            // document7
            // 
            this.document7.Caption = "document7";
            this.document7.ControlName = "document7";
            // 
            // document8
            // 
            this.document8.Caption = "document8";
            this.document8.ControlName = "document8";
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 552);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "How to save layouts of float documents";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document3;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document4;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document5;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document6;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document7;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document8;
    }
}

