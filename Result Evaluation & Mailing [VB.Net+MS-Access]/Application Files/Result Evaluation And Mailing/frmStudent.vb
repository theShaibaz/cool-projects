Imports System.Data.OleDb
Public Class frmStudent
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable

    Private Sub frmStudent_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
    End Sub

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Dept' table. You can move, or remove it, as needed.
        Me.TBL_DeptTableAdapter.Fill(Me.REM_DBDataSet.TBL_Dept)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Subject' table. You can move, or remove it, as needed.
        Me.TBL_SubjectTableAdapter.Fill(Me.REM_DBDataSet.TBL_Subject)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Student' table. You can move, or remove it, as needed.
        Me.TBL_StudentTableAdapter.Fill(Me.REM_DBDataSet.TBL_Student)

        grpStudent.Enabled = False
        btnSave.Enabled = False
        btnCan.Enabled = False
        btnShowAll.Enabled = False

        

    End Sub

    Private Sub Enrollment_NumberTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Enrollment_NumberTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Student_NameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Student_NameTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Email_IDTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Email_IDTextBox.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TBL_StudentBindingSource.RemoveFilter()
        TBL_StudentBindingSource.AddNew()
        grpStudent.Enabled = True
        grpSearch.Enabled = False
        btnAdd.Enabled = False
        btnClose.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Len(Enrollment_NumberTextBox.Text) = 0 Then
            MsgBox("Please Enter Enrollment Number", MsgBoxStyle.Exclamation, "Enter Enrollment")
            Enrollment_NumberTextBox.Select()
        ElseIf Len(Trim(Student_NameTextBox.Text)) = 0 Then
            MsgBox("Please Enter Student Name", MsgBoxStyle.Exclamation, "Enter Student Name")
            Student_NameTextBox.Select()
        ElseIf BranchComboBox.SelectedIndex = -1 Then
            MsgBox("Please Select The Branch", MsgBoxStyle.Exclamation, "Select Branch")
            BranchComboBox.Select()
        ElseIf Len(Email_IDTextBox.Text) = 0 Then
            MsgBox("Please Enter Email ID", MsgBoxStyle.Exclamation, "Enter Email ID")
            Email_IDTextBox.Select()
        ElseIf Len(Enrollment_NumberTextBox.Text) < 10 Then
            MsgBox("Please Enter Valid Enrollment Number", MsgBoxStyle.Exclamation, "Enter Enrollment")
            Enrollment_NumberTextBox.Select()
        Else
            Me.Validate()
            Me.TBL_StudentBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)

            grpStudent.Enabled = False
            grpSearch.Enabled = True
            btnAdd.Enabled = True
            btnClose.Enabled = True
            btnSave.Enabled = False
            btnCan.Enabled = False
        End If

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBL_StudentBindingSource.CancelEdit()
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnClose.Enabled = True
        grpSearch.Enabled = True
        grpStudent.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        TBL_StudentBindingSource.RemoveFilter()
        cmbSearch.SelectedIndex = -1
        cmbSearch.Select()
        txtSearch.Clear()
        btnShowAll.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If TBL_StudentDataGridView.RowCount > 0 Then
            grpSearch.Enabled = False
            grpStudent.Enabled = True
            btnAdd.Enabled = False
            btnClose.Enabled = False
            btnSave.Enabled = True
            btnCan.Enabled = True
        Else
            MsgBox("At Least One Record Needed To Edit", MsgBoxStyle.Exclamation, "Record Needed")
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
                TBL_StudentBindingSource.Filter = "Enrollment_Number like '" & txtSearch.Text & "%'"
            ElseIf cmbSearch.SelectedIndex = 1 Then
                TBL_StudentBindingSource.Filter = "Student_Name like'" & txtSearch.Text & "%'"
            ElseIf cmbSearch.SelectedIndex = 2 Then
                TBL_StudentBindingSource.Filter = "Branch='" & txtSearch.Text & "'"
            End If

            If TBL_StudentDataGridView.RowCount < 1 Then
                MsgBox("No Records Found", MsgBoxStyle.Information, "No Records Found")
                TBL_StudentBindingSource.RemoveFilter()
                btnShowAll.Enabled = False
            Else
                btnShowAll.Enabled = True
            End If
        End If

    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        txtSearch.Clear()
        txtSearch.Select()
        If cmbSearch.SelectedItem = "Enrollment Number" Then
            Label2.Text = "Enter Enrollment :"
        ElseIf cmbSearch.SelectedItem = "Student Name" Then
            Label2.Text = "Enter Student Name :"
        ElseIf cmbSearch.SelectedItem = "Branch" Then
            Label2.Text = "Enter Branch :"
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If TBL_StudentDataGridView.RowCount > 0 Then
            If (MsgBox("Are You Sure To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Delete") = MsgBoxResult.Yes) Then
                TBL_StudentBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TBL_StudentBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
            End If
        Else
            MsgBox("No Records Available", MsgBoxStyle.Exclamation, "No Records Available")
        End If

    End Sub

    Private Sub Student_NameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Student_NameTextBox.LostFocus
        Student_NameTextBox.Text = StrConv(Student_NameTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        If TBL_StudentDataGridView.RowCount > 0 Then
            If (MsgBox("Are You Sure To Delete All Records?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Delete") = MsgBoxResult.Yes) Then
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb"
                con.Open()
                cmd.CommandText = "Delete * from TBL_Student"
                cmd.Connection = con
                dr = cmd.ExecuteReader
                con.Close()
                Me.Validate()
                Me.TBL_StudentBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
                MsgBox("Please Restart This Window To Changes Take Effect", MsgBoxStyle.Information, "Restart Required")
                Me.Close()
            End If
        Else
            MsgBox("No Records Available", MsgBoxStyle.Exclamation, "No Records Available")
        End If
    End Sub
End Class