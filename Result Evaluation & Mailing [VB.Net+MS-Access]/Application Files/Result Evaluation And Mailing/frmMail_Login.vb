Public Class frmMail_Login

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        If txtMailID.Text = "" Then
            MsgBox("Please Enter Email Address", MsgBoxStyle.Information, "Enter Email Address")
            txtMailID.Select()
        ElseIf txtMailPass.Text = "" Then
            MsgBox("Please Enter Password", MsgBoxStyle.Information, "Enter Password")
            txtMailPass.Select()
        Else
            Me.Hide()
            frmsend_email.Show()
        End If

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub

    Private Sub frmMail_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMailID.Clear()
        txtMailPass.Clear()
    End Sub

    Private Sub txtMailID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMailID.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtMailPass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMailPass.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ""
        End If
    End Sub
End Class