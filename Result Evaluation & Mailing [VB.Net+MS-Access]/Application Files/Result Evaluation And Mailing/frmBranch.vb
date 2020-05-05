Imports System.Data.OleDb

Public Class frmBranch
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable

    Private Sub frmBranch_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
    End Sub

    Private Sub frmBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Dept' table. You can move, or remove it, as needed.
        Me.TBL_DeptTableAdapter.Fill(Me.REM_DBDataSet.TBL_Dept)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)

        grpBranch.Enabled = False
        btnSave.Enabled = False
        btnCan.Enabled = False

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(Branch_CodeTextBox.Text)) = 0 Then
            MsgBox("Please Enter Valid Branch Code", MsgBoxStyle.Exclamation, "Enter Branch Code")
            Branch_CodeTextBox.Select()
        ElseIf Branch_NameComboBox.SelectedIndex = -1 Then
            MsgBox("Please Enter Valid Branch Name", MsgBoxStyle.Exclamation, "Enter Branch Name")
            Branch_NameComboBox.Select()
        Else

            Me.Validate()
            Me.TBL_BranchBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)

            grpBranch.Enabled = False
            grpSearch.Enabled = True
            btnSave.Enabled = False
            btnCan.Enabled = False
            btnAdd.Enabled = True
            btnClose.Enabled = True
        End If

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBL_BranchBindingSource.CancelEdit()
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnClose.Enabled = True
        grpSearch.Enabled = True
        grpBranch.Enabled = False
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        TBL_BranchBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        TBL_BranchBindingSource.MoveLast()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        TBL_BranchBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TBL_BranchBindingSource.MoveNext()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        grpBranch.Enabled = True
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True
        btnClose.Enabled = False
        grpSearch.Enabled = False

        TBL_BranchBindingSource.RemoveFilter()
        TBL_BranchBindingSource.AddNew()
        Branch_CodeTextBox.Select()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TBL_BranchDataGridView.RowCount > 0 Then
            grpBranch.Enabled = True
            grpSearch.Enabled = False
            btnAdd.Enabled = False
            btnClose.Enabled = False
            btnSave.Enabled = True
            btnCan.Enabled = True
        Else
            MsgBox("Please Select A Record", MsgBoxStyle.Critical, "Select Record")
        End If

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If (MsgBox("Are You Sure To Delete ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure To Delete")) = MsgBoxResult.Yes Then
            TBL_BranchBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TBL_BranchBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
        End If
    End Sub

    Private Sub Branch_CodeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Branch_CodeTextBox.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Branch_NameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.KeyChar = ""
        End If
    End Sub

End Class