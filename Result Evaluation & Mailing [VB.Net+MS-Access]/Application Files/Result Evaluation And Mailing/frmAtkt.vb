Imports System.Data.OleDb
Public Class frmAtkt
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable
    Dim x_ey, x_es, x_bc, x_eno, x_sn, x_seatno As String
    Private Sub frmAtkt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Subject' table. You can move, or remove it, as needed.
        Me.TBL_SubjectTableAdapter.Fill(Me.REM_DBDataSet.TBL_Subject)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Student' table. You can move, or remove it, as needed.
        Me.TBL_StudentTableAdapter.Fill(Me.REM_DBDataSet.TBL_Student)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Atkt' table. You can move, or remove it, as needed.
        Me.TBL_AtktTableAdapter.Fill(Me.REM_DBDataSet.TBL_Atkt)

        btnShowAll.Enabled = False
        btnSave.Enabled = False
        btnCan.Enabled = False
        grpExam.Enabled = False
        grpBranch.Enabled = False
        grpMarks.Enabled = False

        TBLAtktBindingSource.Filter = "Branch_Code='" & frmLogin.cmbID.Text & "'"

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        TBLAtktBindingSource.AddNew()
        grpExam.Enabled = True
        grpBranch.Enabled = True
        grpMarks.Enabled = True
        grpSearch.Enabled = False
        cmbSeason.SelectedIndex = -1
        btnAdd.Enabled = False
        btnClose.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True
        cmbSeason.Select()

        cmbBrCode.Text = frmLogin.cmbID.Text
        cmbBrCode.Enabled = False

        TBLSubjectBindingSource.Filter = "Branch_Code='" & cmbBrCode.Text & "'"
        TBLStudentBindingSource.Filter = "Branch='" & Mid(cmbBrCode.Text, 1, 2) & "'"

        cmbEnroll.SelectedIndex = -1
        cmbSubCode.SelectedIndex = -1

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbSeason.SelectedIndex = -1 Then
            MsgBox("Please Select Exam Season", MsgBoxStyle.Exclamation, "Warning")
            cmbSeason.Select()
        ElseIf Exam_YearTextBox.Text.Length <= 3 Then
            MsgBox("Please Enter Valid Exam Year", MsgBoxStyle.Exclamation, "Warning")
            Exam_YearTextBox.Select()
        ElseIf cmbBrCode.SelectedIndex = -1 Then
            MsgBox("Please Select Branch Code", MsgBoxStyle.Exclamation, "Warning")
            cmbBrCode.Select()
        ElseIf cmbEnroll.SelectedIndex = -1 Then
            MsgBox("Please Select Enrollment Number", MsgBoxStyle.Exclamation, "Warning")
            cmbEnroll.Select()
        ElseIf Seat_NumberTextBox.Text.Length <= 0 Then
            MsgBox("Please Enter Seat Number", MsgBoxStyle.Exclamation, "Warning")
            Seat_NumberTextBox.Select()
        ElseIf cmbSubCode.SelectedIndex = -1 Then
            MsgBox("Please Select Subject Code", MsgBoxStyle.Exclamation, "Warning")
            cmbSubCode.Select()
        ElseIf THTextBox.Text.Length = 0 And TH_MaxLabel.Text <> "-" Then
            MsgBox("Please Enter Theory Marks", MsgBoxStyle.Exclamation, "Warning")
            THTextBox.Select()
        ElseIf PRTextBox.Text.Length = 0 And PR_MaxLabel.Text <> "-" Then
            MsgBox("Please Enter Practical Marks", MsgBoxStyle.Exclamation, "Warning")
            PRTextBox.Select()
        ElseIf ORTextBox.Text.Length = 0 And OR_MaxLabel.Text <> "-" Then
            MsgBox("Please Enter Oral Marks", MsgBoxStyle.Exclamation, "Warning")
            ORTextBox.Select()
        ElseIf TWTextBox.Text.Length = 0 And TW_MaxLabel.Text <> "-" Then
            MsgBox("Please Enter Term Work Marks", MsgBoxStyle.Exclamation, "Warning")
            TWTextBox.Select()
        ElseIf Val(THTextBox.Text) > Val(TH_MaxLabel.Text) Then
            MsgBox("Please Check Theory Marks", MsgBoxStyle.Critical, "Check Marks")
            THTextBox.Select()
        ElseIf Val(PRTextBox.Text) > Val(PR_MaxLabel.Text) Then
            MsgBox("Please Check Practical Marks", MsgBoxStyle.Critical, "Check Marks")
            PRTextBox.Select()
        ElseIf Val(ORTextBox.Text) > Val(OR_MaxLabel.Text) Then
            MsgBox("Please Check Oral Marks", MsgBoxStyle.Critical, "Check Marks")
            ORTextBox.Select()
        ElseIf Val(TWTextBox.Text) > Val(TW_MaxLabel.Text) Then
            MsgBox("Please Check Term Work Marks", MsgBoxStyle.Critical, "Check Marks")
            TWTextBox.Select()
        Else

            Try
                x_es = cmbSeason.Text
                x_ey = Exam_YearTextBox.Text
                x_bc = cmbBrCode.Text
                x_eno = cmbEnroll.Text
                x_sn = Student_NameTextBox1.Text
                x_seatno = Seat_NumberTextBox.Text

                If TH_MaxLabel.Text = "-" Then
                    THTextBox.Text = "-"
                End If

                If OR_MaxLabel.Text = "-" Then
                    ORTextBox.Text = "-"
                End If

                If PR_MaxLabel.Text = "-" Then
                    PRTextBox.Text = "-"
                End If

                If TW_MaxLabel.Text = "-" Then
                    TWTextBox.Text = "-"
                End If

                Me.Validate()
                Me.TBLAtktBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
                If MsgBox("Result Saved Successefully!" + vbNewLine + "Do you want to keep the same student", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                    btnAdd_Click(sender, e)
                    cmbSeason.Text = x_es
                    Exam_YearTextBox.Text = x_ey
                    cmbBrCode.Text = x_bc
                    cmbEnroll.Text = x_eno
                    Student_NameTextBox1.Text = x_sn
                    Seat_NumberTextBox.Text = x_seatno
                    cmbSubCode.Select()

                Else
                    btnAdd.Enabled = True
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnCan.Enabled = False
                    grpExam.Enabled = False
                    grpBranch.Enabled = False
                    grpMarks.Enabled = False
                    grpSearch.Enabled = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                TBLAtktBindingSource.CancelEdit()
            End Try
        End If
    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBLAtktBindingSource.CancelEdit()
        btnAdd.Enabled = True
        btnClose.Enabled = True
        btnSave.Enabled = False
        btnCan.Enabled = False
        grpExam.Enabled = False
        grpBranch.Enabled = False
        grpMarks.Enabled = False
        grpSearch.Enabled = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        TBLAtktBindingSource.MoveFirst()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        TBLAtktBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TBLAtktBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        TBLAtktBindingSource.MoveLast()
    End Sub
    Private Sub Exam_YearTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Exam_YearTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub THTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles THTextBox.KeyPress
        If Asc(e.KeyChar) <> 65 And Asc(e.KeyChar) <> 66 And Asc(e.KeyChar) <> 97 And Asc(e.KeyChar) <> 98 And Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub PRTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PRTextBox.KeyPress
        If Asc(e.KeyChar) <> 65 And Asc(e.KeyChar) <> 66 And Asc(e.KeyChar) <> 97 And Asc(e.KeyChar) <> 98 And Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ORTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ORTextBox.KeyPress
        If Asc(e.KeyChar) <> 65 And Asc(e.KeyChar) <> 66 And Asc(e.KeyChar) <> 97 And Asc(e.KeyChar) <> 98 And Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TWTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TWTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Seat_NumberTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Seat_NumberTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmbEnroll_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEnroll.SelectedIndexChanged
        If cmbEnroll.Text.Length > 0 Then
            Student_NameTextBox1.Text = Student_NameTextBox.Text
        End If
    End Sub

    Private Sub Student_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Student_NameTextBox.TextChanged
        Student_NameTextBox1.Text = Student_NameTextBox.Text
    End Sub

    Private Sub Subject_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject_NameTextBox.TextChanged
        Subject_NameTextBox1.Text = Subject_NameTextBox.Text
    End Sub

    Private Sub cmbSubCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubCode.SelectedIndexChanged
        If cmbSubCode.Text.Length > 0 Then
            Subject_NameTextBox1.Text = Subject_NameTextBox.Text
        End If
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        txtSearch.Clear()
        txtSearch.Select()
        If cmbSearch.SelectedItem = "Exam Season" Then
            Label5.Text = "Enter Exam Season :"
        ElseIf cmbSearch.SelectedItem = "Exam Year" Then
            Label5.Text = "Enter Exam Year :"
        ElseIf cmbSearch.SelectedItem = "Branch Code" Then
            Label5.Text = "Enter Branch :"
        ElseIf cmbSearch.SelectedItem = "Enrollment Number" Then
            Label5.Text = "Enter Enrollment :"
        ElseIf cmbSearch.SelectedItem = "Student Name" Then
            Label5.Text = "Enter Student Name :"
        ElseIf cmbSearch.SelectedItem = "Seat Number" Then
            Label5.Text = "Enter Seat Number :"
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If TBL_AtktDataGridView.RowCount > 1 Then
            If (MsgBox("Are You Sure To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Delete") = MsgBoxResult.Yes) Then
                TBLAtktBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TBLAtktBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
            End If
        Else
            MsgBox("Please Select A Record", MsgBoxStyle.Critical, "Select Record")
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("Please Select Search Criteria", MsgBoxStyle.Exclamation, "Search Record")
            cmbSearch.Select()
        ElseIf txtSearch.Text = "" Then
            MsgBox("Please Eneter Search Query", MsgBoxStyle.Exclamation, "Search Record")
            txtSearch.Select()
        Else
            If cmbSearch.SelectedIndex = 0 Then
                TBLAtktBindingSource.Filter = "Result_ID=" & Val(txtSearch.Text)
            ElseIf cmbSearch.SelectedIndex = 1 Then
                TBLAtktBindingSource.Filter = "Exam_Season like'" & txtSearch.Text & "'"
            ElseIf cmbSearch.SelectedIndex = 2 Then
                TBLAtktBindingSource.Filter = "Exam_Year=" & Val(txtSearch.Text)
            ElseIf cmbSearch.SelectedIndex = 3 Then
                TBLAtktBindingSource.Filter = "Branch_Code like'" & txtSearch.Text & "%'"
            ElseIf cmbSearch.SelectedIndex = 4 Then
                TBLAtktBindingSource.Filter = "Enrollment_Number like'" & Val(txtSearch.Text) & "%'"
            ElseIf cmbSearch.SelectedIndex = 5 Then
                TBLAtktBindingSource.Filter = "Student_Name like'" & txtSearch.Text & "%'"
            ElseIf cmbSearch.SelectedIndex = 6 Then
                TBLAtktBindingSource.Filter = "Seat_Number=" & Val(txtSearch.Text)
            ElseIf cmbSearch.SelectedIndex = 7 Then
                TBLAtktBindingSource.Filter = "Remark like'" & txtSearch.Text & "%'"
            End If

            If TBL_AtktDataGridView.RowCount < 1 Then
                MsgBox("No Records Found", MsgBoxStyle.Information, "No Records Found")
                TBLAtktBindingSource.RemoveFilter()
                TBLAtktBindingSource.Filter = "Branch_Code='" & frmLogin.cmbID.Text & "'"
                btnShowAll.Enabled = False
            Else
                btnShowAll.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        TBLAtktBindingSource.RemoveFilter()
        TBLAtktBindingSource.Filter = "Branch_Code='" & frmLogin.cmbID.Text & "'"
        btnShowAll.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TBL_AtktDataGridView.RowCount > 0 Then
            grpExam.Enabled = True
            grpBranch.Enabled = True
            grpMarks.Enabled = True
            grpSearch.Enabled = False
            btnAdd.Enabled = False
            btnClose.Enabled = False
            btnSave.Enabled = True
            btnCan.Enabled = True
        Else
            MsgBox("At Least One Record Needed To Edit", MsgBoxStyle.Exclamation, "Record Needed")
        End If
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        If TBL_AtktDataGridView.RowCount > 0 Then
            If (MsgBox("Are You Sure To Delete All Records?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Delete") = MsgBoxResult.Yes) Then
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb"
                con.Open()
                cmd.CommandText = "Delete * from TBL_Atkt"
                cmd.Connection = con
                dr = cmd.ExecuteReader
                con.Close()
                Me.Validate()
                Me.TBLAtktBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
                MsgBox("Please Restart This Window To Changes Take Effect", MsgBoxStyle.Information, "Restart Required")
                Me.Close()
            End If
        Else
            MsgBox("No Records Available", MsgBoxStyle.Exclamation, "No Records Available")
        End If
    End Sub
End Class