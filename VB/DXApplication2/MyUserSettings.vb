Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Drawing
Imports System.Windows.Forms

Namespace DXApplication2
    Public Class MyUserSettings
        Inherits ApplicationSettingsBase

        <UserScopedSetting()> _
        Public Property Hosts() As BindingList(Of Host)
            Get
                Return (DirectCast(Me("Hosts"), BindingList(Of Host)))
            End Get
            Set(ByVal value As BindingList(Of Host))
                Me("Hosts") = value
            End Set
        End Property
        '[UserScopedSetting()]
        'public BindingList<Rectangle> HostPositions {
        '    get { return ((BindingList<Rectangle>)this["HostPositions"]); }
        '    set { this["HostPositions"] = value; }
        '}
    End Class

    Public Class Host
        Public Sub New()
        End Sub

        Public Property HostID() As String
        Public Property HostBounds() As Rectangle
        Public Property FormState() As FormWindowState
    End Class
End Namespace