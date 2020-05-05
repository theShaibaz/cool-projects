Public Class frmMarksheet_Pre

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptMarksheet.Load
        rptMarksheet.SelectionFormula = "{TBL_Result:Branch_Code}='" & frmMarksheet.cmbBrCode.Text & "'"
    End Sub
End Class