Imports Guna.UI2.WinForms

Public Class FormTextbox
#Region "Properties"
    Public ReadOnly Property Label() As Guna2HtmlLabel
        Get
            Return Me.lblLabel
        End Get
    End Property

    Public ReadOnly Property Textbox() As Guna2TextBox
        Get
            Return Me.txtTextbox
        End Get
    End Property
#End Region
End Class
