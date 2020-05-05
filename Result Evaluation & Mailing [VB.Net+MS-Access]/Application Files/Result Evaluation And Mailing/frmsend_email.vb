Imports System.Net.Mail
Imports System.Data.OleDb

Public Class frmsend_email
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable
    Dim i As Integer
    Private Sub frmsend_email_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
    End Sub

    Private Sub frmsend_email_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        txtFrom.Text = frmMail_Login.txtMailID.Text
        btnSend.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If txtSub.Text = "" Then
            MsgBox("Please Enter Email Subject", MsgBoxStyle.Information, "Enter Email Subject")
            txtSub.Select()
        Else
            Me.Enabled = False
            Dim DRName, DRMark, DRMax, DRMin As OleDbDataReader
            Dim cmd1, cmd2, cmd3 As New OleDbCommand
            Dim strmsg, xmailId, TH, PR, Oral, cond_sub, remark As String
            Dim g_total, total, fail, cond, cond_min As Integer
            Dim per As Double

            xmailId = ""
            TH = ""
            PR = ""
            Oral = ""
            cond_sub = ""
            remark = ""
            cmd.CommandText = "Select Distinct Enrollment_number,Exam_Season,Exam_Year,Branch_Code from TBL_Result where Exam_season='" & cmbSeason.Text & "' and Exam_year=" & Val(txtYear.Text) & " and Branch_Code='" & cmbBrCode.Text & "'"
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

                cmd1.CommandText = "Select Subject_Name,TH,PR,[OR],TW from TBL_Result where Enrollment_number='" & dr(0).ToString & "' and Exam_season='" & cmbSeason.Text & "' and Exam_year=" & Val(txtYear.Text) & " and Branch_Code='" & cmbBrCode.Text & "'"
                cmd1.Connection = con
                DRMark = cmd1.ExecuteReader
                Do While DRMark.Read

                    total = total + Val(DRMark(1).ToString) + Val(DRMark(2).ToString) + Val(DRMark(3).ToString) + Val(DRMark(4).ToString)

                    cmd2.CommandText = "Select TH_Max,PR_Max,OR_Max,TW_Max from TBL_Subject where Subject_Name='" & DRMark(0).ToString & "' and Branch_Code='" & cmbBrCode.Text & "'"
                    cmd2.Connection = con
                    DRMax = cmd2.ExecuteReader
                    If DRMax.Read Then
                        g_total = g_total + Val(DRMax(0).ToString) + Val(DRMax(1).ToString) + Val(DRMax(2).ToString) + Val(DRMax(3).ToString)
                    End If

                    cmd3.CommandText = "Select TH_Min,PR_Min,OR_Min,TW_Min from TBL_Subject where Subject_Name='" & DRMark(0).ToString & "' and Branch_Code='" & cmbBrCode.Text & "'"
                    cmd3.Connection = con
                    DRMin = cmd3.ExecuteReader
                    If DRMin.Read Then
                        If DRMark(1).ToString <> "AB" Then
                            If Val(DRMark(1).ToString) < Val(DRMin(0).ToString) Then
                                fail += 1
                                If fail = 1 Then
                                    cond = Val(DRMark(1).ToString)
                                    cond_min = Val(DRMin(0).ToString)
                                    TH = DRMark(1).ToString & "*"
                                    cond_sub = DRMark(0).ToString
                                Else
                                    TH = Val(DRMark(1).ToString) & "*"
                                End If
                            Else
                                TH = DRMark(1).ToString
                            End If
                        Else
                            TH = DRMark(1).ToString
                        End If

                        If DRMark(2).ToString <> "AB" Then
                            If Val(DRMark(2).ToString) < Val(DRMin(1).ToString) Then
                                PR = Val(DRMark(2).ToString) & "*"
                            Else
                                PR = DRMark(2).ToString
                            End If
                        Else
                            PR = DRMark(2).ToString
                        End If

                        If DRMark(3).ToString <> "AB" Then
                            If Val(DRMark(3).ToString) < Val(DRMin(2).ToString) Then
                                Oral = Val(DRMark(3).ToString) & "*"
                            Else
                                Oral = DRMark(3).ToString
                            End If
                        Else
                            Oral = DRMark(3).ToString
                        End If

                    End If
                    strmsg += DRMark(0).ToString + "--" + vbTab + "TH: " + TH + vbTab + "PR: " + PR + vbTab + "OR: " + Oral + vbTab + "TW: " + DRMark(4).ToString + vbNewLine + vbNewLine
                    DRMin.Close()
                    DRMax.Close()
                Loop

                per = Format(((total / g_total) * 100), "0.00")

                If per >= 50 And fail = 1 And cond + 10 >= cond_min Then
                    If per >= 50 And per < 60 Then
                        remark = "Second Class CON"
                    ElseIf per >= 60 And per < 75 Then
                        remark = "First Class CON"
                    ElseIf per >= 75 And per <= 100 Then
                        remark = "First Class With Dist CON"
                    End If
                    strmsg += vbNewLine + "Total Obtained Marks " + total.ToString + "  " + "Out Of " + g_total.ToString + vbNewLine + "Persentage " + per.ToString + "%"
                    strmsg += vbTab + "Codoned For: " + cond_sub.ToString + " " + cond.ToString + "@" + vbNewLine + remark
                ElseIf fail >= 1 And per >= 35 Then
                    remark = "A.T.K.T."
                    strmsg += vbNewLine + "Total Obtained Marks " + total.ToString + "  " + "Out Of " + g_total.ToString + vbNewLine + remark
                ElseIf per < 35 Then
                    remark = "FAIL"
                    strmsg += vbNewLine + "Total Obtained Marks " + total.ToString + "  " + "Out Of " + g_total.ToString + vbNewLine + remark
                Else
                    If per >= 75 And per <= 100 Then
                        remark = "First Class With Dist"
                    ElseIf per >= 60 And per < 75 Then
                        remark = "First Class"
                    ElseIf per >= 50 And per < 60 Then
                        remark = "Second Class"
                    ElseIf per >= 35 And per < 50 Then
                        remark = "Third Class"
                    End If
                    strmsg += vbNewLine + "Total Obtained Marks " + total.ToString + "  " + "Out Of " + g_total.ToString + vbNewLine + "Percentage " + per.ToString + "%" + vbNewLine + remark
                End If

                g_total = 0
                total = 0
                fail = 0

                DRMark.Close()
                MsgBox(strmsg)
                SendEmail(xmailId, strmsg)
            Loop
            dr.Close()
        End If
        Me.Enabled = True
        MsgBox(i.ToString + " Mail(s) Sent Successfully", MsgBoxStyle.Information, "Mail's Sent")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
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
            DataGridView1.DataSource = TBLResultBindingSource
            TBLResultBindingSource.Filter = "Exam_Season='" & cmbSeason.Text & "' and Exam_year=" & Val(txtYear.Text) & " and Branch_Code='" & cmbBrCode.Text & "' "
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
            smtp_server.Credentials = New Net.NetworkCredential(frmMail_Login.txtMailID.Text, frmMail_Login.txtMailPass.Text)
            smtp_server.Port = 587
            smtp_server.EnableSsl = True
            smtp_server.Host = "smtp.mail.yahoo.com"
            email = New MailMessage()
            email.From = New MailAddress(frmMail_Login.txtMailID.Text)
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

    Private Sub txtSeason_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub
End Class