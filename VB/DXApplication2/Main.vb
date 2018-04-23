Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraEditors

Namespace DXApplication2
    Partial Public Class Main
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private hostsMap As New Dictionary(Of BaseView, IDocumentsHostWindow)()
        Private settings As MyUserSettings
        Private mainFilePath As String = "Main.xml"
        Public Sub New()
            InitializeComponent()
            LoadSettings()
        End Sub
        Private Sub LoadSettings()
            settings = New MyUserSettings()
            If settings.Hosts Is Nothing Then
                settings.Hosts = New BindingList(Of Host)()
            End If
        End Sub
        Private Sub OnQueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles tabbedView1.QueryControl
            e.Control = GetUserControl(e.Document.Caption)
        End Sub
        Private r As New Random(100000)
        Private Function GetUserControl(ByVal caption As String) As XtraUserControl
            Dim userControl As New XtraUserControl()
            userControl.Name = caption
            userControl.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255))
            Dim edit As New TextEdit() With {.Dock = DockStyle.Top, .Parent = userControl, .Text = caption}
            Return userControl
        End Function
        Private Sub OnRegisterDocumentsHostWindow(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs) Handles tabbedView1.RegisterDocumentsHostWindow
            hostsMap.Add(e.HostWindow.DocumentManager.View, e.HostWindow)
        End Sub
        Private Sub OnUnregisterDocumentsHostWindow(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.DocumentsHostWindowEventArgs) Handles tabbedView1.UnregisterDocumentsHostWindow
            hostsMap.Remove(e.HostWindow.DocumentManager.View)
        End Sub
        Private Sub OnSaveLayout(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            tabbedView1.SaveLayoutToXml(mainFilePath)
            settings.Hosts.Clear()
            For Each pair In hostsMap
                Dim hostWindow As Form = CType(pair.Value, Form)
                Dim hostId = GetHostID(pair.Key)
                settings.Hosts.Add(New Host() With {.HostID = hostId, .HostBounds = hostWindow.Bounds, .FormState = hostWindow.WindowState})
                pair.Key.SaveLayoutToXml(GetFilePath(pair.Key))
            Next pair
            settings.Save()
        End Sub
        Private Function GetFilePath(ByVal view As BaseView) As String
            Return String.Format("Host_{0}.xml", GetHostID(view))
        End Function
        Private Function GetHostID(ByVal view As BaseView) As String
            Return String.Join(",", view.Documents.Select(Function(d) d.ControlName))
        End Function
        Private Sub OnRestoreLayout(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
            If File.Exists(mainFilePath) Then
                tabbedView1.RestoreLayoutFromXml(mainFilePath)
            End If
            RestoreFloatContainers()
            For Each pair In hostsMap
                Dim hostWindow As Form = CType(pair.Value, Form)
                Dim filePath As String = GetFilePath(pair.Key)
                If File.Exists(filePath) Then
                    pair.Key.RestoreLayoutFromXml(filePath)
                End If
                Dim host As Host = settings.Hosts.FirstOrDefault(Function(h) h.HostID = GetHostID(pair.Key))
                If host IsNot Nothing Then
                    hostWindow.Bounds = host.HostBounds
                    hostWindow.WindowState = host.FormState
                End If
            Next pair
        End Sub
        Private Sub RestoreFloatContainers()
            For Each host As Host In settings.Hosts
                Dim controlNames() As String = host.HostID.Split(","c)
                Dim documents() As BaseDocument = tabbedView1.Documents.Where(Function(doc) controlNames.Contains(doc.ControlName)).ToArray()
                tabbedView1.AddFloatingDocumentsHost(documents)
            Next host
        End Sub
    End Class
End Namespace