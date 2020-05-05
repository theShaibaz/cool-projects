Imports System.Data.OleDb
Public Class frmSubject
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable

    Private Sub frmSubject_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        con.Close()
    End Sub

    Private Sub frmSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Subject' table. You can move, or remove it, as needed.
        Me.TBL_SubjectTableAdapter.Fill(Me.REM_DBDataSet.TBL_Subject)

        grpSub.Enabled = False
        grpMax.Enabled = False
        grpMin.Enabled = False
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnShowAll.Enabled = False

        

    End Sub

    Private Sub Subject_CodeTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Subject_CodeTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Subject_NameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Subject_NameTextBox.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TBL_SubjectBindingSource.RemoveFilter()
        TBL_SubjectBindingSource.AddNew()

        grpMax.Enabled = True
        grpMin.Enabled = True
        grpSub.Enabled = True
        Subject_CodeTextBox.Select()
        cmbBrCode.SelectedIndex = -1
        grpSearch.Enabled = False
        btnAdd.Enabled = False
        btnClose.Enabled = False
        btnSave.Enabled = True
        btnCan.Enabled = True

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Subject_CodeTextBox.Text) = 0 Or Len(Trim(Subject_NameTextBox.Text)) = 0 Or cmbBrCode.SelectedIndex = -1 Then
            MsgBox("Please Enter Valid Subject Details", MsgBoxStyle.Exclamation, "Enter Subject Details")
            If Len(Subject_CodeTextBox.Text) = 0 Then
                Subject_CodeTextBox.Select()
            ElseIf cmbBrCode.SelectedIndex = -1 Then
                cmbBrCode.Select()
            ElseIf Len(Trim(Subject_NameTextBox.Text)) = 0 Then
                Subject_NameTextBox.Select()
            End If
        ElseIf Len(TH_MaxTextBox.Text) = 0 Or Len(TH_MinTextBox.Text) = 0 Then
            MsgBox("Please Enter Valid Mark Details", MsgBoxStyle.Exclamation, "Enter Mark Details")
            If Len(TH_MaxTextBox.Text) = 0 Then
                TH_MaxTextBox.Select()
            Else
                TH_MinTextBox.Select()
            End If
        ElseIf Len(PR_MaxTextBox.Text) = 0 Or Len(PR_MinTextBox.Text) = 0 Then
            MsgBox("Please Enter Valid Mark Details", MsgBoxStyle.Exclamation, "Enter Mark Details")
            If Len(PR_MaxTextBox.Text) = 0 Then
                PR_MaxTextBox.Select()
            Else
                PR_MinTextBox.Select()
            End If
        ElseIf Len(OR_MaxTextBox.Text) = 0 Or Len(OR_MinTextBox.Text) = 0 Then
            MsgBox("Please Enter Valid Mark Details", MsgBoxStyle.Exclamation, "Enter Mark Details")
            If Len(OR_MaxTextBox.Text) = 0 Then
                OR_MaxTextBox.Select()
            Else
                OR_MinTextBox.Select()
            End If
        ElseIf Len(TW_MaxTextBox.Text) = 0 Or Len(TW_MinTextBox.Text) = 0 Then
            MsgBox("Please Enter Valid Mark Details", MsgBoxStyle.Exclamation, "Enter Mark Details")
            If Len(TW_MaxTextBox.Text) = 0 Then
                TW_MaxTextBox.Select()
            Else
                TW_MinTextBox.Select()
            End If
        Else
            If TH_MaxTextBox.Text = "0" Then
                TH_MaxTextBox.Text = "-"
            End If
            If TH_MinTextBox.Text = "0" Then
                TH_MinTextBox.Text = "-"
            End If
            If PR_MaxTextBox.Text = "0" Then
                PR_MaxTextBox.Text = "-"
            End If
            If PR_MinTextBox.Text = "0" Then
                PR_MinTextBox.Text = "-"
            End If
            If OR_MaxTextBox.Text = "0" Then
                OR_MaxTextBox.Text = "-"
            End If
            If OR_MinTextBox.Text = "0" Then
                OR_MinTextBox.Text = "-"
            End If
            If TW_MaxTextBox.Text = "0" Then
                TW_MaxTextBox.Text = "-"
            End If
            If TW_MinTextBox.Text = "0" Then
                TW_MinTextBox.Text = "-"
            End If

            Me.Validate()
            Me.TBL_SubjectBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)

            grpSub.Enabled = False
            grpMax.Enabled = False
            grpMin.Enabled = False
            btnCan.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True
            btnAdd.Enabled = True
            grpSearch.Enabled = True
        End If


    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        TBL_SubjectBindingSource.CancelEdit()

        grpSub.Enabled = False
        grpMax.Enabled = False
        grpMin.Enabled = False
        btnCan.Enabled = False
        btnSave.Enabled = False
        btnClose.Enabled = True
        btnAdd.Enabled = True
        grpSearch.Enabled = True
    End Sub

    

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        TBL_SubjectBindingSource.RemoveFilter()
        cmbSearch.SelectedIndex = -1
        cmbSearch.Select()
        txtSearch.Clear()
        btnShowAll.Enabled = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("Please Select Search Citeria", MsgBoxStyle.Exclamation, "Search Record")
            cmbBrCode.Select()
        ElseIf txtSearch.Text = "" Then
            MsgBox("Please Enter Search Query", MsgBoxStyle.Exclamation, "Search Record")
            txtSearch.Select()
        Else
            If cmbSearch.SelectedIndex = 0 Then
                TBL_SubjectBindingSource.Filter = "Subject_ID=" & Val(txtSearch.Text)
            ElseIf cmbSearch.SelectedIndex = 1 Then
                TBL_SubjectBindingSource.Filter = "Subject_Code=" & Val(txtSearch.Text)
            ElseIf cmbSearch.SelectedIndex = 2 Then
                TBL_SubjectBindingSource.Filter = "Subject_Name like'" & txtSearch.Text & "%'"
            ElseIf cmbSearch.SelectedIndex = 3 Then
                TBL_SubjectBindingSource.Filter = "Branch_Code like'" & txtSearch.Text & "%'"
            End If
            If TBL_SubjectDataGridView.RowCount < 1 Then
                MsgBox("No Records Found", MsgBoxStyle.Information, "No Records Found")
                TBL_SubjectBindingSource.RemoveFilter()
                btnShowAll.Enabled = False
            Else
                btnShowAll.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If TBL_SubjectDataGridView.RowCount > 0 Then
            grpSub.Enabled = True
            grpMax.Enabled = True
            grpMin.Enabled = True
            grpSearch.Enabled = False
            btnClose.Enabled = False
            btnAdd.Enabled = False
            btnCan.Enabled = True
            btnSave.Enabled = True
        Else
            MsgBox("At Least One Record Needed To Edit", MsgBoxStyle.Exclamation, "Record Needed")
        End If

    End Sub

    Private Sub TH_MaxTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TH_MaxTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TH_MinTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TH_MinTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub PR_MaxTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PR_MaxTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub PR_MinTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PR_MinTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub OR_MaxTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OR_MaxTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub OR_MinTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OR_MinTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TW_MaxTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TW_MaxTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TW_MinTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TW_MinTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub SW_MaxTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub SW_MinTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If TBL_SubjectDataGridView.RowCount > 0 Then
            If (MsgBox("Are You Sure To Delete ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Sure To Delete")) = MsgBoxResult.Yes Then
                TBL_SubjectBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TBL_BranchBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
            End If
        Else
            MsgBox("No Records Available", MsgBoxStyle.Exclamation, "No Records Available")
        End If

    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        txtSearch.Clear()
        txtSearch.Select()
        If cmbSearch.SelectedItem = "Subject ID" Then
            Label2.Text = "Enter Subject ID :"
        ElseIf cmbSearch.SelectedItem = "Subject Code" Then
            Label2.Text = "Enter Subject Code :"
        ElseIf cmbSearch.SelectedItem = "Subject Name" Then
            Label2.Text = "Enter Subject Name :"
        ElseIf cmbSearch.SelectedItem = "Branch Code" Then
            Label2.Text = "Enter Branch Code :"
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        TBL_SubjectBindingSource.MoveFirst()
    End Sub

    Private Sub btnPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPre.Click
        TBL_SubjectBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TBL_SubjectBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        TBL_SubjectBindingSource.MoveLast()
    End Sub

    Private Sub Subject_NameTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subject_NameTextBox.LostFocus
        Subject_NameTextBox.Text = StrConv(Subject_NameTextBox.Text, VbStrConv.ProperCase)
    End Sub
End Class