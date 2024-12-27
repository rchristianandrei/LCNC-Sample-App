Imports Guna.UI2.WinForms

Public Class FormView
#Region "Properties"
    Public ReadOnly Property WidthOffset = 16
    Public ReadOnly Property HeightOffset = 36

    Public ReadOnly Property SubmitButton() As Guna2Button
        Get
            Return Me.btnSubmit
        End Get
    End Property
#End Region
End Class