Imports System.Data.OleDb
Public Class frmLogin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Login' table. You can move, or remove it, as needed.
        Me.TBL_LoginTableAdapter.Fill(Me.REM_DBDataSet.TBL_Login)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb"
        con.Open()
        cmd.CommandText = "Select User_ID from TBL_Login order by User_ID"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmbID.Items.Add(dr(0).ToString)
        Loop
        dr.Close()

        cmbID.SelectedIndex = -1
        cmbID.Select()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If cmbID.SelectedIndex = -1 Then
            MsgBox("Please Select User Name", MsgBoxStyle.Exclamation, "User Name Required")
            cmbID.Select()
        ElseIf txtpass.Text = "" Then
            MsgBox("Please Enter Your Password", MsgBoxStyle.Exclamation, "Password Required")
            txtpass.Select()
        Else
            If txtpass.Text = User_PassTextBox.Text Then
                frmHome.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Password", MsgBoxStyle.Critical, "Login Notification")
                txtpass.Select()
                txtpass.SelectAll()
            End If
        End If

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        End
    End Sub

    Private Sub cmbID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID.SelectedIndexChanged
        txtpass.Select()
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub
End Class
