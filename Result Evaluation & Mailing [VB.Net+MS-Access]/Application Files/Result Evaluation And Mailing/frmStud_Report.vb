Public Class frmStud_Report

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("Please Select Search Citeria", MsgBoxStyle.Exclamation, "Search Record")
            cmbSearch.Select()
        ElseIf txtSearch.Text = "" Then
            MsgBox("Please Enter Search Query", MsgBoxStyle.Exclamation, "Search Record")
            txtSearch.Select()
        Else
            Select Case cmbSearch.SelectedIndex
                Case 0
                    rptStud.SelectionFormula = "{TBL_Student:Enrollment_Number}='" & txtSearch.Text & "'"
                Case 1
                    rptStud.SelectionFormula = "{TBL_Student:Branch}like'" & (txtSearch.Text) & "*'"
                Case 2
                    rptStud.SelectionFormula = "{TBL_Student:Student_Name}like'" & (txtSearch.Text) & "*'"
            End Select

            rptStud.RefreshReport()
        End If
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        rptStud.SelectionFormula = "{TBL_Student:Enrollment_Number}<>' '"
        rptStud.RefreshReport()
    End Sub

End Class