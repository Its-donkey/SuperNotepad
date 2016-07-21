Imports System.ComponentModel
Imports System.IO
Public Class frmSuperNotepad
    Private activeFile As String = Nothing
    Private changeMade As Boolean = False
    Private textAlignment As String
    Private Sub frmSuperNotepad_Load(sender As Object, e As EventArgs) Handles Me.Load
        staBottomBar.Items("lblTime").Text = DateTime.Now.ToShortTimeString
    End Sub
    Private Sub mnuTopBarFileOpen_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileOpen.Click
        Dim openStream As Stream = Nothing
        Dim dlgOpenFileDialog As New OpenFileDialog()

        dlgOpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        dlgOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        dlgOpenFileDialog.FilterIndex = 1
        dlgOpenFileDialog.RestoreDirectory = True

        If dlgOpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                openStream = dlgOpenFileDialog.OpenFile()
                activeFile = dlgOpenFileDialog.FileName()

                If (openStream IsNot Nothing) Then
                    Using sr As New StreamReader(openStream)
                        Dim line As String
                        ' Read the stream to a string and write the string to the console.
                        line = sr.ReadToEnd()
                        rtfWritingArea.Text = line
                    End Using
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (openStream IsNot Nothing) Then
                    openStream.Close()
                End If
            End Try
        End If

        lblBottomBar.Visible = True
        lblBottomBar.Text = "Editing: " & dlgOpenFileDialog.SafeFileName

    End Sub
    Private Sub mnuTopBarFileSave_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileSave.Click
        If activeFile IsNot Nothing Then
            Dim sw As New System.IO.StreamWriter(activeFile)
            sw.Write(rtfWritingArea.Text)
            sw.Close()
        Else
            mnuTopBarFileSaveAs_Click(sender, e)
        End If
    End Sub
    Private Sub mnuTopBarFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileSaveAs.Click
        Dim saveStream As Stream = Nothing
        Dim dlgSaveFileDialog As New SaveFileDialog()

        dlgSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        dlgSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        dlgSaveFileDialog.FilterIndex = 1
        dlgSaveFileDialog.RestoreDirectory = True

        If dlgSaveFileDialog.ShowDialog() = DialogResult.OK Then
            saveStream = dlgSaveFileDialog.OpenFile()
            activeFile = dlgSaveFileDialog.FileName()
            If (saveStream IsNot Nothing) Then
                Dim sw As New System.IO.StreamWriter(saveStream)
                sw.Write(rtfWritingArea.Text)
                sw.Close()
            End If
        End If

        lblBottomBar.Visible = True
        lblBottomBar.Text = "Saved to: " & dlgSaveFileDialog.FileName
    End Sub


    Private Sub mnuTopBarFormatFont_Click(sender As Object, e As EventArgs) Handles mnuTopBarFormatFont.Click
        Dim dlgFontDialog As New FontDialog()
        Dim previousSatus As String = lblBottomBar.Text

        dlgFontDialog.ShowColor = True
        dlgFontDialog.Color = rtfWritingArea.ForeColor
        dlgFontDialog.Font = rtfWritingArea.Font

        If dlgFontDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                rtfWritingArea.Font = dlgFontDialog.Font
                rtfWritingArea.ForeColor = dlgFontDialog.Color
            Catch ex As Exception
                MessageBox.Show("Unable to apply the selected font: " & ex.Message)
            End Try
        End If

        lblBottomBar.Visible = True
        lblBottomBar.Text = "Font changed to: " & rtfWritingArea.Font.Name & " - " & rtfWritingArea.ForeColor.Name

    End Sub

    Private Sub mnuTopBarFileNew_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileNew.Click
        If rtfWritingArea.Text IsNot "" Or changeMade Then
            If MsgBox("Are you sure?", MsgBoxStyle.OkCancel, "New SuperNotepad") = System.Windows.Forms.DialogResult.OK Then
                rtfWritingArea.Text = ""
            End If
        End If

        lblBottomBar.Visible = False
        changeMade = False
    End Sub

    Private Sub tmrTimeUpdate_Tick(sender As Object, e As EventArgs) Handles tmrTimeUpdate.Tick
        staBottomBar.Items("lblTime").Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub mnuTopBarEditSelectAll_Click(sender As Object, e As EventArgs) Handles mnuTopBarEditSelectAll.Click
        rtfWritingArea.SelectAll()
    End Sub

    Private Sub rtfWritingArea_TextChanged(sender As Object, e As EventArgs)
        changeMade = True
    End Sub

    Private Sub frmSuperNotepad_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If changeMade Then
            Dim saveOnClose As Integer = MsgBox("Would you like to save the changes made?", MsgBoxStyle.YesNoCancel, "Save changes")
            If saveOnClose = System.Windows.Forms.DialogResult.Yes Then
                If activeFile IsNot Nothing Then
                    Dim sw As New System.IO.StreamWriter(activeFile)
                    sw.Write(rtfWritingArea.Text)
                    sw.Close()
                Else
                    mnuTopBarFileSaveAs_Click(sender, e)
                End If
            ElseIf saveOnClose = System.Windows.Forms.DialogResult.No Then
                Application.Exit()
            ElseIf saveOnClose = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub mnuTopBarFileClose_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileClose.Click
        Close()
    End Sub

    Private Sub frmSuperNotepad_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rtfWritingArea.Height = (Me.Height - 88)
        rtfWritingArea.Width = (Me.Width - 16)
    End Sub

    Private Sub mnuTopBarEditClear_Click(sender As Object, e As EventArgs) Handles mnuTopBarEditClear.Click
        Dim clearText As Integer = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Clear Text")
        If clearText = System.Windows.Forms.DialogResult.Yes Then
            rtfWritingArea.Clear()
        ElseIf clearText = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub staBottomBarBtnFontLeft_Click(sender As Object, e As EventArgs) Handles staBottomBarBtnFontLeft.Click
        If textAlignment IsNot "Left" Then
            rtfWritingArea.SelectAll()
            rtfWritingArea.SelectionAlignment = HorizontalAlignment.Left
            textAlignment = "Left"
        End If

        staBottomBarBtnFontLeft.Checked = True
        staBottomBarBtnFontRight.Checked = False
        staBottomBarBtnFontCentre.Checked = False

    End Sub

    Private Sub staBottomBarBtnFontCentre_Click(sender As Object, e As EventArgs) Handles staBottomBarBtnFontCentre.Click
        If textAlignment IsNot "Centre" Then
            rtfWritingArea.SelectAll()
            rtfWritingArea.SelectionAlignment = HorizontalAlignment.Center
            textAlignment = "Centre"
        End If

        staBottomBarBtnFontLeft.Checked = False
        staBottomBarBtnFontRight.Checked = False
        staBottomBarBtnFontCentre.Checked = True

    End Sub

    Private Sub staBottomBarBtnFontRight_Click(sender As Object, e As EventArgs) Handles staBottomBarBtnFontRight.Click
        If textAlignment IsNot "Right" Then
            rtfWritingArea.SelectAll()
            rtfWritingArea.SelectionAlignment = HorizontalAlignment.Right
            textAlignment = "Right"
        End If

        staBottomBarBtnFontLeft.Checked = False
        staBottomBarBtnFontRight.Checked = True
        staBottomBarBtnFontCentre.Checked = False
    End Sub

    Private Sub staBottomBarBtnFont_ButtonClick(sender As Object, e As EventArgs) Handles staBottomBarBtnFont.ButtonClick
        staBottomBarBtnFont.ShowDropDown()
    End Sub

    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        Dim pdf As Byte() = My.Resources.helpFile
        Using tmp As New FileStream("SuperNotepad_help.pdf", FileMode.Create)
            tmp.Write(pdf, 0, pdf.Length)
        End Using
        Process.Start("SuperNotepad_help.pdf")
    End Sub
End Class

