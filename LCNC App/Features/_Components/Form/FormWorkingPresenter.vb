Public Class FormWorkingPresenter
    Inherits FormPresenter

    ' Services
    Private ReadOnly submittedDataRepo As ISubmittedDataRepo

    Public Sub New(factory As IFormControlFactory, submittedDataRepo As ISubmittedDataRepo)
        MyBase.New(factory)

        Me.submittedDataRepo = submittedDataRepo

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler MyBase.View.StartForm, AddressOf Me.StartForm
    End Sub

#Region "Public Methods"
    Public Overrides Sub Show(formModel As FormModel, owner As Form)
        MyBase.Show(formModel, owner)
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub StartForm()
        ' Record to Active Table
    End Sub

    Protected Overrides Async Sub SubmitClick(sender As Object, e As EventArgs)

        ' Record to Historical and Recent
        Dim data As New Dictionary(Of String, String)
        For Each ctrl In MyBase.ctrlToModel.Keys
            data.Add(ctrl.Label, ctrl.TextValue)
        Next

        Dim model As New SubmittedDataModel With {
            .Username = Globals.CurrentUser.Username,
            .FormName = MyBase.formModel.FormText,
            .FormId = MyBase.formModel.Id,
            .HandlingTime = stopWatch.Elapsed.Seconds,
            .Data = data
        }

        Try
            Await Me.submittedDataRepo.Insert(model)

            MyBase.InActiveState()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Utility Methods"

#End Region
End Class
