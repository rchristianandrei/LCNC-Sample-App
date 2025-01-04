<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportRawReportView
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
        grdData = New Guna.UI2.WinForms.Guna2DataGridView()
        btnExport = New Guna.UI2.WinForms.Guna2Button()
        dtpForm = New DateTimePicker()
        dtpTo = New DateTimePicker()
        lblTo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        colForms = New DataGridViewTextBoxColumn()
        colFormName = New DataGridViewTextBoxColumn()
        colDateTimeSubmitted = New DataGridViewTextBoxColumn()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grdData
        ' 
        grdData.AllowUserToAddRows = False
        grdData.AllowUserToDeleteRows = False
        grdData.AllowUserToResizeColumns = False
        grdData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdData.Columns.AddRange(New DataGridViewColumn() {colForms, colFormName, colDateTimeSubmitted})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        grdData.DefaultCellStyle = DataGridViewCellStyle3
        grdData.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdData.Location = New Point(12, 45)
        grdData.Name = "grdData"
        grdData.ReadOnly = True
        grdData.RowHeadersVisible = False
        grdData.Size = New Size(542, 269)
        grdData.TabIndex = 4
        grdData.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        grdData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        grdData.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        grdData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        grdData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        grdData.ThemeStyle.BackColor = Color.White
        grdData.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdData.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        grdData.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        grdData.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        grdData.ThemeStyle.HeaderStyle.ForeColor = Color.White
        grdData.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grdData.ThemeStyle.HeaderStyle.Height = 23
        grdData.ThemeStyle.ReadOnly = True
        grdData.ThemeStyle.RowsStyle.BackColor = Color.White
        grdData.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grdData.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        grdData.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        grdData.ThemeStyle.RowsStyle.Height = 25
        grdData.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        grdData.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExport.BorderRadius = 6
        btnExport.CustomizableEdges = CustomizableEdges1
        btnExport.DisabledState.BorderColor = Color.DarkGray
        btnExport.DisabledState.CustomBorderColor = Color.DarkGray
        btnExport.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExport.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExport.FillColor = Color.Green
        btnExport.Font = New Font("Segoe UI", 9F)
        btnExport.ForeColor = Color.White
        btnExport.Location = New Point(442, 12)
        btnExport.Name = "btnExport"
        btnExport.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnExport.Size = New Size(112, 27)
        btnExport.TabIndex = 5
        btnExport.Text = "Export"
        ' 
        ' dtpForm
        ' 
        dtpForm.Font = New Font("Segoe UI", 11.25F)
        dtpForm.Format = DateTimePickerFormat.Short
        dtpForm.Location = New Point(12, 12)
        dtpForm.Name = "dtpForm"
        dtpForm.Size = New Size(113, 27)
        dtpForm.TabIndex = 6
        ' 
        ' dtpTo
        ' 
        dtpTo.Font = New Font("Segoe UI", 11.25F)
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(164, 12)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(113, 27)
        dtpTo.TabIndex = 7
        ' 
        ' lblTo
        ' 
        lblTo.BackColor = Color.Transparent
        lblTo.Location = New Point(131, 17)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(27, 17)
        lblTo.TabIndex = 8
        lblTo.Text = "-To-"
        ' 
        ' colForms
        ' 
        colForms.HeaderText = "Form Id"
        colForms.Name = "colForms"
        colForms.ReadOnly = True
        ' 
        ' colFormName
        ' 
        colFormName.HeaderText = "Form Name"
        colFormName.Name = "colFormName"
        colFormName.ReadOnly = True
        ' 
        ' colDateTimeSubmitted
        ' 
        colDateTimeSubmitted.HeaderText = "Date Time Submitted"
        colDateTimeSubmitted.Name = "colDateTimeSubmitted"
        colDateTimeSubmitted.ReadOnly = True
        ' 
        ' ExportRawReportView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 326)
        Controls.Add(lblTo)
        Controls.Add(dtpTo)
        Controls.Add(dtpForm)
        Controls.Add(btnExport)
        Controls.Add(grdData)
        Name = "ExportRawReportView"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Export Raw Report"
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents grdData As Guna.UI2.WinForms.Guna2DataGridView
    Private WithEvents btnExport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpForm As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblTo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents colForms As DataGridViewTextBoxColumn
    Friend WithEvents colFormName As DataGridViewTextBoxColumn
    Friend WithEvents colDateTimeSubmitted As DataGridViewTextBoxColumn
End Class
