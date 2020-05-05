Public NotInheritable Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            frmLogin.Show()
        Else
            ProgressBar1.Value += 10
            If Label1.Text = "Loading....." Then
                Label1.Text = "Loading."
            Else
                Label1.Text += "."
            End If
        End If
    End Sub
End Class
