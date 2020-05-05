Public Class frmDept

    Private Sub TBL_DeptBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TBL_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
    End Sub

    Private Sub frmDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Dept' table. You can move, or remove it, as needed.
        Me.TBL_DeptTableAdapter.Fill(Me.REM_DBDataSet.TBL_Dept)
        grpDept.Enabled = False
        btnSave.Enabled = False
        btnCan.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TBL_DeptBindingSource.AddNew()
        grpDept.Enabled = True
        grpSearch.Enabled = False
        btnAdd.Enabled = False
        btnClose.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Short_CodeTextBox.Text = "" Then
            MsgBox("Please Enter Department Short Code", MsgBoxStyle.Exclamation, "Enter Short Code")
            Short_CodeTextBox.Select()
        ElseIf Department_NameTextBox.Text = "" Then
            MsgBox("Please Enter Name Of Department", MsgBoxStyle.Exclamation, "Enter Department Name")
            Department_NameTextBox.Select()
        Else
            Me.Validate()
            Me.TBL_DeptBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)

            grpDept.Enabled = False
            grpSearch.Enabled = True
            btnAdd.Enabled = True
            btnClose.Enabled = True
            btnSave.Enabled = False
            btnCan.Enabled = False
        End If
    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBL_DeptBindingSource.CancelEdit()
        grpDept.Enabled = False
        grpSearch.Enabled = True
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        TBL_DeptBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        TBL_DeptBindingSource.MoveLast()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        TBL_DeptBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TBL_DeptBindingSource.MoveNext()
    End Sub

    Private Sub Short_CodeTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Short_CodeTextBox.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = False And Asc(e.KeyChar) = 32 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Department_NameTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Department_NameTextBox.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TBL_DeptDataGridView.RowCount > 0 Then
            grpSearch.Enabled = False
            grpDept.Enabled = True
            btnAdd.Enabled = False
            btnClose.Enabled = False
            btnSave.Enabled = True
            btnCan.Enabled = True
        Else
            MsgBox("At Least One Record Needed To Edit", MsgBoxStyle.Exclamation, "Record Needed")
        End If
    End Sub
End Class