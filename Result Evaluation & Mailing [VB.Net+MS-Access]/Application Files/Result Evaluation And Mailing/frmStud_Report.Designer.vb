<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStud_Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rptStud = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Stud_Report1 = New WindowsApplication1.Stud_Report
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'rptStud
        '
        Me.rptStud.ActiveViewIndex = 0
        Me.rptStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptStud.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptStud.Location = New System.Drawing.Point(0, 0)
        Me.rptStud.Name = "rptStud"
        Me.rptStud.ReportSource = Me.Stud_Report1
        Me.rptStud.Size = New System.Drawing.Size(791, 449)
        Me.rptStud.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 107)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 43
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmbSearch.Items.AddRange(New Object() {"Enrollment Number", "Branch Code", "Student Name"})
        Me.cmbSearch.Location = New System.Drawing.Point(12, 58)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearch.TabIndex = 42
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(12, 191)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 23)
        Me.btnShowAll.TabIndex = 41
        Me.btnShowAll.Text = "S&how All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 162)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Sea&rch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmStud_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 449)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rptStud)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmStud_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Database"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rptStud As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Stud_Report1 As WindowsApplication1.Stud_Report
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
