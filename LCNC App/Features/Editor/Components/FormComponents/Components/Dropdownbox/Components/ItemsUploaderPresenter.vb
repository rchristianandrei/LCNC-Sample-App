Public Class ItemsUploaderPresenter
    Private ReadOnly view As New ItemsUploaderView

    Private _items As List(Of String)
    Private dialogResult As DialogResult = DialogResult.Cancel

    Public Sub New()
        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.view.SaveItems, AddressOf Me.SaveItems
        AddHandler Me.view.DeleteItem, AddressOf Me.DeleteItem
    End Sub

#Region "Public Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="owner"></param>
    ''' <returns>Returns DialogResult.Yes if Save Items, DialogResult.Cancel if not</returns>
    Public Function ShowDialog(owner As Form, items As IEnumerable(Of String)) As DialogResult

        If items IsNot Nothing Then
            For Each item In items
                Me.view.ItemsGrid.Rows.Add(item)
            Next
        End If

        Me.view.ShowDialog(owner)

        Return Me.dialogResult
    End Function

    Public Function GetItems() As IEnumerable(Of String)
        Return _items.ToList()
    End Function
#End Region

#Region "Event Handlers"
    Private Sub SaveItems()
        Me.dialogResult = DialogResult.Yes

        Me._items = New List(Of String)
        For Each row As DataGridViewRow In Me.view.ItemsGrid.Rows
            If row.Cells(0).Value Is Nothing Then Continue For
            Me._items.Add(row.Cells(0).Value.ToString)
        Next

        Me.view.Close()
    End Sub

    Private Sub DeleteItem()
        If Me.view.ItemsGrid.SelectedRows.Count <= 0 Then Return

        Dim result = MessageBox.Show("Are you sure you want to delete the selected items?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then Return

        For Each row As DataGridViewRow In Me.view.ItemsGrid.SelectedRows
            If row.IsNewRow Then Continue For
            Me.view.ItemsGrid.Rows.Remove(row)
        Next
    End Sub
#End Region
End Class
