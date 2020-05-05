Public Class frmBackup

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        FileCopy("E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb", FolderBrowserDialog1.SelectedPath + "\" + Date.Today + ".accdb")
        pbBackUp.Visible = True
        lblLoad.Visible = True
        Timer1.Start()
        btnClose.Enabled = False
        btnBrow.Enabled = False
        btnCreate.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pbBackUp.Value = 100 Then
            pbBackUp.Value = 0
            Timer1.Stop()
            pbBackUp.Visible = False
            lblLoad.Visible = False
            btnClose.Enabled = True
            btnCreate.Enabled = False
            btnBrow.Enabled = True
            MsgBox("Backup Created Successfully" + vbNewLine + "Location:-  " + txtPath.Text, MsgBoxStyle.Information, "Confirmation")
        Else
            pbBackUp.Value = pbBackUp.Value + 20
        End If

        If lblLoad.Text = "Creating Backup......." Then
            lblLoad.Text = "Creating Backup."
        Else
            lblLoad.Text = lblLoad.Text + "."
        End If


    End Sub

    Private Sub btnBrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrow.Click
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath
        If txtPath.Text <> "" Then
            btnCreate.Enabled = True
        End If
    End Sub

    Private Sub frmBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCreate.Enabled = False
        txtPath.Text = ""
    End Sub
End Class