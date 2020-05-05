Imports System.Data.OleDb
Public Class frmMarksheet
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dt As New DataTable

    Private Sub TBL_ResultBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TBL_ResultBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.REM_DBDataSet)
    End Sub

    Private Sub frmMarksheet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        con.Close()
    End Sub

    Private Sub frmMarksheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Branch' table. You can move, or remove it, as needed.
        Me.TBL_BranchTableAdapter.Fill(Me.REM_DBDataSet.TBL_Branch)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Student' table. You can move, or remove it, as needed.
        Me.TBL_StudentTableAdapter.Fill(Me.REM_DBDataSet.TBL_Student)
        'TODO: This line of code loads data into the 'REM_DBDataSet.TBL_Result' table. You can move, or remove it, as needed.
        Me.TBL_ResultTableAdapter.Fill(Me.REM_DBDataSet.TBL_Result)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Projects\VB.NET\Final Project\Database\REM_DB.accdb"
        con.Open()
        cmd.CommandText = "Select Branch_Code from TBL_Branch order by Branch_Code"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        Do While dr.Read
            cmbBrCode.Items.Add(dr(0).ToString)
        Loop
        dr.Close()

        If frmLogin.cmbID.Text = "Admin" Then
            cmbBrCode.Enabled = True
        Else
            cmbBrCode.Text = frmLogin.cmbID.Text
            cmbBrCode.Enabled = False
        End If

        TBL_ResultDataGridView.DataSource = ""
        btnPrint.Enabled = False

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
            TBL_ResultDataGridView.DataSource = TBL_ResultBindingSource
            TBL_ResultBindingSource.Filter = "Exam_Season='" & cmbSeason.Text & "' and Exam_Year= " & Val(txtYear.Text) & "  and Branch_Code='" & cmbBrCode.Text & "' "
            If TBL_ResultDataGridView.RowCount > 0 Then
                btnPrint.Enabled = True
            Else
                MsgBox("No Results Found", MsgBoxStyle.Exclamation, "No Results Found")
                TBL_ResultDataGridView.DataSource = ""
                btnPrint.Enabled = False
            End If
        End If

        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmMarksheet_Pre.Show()
    End Sub

    Private Sub txtYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYear.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub
End Class