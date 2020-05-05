Imports System.Net.Mail
Imports System.Data.OleDb
Public Class frmSend_Email_Atkt
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable
    Dim i As Integer

    Private Sub frmSend_Email_Atkt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Atkt' table. You can move, or remove it, as needed.
        Me.TBL_AtktTableAdapter.Fill(Me.REM_DBDataSet.TBL_Atkt)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Result' table. You can move, or remove it, as needed.
        Me.TBL_ResultTableAdapter.Fill(Me.REM_DBDataSet.TBL_Result)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb"
        con.Open()

        cmd.CommandText = "Select  Branch_Code from TBL_Branch order by Branch_Code"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        Do While dr.Read
            cmbBrCode.Items.Add(dr(0).ToString)
        Loop
        dr.Close()

        txtFrom.Text = frmMail_Login_Atkt.txtMailID.Text
        btnSend.Enabled = False
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If cmbSeason.SelectedIndex = -1 Then
            MsgBox("Please Select Exam Season", MsgBoxStyle.Exclamation, "Exam Season Required")
            cmbSeason.Select()
        ElseIf txtYear.Text = "" Then
            MsgBox("Please Enter Exam Year", MsgBoxStyle.Exclamation, "Exam Year Required")
            txtYear.Select()
        ElseIf cmbBrCode.SelectedIndex = -1 Then
            MsgBox("Please Select Branch", MsgBoxStyle.Exclamation, "Branch Required")
            cmbBrCode.Select()
        Else
            DataGridView1.DataSource = TBLAtktBindingSource
            TBLAtktBindingSource.Filter = "Exam_Season='" & cmbSeason.Text & "' and Exam_year=" & Val(txtYear.Text) & " and Branch_Code='" & cmbBrCode.Text & "' "
            If DataGridView1.RowCount < 1 Then
                MsgBox("No Results Found", MsgBoxStyle.Exclamation, "No Results Found")
            Else
                btnSend.Enabled = True
            End If
        End If

    End Sub

    Sub SendEmail(ByVal toemail As String, ByVal msg As String)
        Try
            Dim smtp_server As New SmtpClient
            Dim email As New MailMessage()
            smtp_server.UseDefaultCredentials = False
            smtp_server.Credentials = New Net.NetworkCredential(frmMail_Login_Atkt.txtMailID.Text, frmMail_Login_Atkt.txtMailPass.Text)
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.mail.yahoo.com"
            email = New MailMessage()
            email.From = New MailAddress(frmMail_Login_Atkt.txtMailID.Text)
            email.To.Add(toemail)
            email.Subject = txtSub.Text
            email.IsBodyHtml = False
            email.Body = msg
            smtp_server.Send(email)
            i = i + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If Len(Trim(txtSub.Text)) = 0 Then
            MsgBox("Please Enter Email Subject", MsgBoxStyle.Information, "Enter Email Subject")
            txtSub.Select()
        Else

            Dim DRName, DRMark As OleDbDataReader
            Dim cmd1, cmd2, cmd3 As New OleDbCommand
            Dim strmsg, xmailId As String

            xmailId = ""
            cmd.CommandText = "Select Distinct Enrollment_number,Exam_Season,Exam_Year,Branch_Code from TBL_Atkt where Exam_season='" & cmbSeason.Text & "' and Exam_year=" & Val(txtYear.Text) & " and Branch_Code='" & cmbBrCode.Text & "'"
            cmd.Connection = con
            dr = cmd.ExecuteReader

            Do While dr.Read
                strmsg = ""
                cmd1.CommandText = "Select Student_Name,email_id from TBL_Student where Enrollment_number='" & dr(0).ToString & "'"
                cmd1.Connection = con
                DRName = cmd1.ExecuteReader
                If DRName.Read Then
                    strmsg += "Name : " + DRName(0).ToString + vbTab + "Enrollment No : " + dr(0).ToString + vbNewLine + dr(1).ToString + "  " + dr(2).ToString + "  Class: " + dr(3).ToString + vbNewLine + vbNewLine
                    xmailId = DRName(1).ToString
                End If
                DRName.Close()

                cmd1.CommandText = "Select Subject_Name,TH,PR,[OR],TW from TBL_Atkt where Enrollment_number='" & dr(0).ToString & "' and Exam_season='" & cmbSeason.Text & "' and Exam_year=" & Val(txtYear.Text) & " and Branch_Code='" & cmbBrCode.Text & "'"
                cmd1.Connection = con
                DRMark = cmd1.ExecuteReader
                Do While DRMark.Read
                    strmsg += vbNewLine + DRMark(0).ToString + vbTab + "TH: " + DRMark(1).ToString + vbTab + "PR: " + DRMark(2).ToString + vbTab + "OR: " + DRMark(3).ToString + vbTab + "TW: " + DRMark(4).ToString
                Loop
                MsgBox(strmsg)
                'SendEmail(xmailId, strmsg)
                DRMark.Close()
            Loop
            dr.Close()
        End If

    End Sub

    Private Sub txtSeason_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub
End Class