<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettingsView
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        lblFormSettings = New Guna.UI2.WinForms.Guna2HtmlLabel()
        grpSize = New GroupBox()
        txtHeight = New Guna.UI2.WinForms.Guna2TextBox()
        lblHeight = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtWidth = New Guna.UI2.WinForms.Guna2TextBox()
        lblWidth = New Guna.UI2.WinForms.Guna2HtmlLabel()
        grpSubmit = New GroupBox()
        txtSubmitText = New Guna.UI2.WinForms.Guna2TextBox()
        lblSubmitText = New Guna.UI2.WinForms.Guna2HtmlLabel()
        grpSize.SuspendLayout()
        grpSubmit.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Transparent
        lblTitle.Location = New Point(3, 36)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(26, 17)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Title"
        ' 
        ' txtTitle
        ' 
        txtTitle.BorderRadius = 6
        txtTitle.CustomizableEdges = CustomizableEdges9
        txtTitle.DefaultText = ""
        txtTitle.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtTitle.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtTitle.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTitle.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTitle.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTitle.Font = New Font("Segoe UI", 9F)
        txtTitle.ForeColor = SystemColors.ControlText
        txtTitle.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTitle.Location = New Point(35, 31)
        txtTitle.Name = "txtTitle"
        txtTitle.PasswordChar = ChrW(0)
        txtTitle.PlaceholderText = ""
        txtTitle.SelectedText = ""
        txtTitle.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtTitle.Size = New Size(130, 27)
        txtTitle.TabIndex = 1
        ' 
        ' lblFormSettings
        ' 
        lblFormSettings.Anchor = AnchorStyles.Top
        lblFormSettings.BackColor = Color.Transparent
        lblFormSettings.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormSettings.Location = New Point(34, 3)
        lblFormSettings.Name = "lblFormSettings"
        lblFormSettings.Size = New Size(101, 22)
        lblFormSettings.TabIndex = 2
        lblFormSettings.Text = "Form Settings"
        ' 
        ' grpSize
        ' 
        grpSize.Controls.Add(txtHeight)
        grpSize.Controls.Add(lblHeight)
        grpSize.Controls.Add(txtWidth)
        grpSize.Controls.Add(lblWidth)
        grpSize.Location = New Point(3, 64)
        grpSize.Name = "grpSize"
        grpSize.Size = New Size(162, 86)
        grpSize.TabIndex = 4
        grpSize.TabStop = False
        grpSize.Text = "Size"
        ' 
        ' txtHeight
        ' 
        txtHeight.BorderRadius = 6
        txtHeight.CustomizableEdges = CustomizableEdges11
        txtHeight.DefaultText = ""
        txtHeight.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtHeight.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtHeight.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtHeight.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtHeight.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtHeight.Font = New Font("Segoe UI", 9F)
        txtHeight.ForeColor = SystemColors.ControlText
        txtHeight.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtHeight.Location = New Point(51, 50)
        txtHeight.Name = "txtHeight"
        txtHeight.PasswordChar = ChrW(0)
        txtHeight.PlaceholderText = ""
        txtHeight.SelectedText = ""
        txtHeight.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtHeight.Size = New Size(105, 27)
        txtHeight.TabIndex = 5
        ' 
        ' lblHeight
        ' 
        lblHeight.BackColor = Color.Transparent
        lblHeight.Location = New Point(6, 55)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(39, 17)
        lblHeight.TabIndex = 4
        lblHeight.Text = "Height"
        ' 
        ' txtWidth
        ' 
        txtWidth.BorderRadius = 6
        txtWidth.CustomizableEdges = CustomizableEdges13
        txtWidth.DefaultText = ""
        txtWidth.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtWidth.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtWidth.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtWidth.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtWidth.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtWidth.Font = New Font("Segoe UI", 9F)
        txtWidth.ForeColor = SystemColors.ControlText
        txtWidth.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtWidth.Location = New Point(51, 17)
        txtWidth.Name = "txtWidth"
        txtWidth.PasswordChar = ChrW(0)
        txtWidth.PlaceholderText = ""
        txtWidth.SelectedText = ""
        txtWidth.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txtWidth.Size = New Size(105, 27)
        txtWidth.TabIndex = 3
        ' 
        ' lblWidth
        ' 
        lblWidth.BackColor = Color.Transparent
        lblWidth.Location = New Point(6, 22)
        lblWidth.Name = "lblWidth"
        lblWidth.Size = New Size(35, 17)
        lblWidth.TabIndex = 2
        lblWidth.Text = "Width"
        ' 
        ' grpSubmit
        ' 
        grpSubmit.Controls.Add(txtSubmitText)
        grpSubmit.Controls.Add(lblSubmitText)
        grpSubmit.Location = New Point(3, 171)
        grpSubmit.Name = "grpSubmit"
        grpSubmit.Size = New Size(162, 51)
        grpSubmit.TabIndex = 6
        grpSubmit.TabStop = False
        grpSubmit.Text = "Submit Button"
        ' 
        ' txtSubmitText
        ' 
        txtSubmitText.BorderRadius = 6
        txtSubmitText.CustomizableEdges = CustomizableEdges15
        txtSubmitText.DefaultText = ""
        txtSubmitText.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSubmitText.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSubmitText.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSubmitText.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSubmitText.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSubmitText.Font = New Font("Segoe UI", 9F)
        txtSubmitText.ForeColor = SystemColors.ControlText
        txtSubmitText.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSubmitText.Location = New Point(51, 17)
        txtSubmitText.Name = "txtSubmitText"
        txtSubmitText.PasswordChar = ChrW(0)
        txtSubmitText.PlaceholderText = ""
        txtSubmitText.SelectedText = ""
        txtSubmitText.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        txtSubmitText.Size = New Size(105, 27)
        txtSubmitText.TabIndex = 3
        ' 
        ' lblSubmitText
        ' 
        lblSubmitText.BackColor = Color.Transparent
        lblSubmitText.Location = New Point(6, 22)
        lblSubmitText.Name = "lblSubmitText"
        lblSubmitText.Size = New Size(25, 17)
        lblSubmitText.TabIndex = 2
        lblSubmitText.Text = "Text"
        ' 
        ' FormSettingsView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(grpSubmit)
        Controls.Add(grpSize)
        Controls.Add(lblFormSettings)
        Controls.Add(txtTitle)
        Controls.Add(lblTitle)
        Name = "FormSettingsView"
        Size = New Size(168, 467)
        grpSize.ResumeLayout(False)
        grpSize.PerformLayout()
        grpSubmit.ResumeLayout(False)
        grpSubmit.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFormSettings As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSize As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents txtWidth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblWidth As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtHeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblHeight As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents grpSubmit As GroupBox
    Friend WithEvents txtSubmitText As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSubmitText As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
