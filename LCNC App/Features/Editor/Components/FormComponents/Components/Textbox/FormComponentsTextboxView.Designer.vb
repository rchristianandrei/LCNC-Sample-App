<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComponentsTextboxView
    Inherits System.Windows.Forms.UserControl

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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlX = New Guna.UI2.WinForms.Guna2Panel()
        chkMultiline = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        lblMultiline = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlX.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlX
        ' 
        pnlX.AutoSize = True
        pnlX.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlX.Controls.Add(chkMultiline)
        pnlX.Controls.Add(lblMultiline)
        pnlX.CustomizableEdges = CustomizableEdges3
        pnlX.Dock = DockStyle.Top
        pnlX.Location = New Point(0, 0)
        pnlX.Name = "pnlX"
        pnlX.Padding = New Padding(3)
        pnlX.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlX.Size = New Size(156, 30)
        pnlX.TabIndex = 6
        ' 
        ' chkMultiline
        ' 
        chkMultiline.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        chkMultiline.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        chkMultiline.CheckedState.BorderRadius = 2
        chkMultiline.CheckedState.BorderThickness = 0
        chkMultiline.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        chkMultiline.CustomizableEdges = CustomizableEdges1
        chkMultiline.Location = New Point(65, 7)
        chkMultiline.Name = "chkMultiline"
        chkMultiline.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        chkMultiline.Size = New Size(85, 16)
        chkMultiline.TabIndex = 8
        chkMultiline.Text = "Guna2CustomCheckBox1"
        chkMultiline.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        chkMultiline.UncheckedState.BorderRadius = 2
        chkMultiline.UncheckedState.BorderThickness = 0
        chkMultiline.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' lblMultiline
        ' 
        lblMultiline.Anchor = AnchorStyles.Left
        lblMultiline.BackColor = Color.Transparent
        lblMultiline.Location = New Point(9, 7)
        lblMultiline.Name = "lblMultiline"
        lblMultiline.Size = New Size(50, 17)
        lblMultiline.TabIndex = 7
        lblMultiline.Text = "Multiline"
        ' 
        ' FormComponentsTextboxView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlX)
        Name = "FormComponentsTextboxView"
        Size = New Size(156, 52)
        pnlX.ResumeLayout(False)
        pnlX.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents pnlX As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents lblMultiline As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents chkMultiline As Guna.UI2.WinForms.Guna2CustomCheckBox

End Class
