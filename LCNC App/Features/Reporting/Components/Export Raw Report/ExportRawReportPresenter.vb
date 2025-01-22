Imports System.IO

Public Class ExportRawReportPresenter

    Private ReadOnly view As New ExportRawReportView
    Private Const StartingIndex = 3

    ' Services
    Private ReadOnly submittedDataRepo As ISubmittedDataRepo

    ' Variables
    Private formModel As FormModel

    Public Sub New(submittedDataRepo As ISubmittedDataRepo)
        Me.submittedDataRepo = submittedDataRepo

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.view.LoadData, AddressOf Me.LoadData
        AddHandler Me.view.ExportData, AddressOf Me.ExportData
    End Sub

#Region "Public Methods"
    Public Function ShowDialog(formModel As FormModel, owner As Form) As DialogResult
        Me.formModel = formModel

        Dim index = StartingIndex
        For Each comp In Me.formModel.Components
            Dim column As New DataGridViewTextBoxColumn With {
                .HeaderText = comp.Label
            }
            Me.view.DataGrid.Columns.Insert(index, column)
            index += 1
        Next

        Me.view.ShowDialog(owner)

        Return DialogResult.Cancel
    End Function
#End Region

#Region "EventHandlers"
    Private Async Sub LoadData()
        If Me.view.FromDate > Me.view.ToDate Then
            MsgBox("Invalid Date Range")
            Return
        End If

        Try
            Dim data = Await Me.submittedDataRepo.GetData(Me.formModel.Id, Me.view.FromDate, Me.view.ToDate)

            Me.view.DataGrid.Rows.Clear()
            For Each datum In data
                Dim array(Me.view.DataGrid.ColumnCount) As Object

                array(Me.view.ColIdlIndex) = datum.Id
                array(Me.view.ColUsernameIndex) = datum.Username
                array(Me.view.ColFormIDIndex) = datum.FormId
                array(Me.view.ColFormNameIndex) = datum.FormName
                array(Me.view.ColDateTimeIndex) = datum.DateTime

                Dim index = StartingIndex
                For Each comp In Me.formModel.Components
                    array(index) = If(datum.Data.ContainsKey(comp.Label), datum.Data(comp.Label), String.Empty)
                    index += 1
                Next

                Me.view.DataGrid.Rows.Add(array)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ExportData()
        If Me.view.DataGrid.RowCount <= 0 Then Return

        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "CSV files (*.csv)|*.csv",
            .Title = "Save as CSV File"
        }

        If saveFileDialog.ShowDialog() <> DialogResult.OK Then Return

        Me.ExportToCSV(Me.view.DataGrid, saveFileDialog.FileName)
    End Sub
#End Region

#Region "Utility Methods"
    Private Sub ExportToCSV(dataGridView As DataGridView, filePath As String)
        Try
            ' Open file stream for writing
            Using writer As New StreamWriter(filePath)
                ' Write column headers
                Dim headers = dataGridView.Columns.Cast(Of DataGridViewColumn)() _
                                  .Select(Function(col) col.HeaderText)
                writer.WriteLine(String.Join(",", headers))

                ' Write rows
                For Each row As DataGridViewRow In dataGridView.Rows
                    If Not row.IsNewRow Then
                        Dim cells = row.Cells.Cast(Of DataGridViewCell)() _
                                        .Select(Function(cell) If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                        writer.WriteLine(String.Join(",", cells))
                    End If
                Next
            End Using

            MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class
