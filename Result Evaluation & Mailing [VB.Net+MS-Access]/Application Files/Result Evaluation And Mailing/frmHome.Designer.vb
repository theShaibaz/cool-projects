<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BasicInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BranchInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SubToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.SubjectInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.UserInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResultEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResultEntryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ShowMarksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.SendEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.SendMarksheetsATKTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 365)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 23, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(712, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentToolStripMenuItem, Me.BasicInformationToolStripMenuItem, Me.ClassToolStripMenuItem, Me.ResultEntryToolStripMenuItem, Me.ToolStripMenuItem7, Me.ToolsToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(10, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 34)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.DepartmentToolStripMenuItem.Text = "Departments"
        '
        'BasicInformationToolStripMenuItem
        '
        Me.BasicInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BranchInformationToolStripMenuItem, Me.SubToolStripMenuItem, Me.SubjectInformationToolStripMenuItem, Me.ToolStripMenuItem1, Me.StudentInformationToolStripMenuItem, Me.ToolStripMenuItem2, Me.UserInformationToolStripMenuItem})
        Me.BasicInformationToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicInformationToolStripMenuItem.Name = "BasicInformationToolStripMenuItem"
        Me.BasicInformationToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.BasicInformationToolStripMenuItem.Text = "College Details"
        '
        'BranchInformationToolStripMenuItem
        '
        Me.BranchInformationToolStripMenuItem.Name = "BranchInformationToolStripMenuItem"
        Me.BranchInformationToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.BranchInformationToolStripMenuItem.Text = "Branch Details"
        '
        'SubToolStripMenuItem
        '
        Me.SubToolStripMenuItem.Name = "SubToolStripMenuItem"
        Me.SubToolStripMenuItem.Size = New System.Drawing.Size(257, 6)
        '
        'SubjectInformationToolStripMenuItem
        '
        Me.SubjectInformationToolStripMenuItem.Name = "SubjectInformationToolStripMenuItem"
        Me.SubjectInformationToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.SubjectInformationToolStripMenuItem.Text = "Subject Details"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(257, 6)
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.StudentInformationToolStripMenuItem.Text = "Student Details"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(257, 6)
        '
        'UserInformationToolStripMenuItem
        '
        Me.UserInformationToolStripMenuItem.Name = "UserInformationToolStripMenuItem"
        Me.UserInformationToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.UserInformationToolStripMenuItem.Text = "User Details"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(82, 26)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'ResultEntryToolStripMenuItem
        '
        Me.ResultEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultEntryToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripMenuItem5, Me.ToolStripMenuItem3, Me.ShowMarksheetsToolStripMenuItem, Me.ToolStripMenuItem4, Me.SendEmailToolStripMenuItem, Me.ToolStripMenuItem8, Me.SendMarksheetsATKTToolStripMenuItem})
        Me.ResultEntryToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultEntryToolStripMenuItem.Name = "ResultEntryToolStripMenuItem"
        Me.ResultEntryToolStripMenuItem.Size = New System.Drawing.Size(106, 26)
        Me.ResultEntryToolStripMenuItem.Text = "Result "
        '
        'ResultEntryToolStripMenuItem1
        '
        Me.ResultEntryToolStripMenuItem1.Name = "ResultEntryToolStripMenuItem1"
        Me.ResultEntryToolStripMenuItem1.Size = New System.Drawing.Size(392, 26)
        Me.ResultEntryToolStripMenuItem1.Text = "Result Entry"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(389, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(392, 26)
        Me.ToolStripMenuItem5.Text = "Result Enrty (A.T.K.T.)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(389, 6)
        '
        'ShowMarksheetsToolStripMenuItem
        '
        Me.ShowMarksheetsToolStripMenuItem.Name = "ShowMarksheetsToolStripMenuItem"
        Me.ShowMarksheetsToolStripMenuItem.Size = New System.Drawing.Size(392, 26)
        Me.ShowMarksheetsToolStripMenuItem.Text = "Show Marksheets"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(389, 6)
        '
        'SendEmailToolStripMenuItem
        '
        Me.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem"
        Me.SendEmailToolStripMenuItem.Size = New System.Drawing.Size(392, 26)
        Me.SendEmailToolStripMenuItem.Text = "Send Marksheets"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(389, 6)
        '
        'SendMarksheetsATKTToolStripMenuItem
        '
        Me.SendMarksheetsATKTToolStripMenuItem.Name = "SendMarksheetsATKTToolStripMenuItem"
        Me.SendMarksheetsATKTToolStripMenuItem.Size = New System.Drawing.Size(392, 26)
        Me.SendMarksheetsATKTToolStripMenuItem.Text = "Send Marksheets (A.T.K.T.)"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentListToolStripMenuItem})
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(106, 26)
        Me.ToolStripMenuItem7.Text = "Reports"
        '
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.ToolStripMenuItem6, Me.CalculatorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(82, 26)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(197, 6)
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(70, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.background_blue_abstract
        Me.PictureBox1.Location = New System.Drawing.Point(0, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(712, 331)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 387)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.Text = "Result Evaluation and Mailing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ResultEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultEntryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SendEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BranchInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SubjectInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMarksheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SendMarksheetsATKTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
