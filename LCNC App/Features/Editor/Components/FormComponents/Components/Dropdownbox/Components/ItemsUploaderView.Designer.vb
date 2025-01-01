<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsUploaderView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        grdItems = New Guna.UI2.WinForms.Guna2DataGridView()
        colItems = New DataGridViewTextBoxColumn()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        btnDelete = New Guna.UI2.WinForms.Guna2Button()
        CType(grdItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grdItems
        ' 
        grdItems.AllowUserToResizeColumns = False
        grdItems.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        grdItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        grdItems.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdItems.Columns.AddRange(New DataGridViewColumn() {colItems})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdItems.DefaultCellStyle = DataGridViewCellStyle3
        grdItems.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdItems.Location = New Point(12, 12)
        grdItems.Name = "grdItems"
        grdItems.RowHeadersVisible = False
        grdItems.Size = New Size(406, 222)
        grdItems.TabIndex = 0
        grdItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdItems.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdItems.ThemeStyle.BackColor = Color.White
        grdItems.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdItems.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        grdItems.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grdItems.ThemeStyle.HeaderStyle.Height = 23
        grdItems.ThemeStyle.ReadOnly = False
        grdItems.ThemeStyle.RowsStyle.BackColor = Color.White
        grdItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdItems.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        grdItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdItems.ThemeStyle.RowsStyle.Height = 25
        grdItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' colItems
        ' 
        colItems.HeaderText = "Items"
        colItems.Name = "colItems"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.BorderRadius = 6
        btnSave.CustomizableEdges = CustomizableEdges1
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Green
        btnSave.Font = New Font("Segoe UI", 9F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(306, 240)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSave.Size = New Size(112, 27)
        btnSave.TabIndex = 1
        btnSave.Text = "Save Items"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnDelete.BorderRadius = 6
        btnDelete.CustomizableEdges = CustomizableEdges3
        btnDelete.DisabledState.BorderColor = Color.DarkGray
        btnDelete.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelete.FillColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnDelete.Font = New Font("Segoe UI", 9F)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(12, 240)
        btnDelete.Name = "btnDelete"
        btnDelete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelete.Size = New Size(112, 27)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Delete Item"
        ' 
        ' ItemsUploaderView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 279)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(grdItems)
        Name = "ItemsUploaderView"
        StartPosition = FormStartPosition.CenterParent
        Text = "ItemsUploaderView"
        CType(grdItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grdItems As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colItems As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
End Class
