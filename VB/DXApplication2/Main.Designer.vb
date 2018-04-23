Namespace DXApplication2
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document6 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document7 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.document8 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 3
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl1.Size = New System.Drawing.Size(787, 144)
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Save Float Layouts"
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Restore Float Layouts"
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Layout"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.MenuManager = Me.ribbonControl1
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView1})
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2, Me.document3, Me.document4, Me.document5, Me.document6, Me.document7, Me.document8})
            Me.tabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
            ' 
            ' documentGroup1
            ' 
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.document1, Me.document2, Me.document3, Me.document4, Me.document5, Me.document6, Me.document7, Me.document8})
            ' 
            ' document1
            ' 
            Me.document1.Caption = "document1"
            Me.document1.ControlName = "document1"
            ' 
            ' document2
            ' 
            Me.document2.Caption = "document2"
            Me.document2.ControlName = "document2"
            ' 
            ' document3
            ' 
            Me.document3.Caption = "document3"
            Me.document3.ControlName = "document3"
            ' 
            ' document4
            ' 
            Me.document4.Caption = "document4"
            Me.document4.ControlName = "document4"
            ' 
            ' document5
            ' 
            Me.document5.Caption = "document5"
            Me.document5.ControlName = "document5"
            ' 
            ' document6
            ' 
            Me.document6.Caption = "document6"
            Me.document6.ControlName = "document6"
            ' 
            ' document7
            ' 
            Me.document7.Caption = "document7"
            Me.document7.ControlName = "document7"
            ' 
            ' document8
            ' 
            Me.document8.Caption = "document8"
            Me.document8.ControlName = "document8"
            ' 
            ' Main
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(787, 552)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Main"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "How to save layouts of float documents"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Private WithEvents tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document4 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document5 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document6 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document7 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private document8 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    End Class
End Namespace

