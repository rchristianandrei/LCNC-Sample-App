<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorView
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlRight = New Guna.UI2.WinForms.Guna2Panel()
        pnlPreview = New Guna.UI2.WinForms.Guna2Panel()
        sepRight = New Guna.UI2.WinForms.Guna2VSeparator()
        sepTop = New Guna.UI2.WinForms.Guna2Separator()
        mnsOptions = New MenuStrip()
        smiForm = New ToolStripMenuItem()
        smiLoad = New ToolStripMenuItem()
        smiPreview = New ToolStripMenuItem()
        smiSave = New ToolStripMenuItem()
        smiReset = New ToolStripMenuItem()
        smiComponents = New ToolStripMenuItem()
        smiAddNew = New ToolStripMenuItem()
        smiTextbox = New ToolStripMenuItem()
        smiDropdownbox = New ToolStripMenuItem()
        mnsOptions.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.Transparent
        pnlRight.CustomizableEdges = CustomizableEdges1
        pnlRight.Dock = DockStyle.Right
        pnlRight.Location = New Point(578, 25)
        pnlRight.Name = "pnlRight"
        pnlRight.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlRight.Size = New Size(168, 481)
        pnlRight.TabIndex = 2
        ' 
        ' pnlPreview
        ' 
        pnlPreview.BackColor = SystemColors.Control
        pnlPreview.CustomizableEdges = CustomizableEdges3
        pnlPreview.Dock = DockStyle.Fill
        pnlPreview.Location = New Point(0, 25)
        pnlPreview.Name = "pnlPreview"
        pnlPreview.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlPreview.Size = New Size(577, 481)
        pnlPreview.TabIndex = 3
        ' 
        ' sepRight
        ' 
        sepRight.Dock = DockStyle.Right
        sepRight.FillColor = SystemColors.ControlText
        sepRight.Location = New Point(577, 25)
        sepRight.Name = "sepRight"
        sepRight.Size = New Size(1, 481)
        sepRight.TabIndex = 5
        ' 
        ' sepTop
        ' 
        sepTop.Dock = DockStyle.Top
        sepTop.FillColor = SystemColors.ControlText
        sepTop.Location = New Point(0, 24)
        sepTop.Name = "sepTop"
        sepTop.Size = New Size(746, 1)
        sepTop.TabIndex = 6
        ' 
        ' mnsOptions
        ' 
        mnsOptions.Items.AddRange(New ToolStripItem() {smiForm, smiComponents})
        mnsOptions.Location = New Point(0, 0)
        mnsOptions.Name = "mnsOptions"
        mnsOptions.Size = New Size(746, 24)
        mnsOptions.TabIndex = 2
        mnsOptions.Text = "MenuStrip1"
        ' 
        ' smiForm
        ' 
        smiForm.DropDownItems.AddRange(New ToolStripItem() {smiLoad, smiPreview, smiSave, smiReset})
        smiForm.Name = "smiForm"
        smiForm.Size = New Size(47, 20)
        smiForm.Text = "Form"
        ' 
        ' smiLoad
        ' 
        smiLoad.Name = "smiLoad"
        smiLoad.Size = New Size(180, 22)
        smiLoad.Text = "Load"
        ' 
        ' smiPreview
        ' 
        smiPreview.Name = "smiPreview"
        smiPreview.Size = New Size(180, 22)
        smiPreview.Text = "Preview"
        ' 
        ' smiSave
        ' 
        smiSave.ForeColor = SystemColors.ControlText
        smiSave.Name = "smiSave"
        smiSave.Size = New Size(180, 22)
        smiSave.Text = "Save"
        ' 
        ' smiReset
        ' 
        smiReset.BackColor = SystemColors.Control
        smiReset.ForeColor = SystemColors.ControlText
        smiReset.Name = "smiReset"
        smiReset.Size = New Size(180, 22)
        smiReset.Text = "Reset"
        ' 
        ' smiComponents
        ' 
        smiComponents.DropDownItems.AddRange(New ToolStripItem() {smiAddNew})
        smiComponents.Name = "smiComponents"
        smiComponents.Size = New Size(88, 20)
        smiComponents.Text = "Components"
        ' 
        ' smiAddNew
        ' 
        smiAddNew.DropDownItems.AddRange(New ToolStripItem() {smiTextbox, smiDropdownbox})
        smiAddNew.Name = "smiAddNew"
        smiAddNew.Size = New Size(123, 22)
        smiAddNew.Text = "Add New"
        ' 
        ' smiTextbox
        ' 
        smiTextbox.Name = "smiTextbox"
        smiTextbox.Size = New Size(149, 22)
        smiTextbox.Text = "Textbox"
        ' 
        ' smiDropdownbox
        ' 
        smiDropdownbox.Name = "smiDropdownbox"
        smiDropdownbox.Size = New Size(149, 22)
        smiDropdownbox.Text = "Dropdownbox"
        ' 
        ' EditorView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlPreview)
        Controls.Add(sepRight)
        Controls.Add(pnlRight)
        Controls.Add(sepTop)
        Controls.Add(mnsOptions)
        Name = "EditorView"
        Size = New Size(746, 506)
        mnsOptions.ResumeLayout(False)
        mnsOptions.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlRight As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlPreview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents sepRight As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents sepTop As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents mnsOptions As MenuStrip
    Friend WithEvents smiForm As ToolStripMenuItem
    Friend WithEvents smiSave As ToolStripMenuItem
    Friend WithEvents smiReset As ToolStripMenuItem
    Friend WithEvents smiPreview As ToolStripMenuItem
    Friend WithEvents smiLoad As ToolStripMenuItem
    Friend WithEvents smiComponents As ToolStripMenuItem
    Friend WithEvents smiAddNew As ToolStripMenuItem
    Friend WithEvents smiTextbox As ToolStripMenuItem
    Friend WithEvents smiDropdownbox As ToolStripMenuItem

End Class
