<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuperNotepad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuperNotepad))
        Me.mnuTopBar = New System.Windows.Forms.MenuStrip()
        Me.mnuTopBarFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTopBarFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarEditClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFormatFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.staBottomBar = New System.Windows.Forms.StatusStrip()
        Me.staBottomBarBtnFont = New System.Windows.Forms.ToolStripSplitButton()
        Me.staBottomBarBtnFontRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.staBottomBarBtnFontCentre = New System.Windows.Forms.ToolStripMenuItem()
        Me.staBottomBarBtnFontLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVerticalBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblBottomBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVerticalBar1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrTimeUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.rtfWritingArea = New System.Windows.Forms.RichTextBox()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBar.SuspendLayout()
        Me.staBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTopBar
        '
        Me.mnuTopBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFile, Me.mnuTopBarEdit, Me.mnuTopBarFormat, Me.mnuTopBarHelp})
        Me.mnuTopBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopBar.Name = "mnuTopBar"
        Me.mnuTopBar.Size = New System.Drawing.Size(749, 24)
        Me.mnuTopBar.TabIndex = 0
        Me.mnuTopBar.Text = "MenuStrip1"
        '
        'mnuTopBarFile
        '
        Me.mnuTopBarFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFileNew, Me.mnuTopBarFileOpen, Me.mnuTopBarFileSave, Me.mnuTopBarFileSaveAs, Me.ToolStripSeparator2, Me.mnuTopBarFileClose})
        Me.mnuTopBarFile.Name = "mnuTopBarFile"
        Me.mnuTopBarFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuTopBarFile.Text = "&File"
        '
        'mnuTopBarFileNew
        '
        Me.mnuTopBarFileNew.Name = "mnuTopBarFileNew"
        Me.mnuTopBarFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuTopBarFileNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarFileNew.Text = "&New"
        '
        'mnuTopBarFileOpen
        '
        Me.mnuTopBarFileOpen.Name = "mnuTopBarFileOpen"
        Me.mnuTopBarFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuTopBarFileOpen.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarFileOpen.Text = "&Open"
        '
        'mnuTopBarFileSave
        '
        Me.mnuTopBarFileSave.Name = "mnuTopBarFileSave"
        Me.mnuTopBarFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuTopBarFileSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarFileSave.Text = "&Save"
        '
        'mnuTopBarFileSaveAs
        '
        Me.mnuTopBarFileSaveAs.Name = "mnuTopBarFileSaveAs"
        Me.mnuTopBarFileSaveAs.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.mnuTopBarFileSaveAs.ShowShortcutKeys = False
        Me.mnuTopBarFileSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarFileSaveAs.Text = "Sa&ve As"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'mnuTopBarFileClose
        '
        Me.mnuTopBarFileClose.Name = "mnuTopBarFileClose"
        Me.mnuTopBarFileClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuTopBarFileClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarFileClose.Text = "&Close"
        '
        'mnuTopBarEdit
        '
        Me.mnuTopBarEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarEditSelectAll, Me.mnuTopBarEditClear})
        Me.mnuTopBarEdit.Name = "mnuTopBarEdit"
        Me.mnuTopBarEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuTopBarEdit.Text = "&Edit"
        '
        'mnuTopBarEditSelectAll
        '
        Me.mnuTopBarEditSelectAll.Name = "mnuTopBarEditSelectAll"
        Me.mnuTopBarEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuTopBarEditSelectAll.Size = New System.Drawing.Size(175, 22)
        Me.mnuTopBarEditSelectAll.Text = "Select &All"
        '
        'mnuTopBarEditClear
        '
        Me.mnuTopBarEditClear.Name = "mnuTopBarEditClear"
        Me.mnuTopBarEditClear.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuTopBarEditClear.Size = New System.Drawing.Size(175, 22)
        Me.mnuTopBarEditClear.Text = "Clear"
        '
        'mnuTopBarFormat
        '
        Me.mnuTopBarFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFormatFont})
        Me.mnuTopBarFormat.Name = "mnuTopBarFormat"
        Me.mnuTopBarFormat.Size = New System.Drawing.Size(57, 20)
        Me.mnuTopBarFormat.Text = "For&mat"
        '
        'mnuTopBarFormatFont
        '
        Me.mnuTopBarFormatFont.Name = "mnuTopBarFormatFont"
        Me.mnuTopBarFormatFont.Size = New System.Drawing.Size(98, 22)
        Me.mnuTopBarFormatFont.Text = "&Font"
        '
        'mnuTopBarHelp
        '
        Me.mnuTopBarHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupportToolStripMenuItem})
        Me.mnuTopBarHelp.Name = "mnuTopBarHelp"
        Me.mnuTopBarHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuTopBarHelp.Text = "&Help"
        '
        'staBottomBar
        '
        Me.staBottomBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.staBottomBarBtnFont, Me.lblVerticalBar, Me.lblBottomBar, Me.lblVerticalBar1, Me.lblTime})
        Me.staBottomBar.Location = New System.Drawing.Point(0, 479)
        Me.staBottomBar.Name = "staBottomBar"
        Me.staBottomBar.Size = New System.Drawing.Size(749, 22)
        Me.staBottomBar.TabIndex = 2
        Me.staBottomBar.Text = "StatusStrip1"
        '
        'staBottomBarBtnFont
        '
        Me.staBottomBarBtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.staBottomBarBtnFont.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.staBottomBarBtnFontRight, Me.staBottomBarBtnFontCentre, Me.staBottomBarBtnFontLeft})
        Me.staBottomBarBtnFont.Image = CType(resources.GetObject("staBottomBarBtnFont.Image"), System.Drawing.Image)
        Me.staBottomBarBtnFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.staBottomBarBtnFont.Name = "staBottomBarBtnFont"
        Me.staBottomBarBtnFont.Size = New System.Drawing.Size(51, 20)
        Me.staBottomBarBtnFont.Text = "Align"
        Me.staBottomBarBtnFont.ToolTipText = "Change Font"
        '
        'staBottomBarBtnFontRight
        '
        Me.staBottomBarBtnFontRight.Name = "staBottomBarBtnFontRight"
        Me.staBottomBarBtnFontRight.Size = New System.Drawing.Size(109, 22)
        Me.staBottomBarBtnFontRight.Text = "&Right"
        '
        'staBottomBarBtnFontCentre
        '
        Me.staBottomBarBtnFontCentre.Name = "staBottomBarBtnFontCentre"
        Me.staBottomBarBtnFontCentre.Size = New System.Drawing.Size(109, 22)
        Me.staBottomBarBtnFontCentre.Text = "&Centre"
        '
        'staBottomBarBtnFontLeft
        '
        Me.staBottomBarBtnFontLeft.Name = "staBottomBarBtnFontLeft"
        Me.staBottomBarBtnFontLeft.Size = New System.Drawing.Size(109, 22)
        Me.staBottomBarBtnFontLeft.Text = "&Left"
        '
        'lblVerticalBar
        '
        Me.lblVerticalBar.Name = "lblVerticalBar"
        Me.lblVerticalBar.Size = New System.Drawing.Size(22, 17)
        Me.lblVerticalBar.Text = "  |  "
        '
        'lblBottomBar
        '
        Me.lblBottomBar.Name = "lblBottomBar"
        Me.lblBottomBar.Size = New System.Drawing.Size(548, 17)
        Me.lblBottomBar.Spring = True
        '
        'lblVerticalBar1
        '
        Me.lblVerticalBar1.Name = "lblVerticalBar1"
        Me.lblVerticalBar1.Size = New System.Drawing.Size(22, 17)
        Me.lblVerticalBar1.Text = "  |  "
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(91, 17)
        Me.lblTime.Text = "CURRENT_TIME"
        '
        'tmrTimeUpdate
        '
        Me.tmrTimeUpdate.Enabled = True
        '
        'rtfWritingArea
        '
        Me.rtfWritingArea.AcceptsTab = True
        Me.rtfWritingArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfWritingArea.Location = New System.Drawing.Point(0, 28)
        Me.rtfWritingArea.Name = "rtfWritingArea"
        Me.rtfWritingArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtfWritingArea.ShowSelectionMargin = True
        Me.rtfWritingArea.Size = New System.Drawing.Size(749, 448)
        Me.rtfWritingArea.TabIndex = 3
        Me.rtfWritingArea.Text = ""
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SupportToolStripMenuItem.Text = "&Support"
        '
        'frmSuperNotepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 501)
        Me.Controls.Add(Me.rtfWritingArea)
        Me.Controls.Add(Me.staBottomBar)
        Me.Controls.Add(Me.mnuTopBar)
        Me.MainMenuStrip = Me.mnuTopBar
        Me.MinimumSize = New System.Drawing.Size(765, 540)
        Me.Name = "frmSuperNotepad"
        Me.Text = "SuperNotepad"
        Me.mnuTopBar.ResumeLayout(False)
        Me.mnuTopBar.PerformLayout()
        Me.staBottomBar.ResumeLayout(False)
        Me.staBottomBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopBar As MenuStrip
    Friend WithEvents staBottomBar As StatusStrip
    Friend WithEvents mnuTopBarFile As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileOpen As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileSave As ToolStripMenuItem
    Friend WithEvents mnuTopBarFormat As ToolStripMenuItem
    Friend WithEvents mnuTopBarFormatFont As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileNew As ToolStripMenuItem
    Friend WithEvents lblBottomBar As ToolStripStatusLabel
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents tmrTimeUpdate As Timer
    Friend WithEvents lblVerticalBar1 As ToolStripStatusLabel
    Friend WithEvents lblVerticalBar As ToolStripStatusLabel
    Friend WithEvents mnuTopBarEdit As ToolStripMenuItem
    Friend WithEvents mnuTopBarEditSelectAll As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileClose As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuTopBarEditClear As ToolStripMenuItem
    Friend WithEvents staBottomBarBtnFontRight As ToolStripMenuItem
    Friend WithEvents staBottomBarBtnFontCentre As ToolStripMenuItem
    Friend WithEvents staBottomBarBtnFontLeft As ToolStripMenuItem
    Friend WithEvents staBottomBarBtnFont As ToolStripSplitButton
    Friend WithEvents rtfWritingArea As RichTextBox
    Friend WithEvents mnuTopBarHelp As ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As ToolStripMenuItem
End Class
