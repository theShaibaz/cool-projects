Imports System.Data.OleDb
Public Class frmUser
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable

    Private Sub frmUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con.Close()
    End Sub

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Login' table. You can move, or remove it, as needed.
        Me.TBL_LoginTableAdapter.Fill(Me.REM_DBDataSet.TBL_Login)

        grpUser.Enabled = False
        btnCan.Enabled = False
        btnSave.Enabled = False

        

    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBL_LoginBindingSource.CancelEdit()
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnClose.Enabled = True
        grpSearch.Enabled = True
        grpUser.Enabled = False
    End Sub

    Private Sub User_PassTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles User_PassTextBox.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TBL_LoginBindingSource.AddNew()
        'cmbUID.Select()

        grpUser.Enabled = True
        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True
        btnClose.Enabled = False
        grpSearch.Enabled = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(cmbUID.Text)) = 0 Then
            MsgBox("Please Enter User ID", MsgBoxStyle.Exclamation, "Enter User ID")
            cmbUID.Select()
        ElseIf Len(User_PassTextBox.Text) = 0 Then
            MsgBox("Please Enter Password", MsgBoxStyle.Exclamation, "Enter Password")
            User_PassTextBox.Select()
        ElseIf User_PassTextBox.Text.Length < 8 Then
            MsgBox("Password Length Should Greater Than or Equal To 8 Characters", MsgBoxStyle.Information, "Insufficient Password Length")
            User_PassTextBox.Select()
            User_PassTextBox.SelectAll()
        Else
            Try
                Me.Validate()
                Me.TBL_LoginBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)

                grpUser.Enabled = False
                grpSearch.Enabled = True
                btnSave.Enabled = False
                btnCan.Enabled = False
                btnAdd.Enabled = True
                btnClose.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        TBL_LoginBindingSource.MoveFirst()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        TBL_LoginBindingSource.MoveLast()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        TBL_LoginBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TBL_LoginBindingSource.MoveNext()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (MsgBox("Are You Sure To Delete ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure To Delete")) = MsgBoxResult.Yes Then
            TBL_LoginBindingSource.RemoveCurrent()
            Me.Validate()
            Me.TBL_LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
        End If
    End Sub

    Private Sub chkShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            User_PassTextBox.UseSystemPasswordChar = False
        Else
            User_PassTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TBL_LoginDataGridView.RowCount > 1 Then
            grpSearch.Enabled = False
            grpUser.Enabled = True
            btnAdd.Enabled = False
            btnClose.Enabled = False
            btnSave.Enabled = True
            btnCan.Enabled = True
        Else
            MsgBox("Please Select A Record", MsgBoxStyle.Critical, "Select Record")
        End If
    End Sub
End Class