Imports Guna.UI2.WinForms

Public Class FormTextbox

#Region "Properties"
    Public Overrides Property Label As String
        Get
            Return Me.lblLabel.Text
        End Get
        Set(value As String)
            Me.lblLabel.Text = value
        End Set
    End Property

    Public Overrides Property Active As Boolean
        Get
            Return Me.txtTextbox.Enabled
        End Get
        Set(value As Boolean)
            Me.txtTextbox.Enabled = value
        End Set
    End Property

    Public Overrides ReadOnly Property CanSetHeight() As Boolean
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property Textbox() As Guna2TextBox
        Get
            Return Me.txtTextbox
        End Get
    End Property
#End Region
End Class
