Imports System.Windows.Forms

Public Class frmHome

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If frmLogin.cmbID.Text = "Admin" Then
            BasicInformationToolStripMenuItem.Visible = True
            DepartmentToolStripMenuItem.Visible = True
            ClassToolStripMenuItem.Visible = False
            ResultEntryToolStripMenuItem1.Visible = False
            ToolStripMenuItem3.Visible = False
            ToolStripMenuItem5.Visible = False
            ToolStripSeparator1.Visible = False
        Else
            BasicInformationToolStripMenuItem.Visible = False
            DepartmentToolStripMenuItem.Visible = False
            ClassToolStripMenuItem.Text = frmLogin.cmbID.Text
            SendEmailToolStripMenuItem.Visible = False
            ToolStripMenuItem4.Visible = False
            BackupToolStripMenuItem.Visible = False
            ToolStripMenuItem6.Visible = False
            ToolStripMenuItem8.Visible = False
            SendMarksheetsATKTToolStripMenuItem.Visible = False
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        If MsgBox("Are You Sure To Exit ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Exit") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub frmHome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are You Sure To Exit ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Exit") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BranchInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchInformationToolStripMenuItem.Click
        frmBranch.Show()
    End Sub

    Private Sub SubjectInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectInformationToolStripMenuItem.Click
        frmSubject.Show()
    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentInformationToolStripMenuItem.Click
        frmStudent.Show()
    End Sub

    Private Sub UserInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserInformationToolStripMenuItem.Click
        frmUser.Show()
    End Sub

    Private Sub ResultEntryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultEntryToolStripMenuItem1.Click
        frmResult.Show()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentListToolStripMenuItem.Click
        frmStud_Report.Show()
    End Sub

    Private Sub ShowMarksheetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMarksheetsToolStripMenuItem.Click
        frmMarksheet.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        frmBackup.Show()
    End Sub

    Private Sub SendEmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEmailToolStripMenuItem.Click
        frmMail_Login.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        frmDept.Show()
    End Sub

    Private Sub ClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassToolStripMenuItem.Click
        frmClass.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmAtkt.Show()
    End Sub

    Private Sub SendMarksheetsATKTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMarksheetsATKTToolStripMenuItem.Click
        frmMail_Login_Atkt.Show()
    End Sub
End Class
