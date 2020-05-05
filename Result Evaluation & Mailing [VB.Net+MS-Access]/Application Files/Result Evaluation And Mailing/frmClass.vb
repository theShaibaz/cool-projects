Imports System.Data.OleDb
Public Class frmClass
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable

    Private Sub frmClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Subject' table. You can move, or remove it, as needed.
        'Me.TBL_SubjectTableAdapter.Fill(Me.REM_DBDataSet.TBL_Subject)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Result' table. You can move, or remove it, as needed.
        'Me.TBL_ResultTableAdapter.Fill(Me.REM_DBDataSet.TBL_Result)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Student' table. You can move, or remove it, as needed.
        Me.TBL_StudentTableAdapter.Fill(Me.REM_DBDataSet.TBL_Student)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Class' table. You can move, or remove it, as needed.
        Me.TBL_ClassTableAdapter.Fill(Me.REM_DBDataSet.TBL_Class)

        grpStudent.Enabled = False
        btnSave.Enabled = False
        btnCan.Enabled = False

        TBL_ClassBindingSource.Filter = "Class='" & frmLogin.cmbID.Text & "'"
        Me.Text = frmLogin.cmbID.Text

    End Sub

    Private Sub frmClass_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TBL_ClassBindingSource.AddNew()
        ClassComboBox.Text = frmLogin.cmbID.Text
        ClassComboBox.Enabled = False
        TBL_StudentBindingSource.Filter = "Branch='" & Mid(ClassComboBox.Text, 1, 2) & "'"

        grpStudent.Enabled = True
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True
        btnClose.Enabled = False
        grpSearch.Enabled = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Student_NameComboBox.SelectedIndex = -1 Then
            MsgBox("Please Select Student Name", MsgBoxStyle.Exclamation, "Student Name Required")
            Student_NameComboBox.Select()
        ElseIf Enrollment_NumberComboBox.SelectedIndex = -1 Then
            MsgBox("Please Select Enrollment Number", MsgBoxStyle.Exclamation, "Enrollment Number Required")
            Enrollment_NumberComboBox.Select()
        ElseIf Roll_NoTextBox.Text = "" Then
            MsgBox("Please Enter Roll Number", MsgBoxStyle.Exclamation, "Roll Number Required")
            Roll_NoTextBox.Select()
        Else
            Try
                Me.Validate()
                Me.TBL_ClassBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)


                grpStudent.Enabled = False
                grpSearch.Enabled = True
                btnSave.Enabled = False
                btnCan.Enabled = False
                btnAdd.Enabled = True
                btnClose.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBL_ClassBindingSource.CancelEdit()
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnClose.Enabled = True
        grpSearch.Enabled = True
        grpStudent.Enabled = False
        con.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        con.Close()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        TBL_ClassBindingSource.MoveFirst()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        TBL_ClassBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TBL_ClassBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        TBL_ClassBindingSource.MoveLast()
    End Sub

    Private Sub Roll_NoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Roll_NoTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TBL_ClassDataGridView.RowCount > 0 Then
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

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If TBL_ClassDataGridView.RowCount > 0 Then
            If (MsgBox("Are You Sure To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Delete") = MsgBoxResult.Yes) Then
                TBL_ClassBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TBL_ClassBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
            End If
        Else
            MsgBox("No Records Available", MsgBoxStyle.Exclamation, "No Records Available")
        End If
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        If TBL_ClassDataGridView.RowCount > 0 Then
            If (MsgBox("Are You Sure To Delete All Records?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Sure To Delete") = MsgBoxResult.Yes) Then
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb"
                con.Open()
                cmd.CommandText = "Delete from TBL_Class where Class='" & Me.Text & "'"
                cmd.Connection = con
                dr = cmd.ExecuteReader
                con.Close()
                Me.Validate()
                Me.TBL_ClassBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
                MsgBox("Please Restart This Window To Changes Take Effect", MsgBoxStyle.Information, "Restart Required")
                Me.Close()
            End If
        Else
            MsgBox("No Records Available", MsgBoxStyle.Exclamation, "No Records Available")
        End If
    End Sub
End Class