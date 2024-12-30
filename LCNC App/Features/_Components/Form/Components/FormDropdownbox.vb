Imports Guna.UI2.WinForms

Public Class FormDropdownbox

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
            Return Me.cboCombobox.Enabled
        End Get
        Set(value As Boolean)
            Me.cboCombobox.Enabled = value
        End Set
    End Property

    Public Overrides ReadOnly Property CanSetHeight() As Boolean
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property Combobox() As Guna2ComboBox
        Get
            Return Me.cboCombobox
        End Get
    End Property
#End Region
End Class
