<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDropdownbox
    Inherits FormControlComponent

    'UserControl overrides dispose to clean up the component list.
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
        lblLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cboCombobox = New Guna.UI2.WinForms.Guna2ComboBox()
        SuspendLayout()
        ' 
        ' lblLabel
        ' 
        lblLabel.AutoSize = False
        lblLabel.BackColor = SystemColors.Control
        lblLabel.Dock = DockStyle.Top
        lblLabel.Enabled = False
        lblLabel.Location = New Point(1, 1)
        lblLabel.Name = "lblLabel"
        lblLabel.Size = New Size(198, 17)
        lblLabel.TabIndex = 1
        lblLabel.Text = "Dropdownbox Label"
        ' 
        ' cboCombobox
        ' 
        cboCombobox.BackColor = SystemColors.Control
        cboCombobox.BorderRadius = 6
        cboCombobox.CustomizableEdges = CustomizableEdges1
        cboCombobox.Dock = DockStyle.Fill
        cboCombobox.DrawMode = DrawMode.OwnerDrawFixed
        cboCombobox.DropDownStyle = ComboBoxStyle.DropDownList
        cboCombobox.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cboCombobox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cboCombobox.Font = New Font("Segoe UI", 10F)
        cboCombobox.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cboCombobox.ItemHeight = 23
        cboCombobox.Location = New Point(1, 18)
        cboCombobox.Name = "cboCombobox"
        cboCombobox.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cboCombobox.Size = New Size(198, 29)
        cboCombobox.TabIndex = 2
        ' 
        ' FormDropdownbox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(cboCombobox)
        Controls.Add(lblLabel)
        Name = "FormDropdownbox"
        Padding = New Padding(1)
        Size = New Size(200, 48)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cboCombobox As Guna.UI2.WinForms.Guna2ComboBox
End Class
