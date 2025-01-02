Public Class FormPreviewPresenter

    ' Services
    Private ReadOnly factory As IFormControlFactory

    ' Mapping
    Private ReadOnly ctrlToModel As New Dictionary(Of FormControlComponent, FormComponentModel)

    Public Sub New(factory As IFormControlFactory)
        Me.factory = factory
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New FormView With {
        .FormBorderStyle = FormBorderStyle.FixedSingle,
        .MaximizeBox = False
    }
#End Region

#Region "Public Methods"
    Public Sub Show(formModel As FormModel, owner As Form)
        Me.View.Text = formModel.FormText
        Me.View.Size = New Size(formModel.FormWidth, formModel.FormHeight)
        Me.View.SubmitButton.Text = formModel.SubmitText

        For Each model In formModel.Components
            Dim ctrl = Me.factory.CreateFromModel(model)
            Me.ctrlToModel.Add(ctrl, model)
            Me.View.ComponentsPanel.Controls.Add(ctrl)
        Next

        Me.View.Show(owner)
    End Sub
#End Region
End Class
