<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadFormView
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnCancel = New Guna.UI2.WinForms.Guna2Button()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        grdForms = New Guna.UI2.WinForms.Guna2DataGridView()
        colForms = New DataGridViewTextBoxColumn()
        CType(grdForms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancel.BorderRadius = 6
        btnCancel.CustomizableEdges = CustomizableEdges1
        btnCancel.DisabledState.BorderColor = Color.DarkGray
        btnCancel.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancel.FillColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnCancel.Font = New Font("Segoe UI", 9F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(12, 240)
        btnCancel.Name = "btnCancel"
        btnCancel.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnCancel.Size = New Size(112, 27)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.BorderRadius = 6
        btnSave.CustomizableEdges = CustomizableEdges3
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Green
        btnSave.Font = New Font("Segoe UI", 9F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(306, 240)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSave.Size = New Size(112, 27)
        btnSave.TabIndex = 4
        btnSave.Text = "Open"
        ' 
        ' grdForms
        ' 
        grdForms.AllowUserToAddRows = False
        grdForms.AllowUserToDeleteRows = False
        grdForms.AllowUserToResizeColumns = False
        grdForms.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        grdForms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        grdForms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdForms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdForms.Columns.AddRange(New DataGridViewColumn() {colForms})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdForms.DefaultCellStyle = DataGridViewCellStyle3
        grdForms.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdForms.Location = New Point(12, 12)
        grdForms.Name = "grdForms"
        grdForms.ReadOnly = True
        grdForms.RowHeadersVisible = False
        grdForms.Size = New Size(406, 222)
        grdForms.TabIndex = 3
        grdForms.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdForms.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdForms.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdForms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdForms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdForms.ThemeStyle.BackColor = Color.White
        grdForms.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdForms.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdForms.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdForms.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        grdForms.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdForms.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grdForms.ThemeStyle.HeaderStyle.Height = 23
        grdForms.ThemeStyle.ReadOnly = True
        grdForms.ThemeStyle.RowsStyle.BackColor = Color.White
        grdForms.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdForms.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        grdForms.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdForms.ThemeStyle.RowsStyle.Height = 25
        grdForms.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdForms.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' colForms
        ' 
        colForms.HeaderText = "Forms"
        colForms.Name = "colForms"
        colForms.ReadOnly = True
        ' 
        ' LoadFormView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 279)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(grdForms)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoadFormView"
        StartPosition = FormStartPosition.CenterParent
        Text = "LoadFormView"
        CType(grdForms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Private WithEvents grdForms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colForms As DataGridViewTextBoxColumn
End Class
