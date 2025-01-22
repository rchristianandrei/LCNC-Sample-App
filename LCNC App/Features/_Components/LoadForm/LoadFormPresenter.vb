Public Class LoadFormPresenter

    ' Services
    Private formsRepo As IFormsRepo

    Private dialogResult As DialogResult = DialogResult.Cancel

    Public Sub New(formsRepo As IFormsRepo)
        Me.formsRepo = formsRepo

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.Shown, AddressOf Me.Shown
        AddHandler Me.View.Open, AddressOf Me.OpenForm
        AddHandler Me.View.Cancel, AddressOf Me.Cancel
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New LoadFormView

    Public Property FormModel As FormModel
#End Region

#Region "Public Methods"
    Public Function ShowDialog(owner As Form) As DialogResult
        Me.View.ShowDialog(owner)

        Return Me.dialogResult
    End Function
#End Region

#Region "Event Handlers"
    Private Async Sub Shown(sender As Object, e As EventArgs)
        Try
            Dim forms = Await Me.formsRepo.LoadAllOwned(Globals.CurrentUser.Username)

            Me.View.FormsGrid.Rows.Clear()
            For Each form In forms
                Me.View.FormsGrid.Rows.Add(form)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.View.Close()
        End Try
    End Sub

    Private Sub OpenForm()
        If Me.View.FormsGrid.SelectedRows.Count <= 0 Then
            MsgBox("Please select a form to open")
            Return
        End If

        Me.formModel = DirectCast(Me.View.FormsGrid.SelectedRows(0).Cells(Me.View.FormColIndex).Value, FormModel)

        Me.dialogResult = DialogResult.Yes

        Me.View.Close()
    End Sub

    Private Sub Cancel()
        Me.View.Close()
    End Sub
#End Region
End Class
