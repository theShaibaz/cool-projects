<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarksheet_Pre
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
        Me.rptMarksheet = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Marksheet_Pre1 = New WindowsApplication1.Marksheet_Pre
        Me.SuspendLayout()
        '
        'rptMarksheet
        '
        Me.rptMarksheet.ActiveViewIndex = 0
        Me.rptMarksheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptMarksheet.DisplayGroupTree = False
        Me.rptMarksheet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptMarksheet.Location = New System.Drawing.Point(0, 0)
        Me.rptMarksheet.Name = "rptMarksheet"
        Me.rptMarksheet.ReportSource = Me.Marksheet_Pre1
        Me.rptMarksheet.Size = New System.Drawing.Size(535, 388)
        Me.rptMarksheet.TabIndex = 0
        '
        'frmMarksheet_Pre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 388)
        Me.Controls.Add(Me.rptMarksheet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMarksheet_Pre"
        Me.Text = "Mark Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptMarksheet As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Marksheet_Pre1 As WindowsApplication1.Marksheet_Pre
End Class
