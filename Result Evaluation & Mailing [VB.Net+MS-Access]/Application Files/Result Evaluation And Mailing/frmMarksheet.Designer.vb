<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarksheet
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
        Dim Exam_SeasonLabel As System.Windows.Forms.Label
        Dim Exam_YearLabel As System.Windows.Forms.Label
        Dim Branch_CodeLabel As System.Windows.Forms.Label
        Me.cmbSeason = New System.Windows.Forms.ComboBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.TBLStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.cmbBrCode = New System.Windows.Forms.ComboBox
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnShow = New System.Windows.Forms.Button
        Me.TBL_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_ResultTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBL_StudentTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
        Me.TBL_ResultDataGridView = New System.Windows.Forms.DataGridView
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Exam_SeasonLabel = New System.Windows.Forms.Label
        Exam_YearLabel = New System.Windows.Forms.Label
        Branch_CodeLabel = New System.Windows.Forms.Label
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_ResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exam_SeasonLabel
        '
        Exam_SeasonLabel.AutoSize = True
        Exam_SeasonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_SeasonLabel.Location = New System.Drawing.Point(21, 37)
        Exam_SeasonLabel.Name = "Exam_SeasonLabel"
        Exam_SeasonLabel.Size = New System.Drawing.Size(98, 17)
        Exam_SeasonLabel.TabIndex = 32
        Exam_SeasonLabel.Text = "Exam Season:"
        '
        'Exam_YearLabel
        '
        Exam_YearLabel.AutoSize = True
        Exam_YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_YearLabel.Location = New System.Drawing.Point(175, 93)
        Exam_YearLabel.Name = "Exam_YearLabel"
        Exam_YearLabel.Size = New System.Drawing.Size(80, 17)
        Exam_YearLabel.TabIndex = 33
        Exam_YearLabel.Text = "Exam Year:"
        '
        'Branch_CodeLabel
        '
        Branch_CodeLabel.AutoSize = True
        Branch_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Branch_CodeLabel.Location = New System.Drawing.Point(305, 38)
        Branch_CodeLabel.Name = "Branch_CodeLabel"
        Branch_CodeLabel.Size = New System.Drawing.Size(94, 17)
        Branch_CodeLabel.TabIndex = 74
        Branch_CodeLabel.Text = "Branch Code:"
        '
        'cmbSeason
        '
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.Items.AddRange(New Object() {"Summer", "Winter"})
        Me.cmbSeason.Location = New System.Drawing.Point(132, 35)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(121, 24)
        Me.cmbSeason.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(286, 92)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(91, 23)
        Me.txtYear.TabIndex = 2
        '
        'TBLStudentBindingSource
        '
        Me.TBLStudentBindingSource.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbBrCode
        '
        Me.cmbBrCode.DropDownHeight = 75
        Me.cmbBrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrCode.FormattingEnabled = True
        Me.cmbBrCode.IntegralHeight = False
        Me.cmbBrCode.Location = New System.Drawing.Point(410, 34)
        Me.cmbBrCode.Name = "cmbBrCode"
        Me.cmbBrCode.Size = New System.Drawing.Size(92, 24)
        Me.cmbBrCode.TabIndex = 1
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(167, 304)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(151, 31)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show Marksheet"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'TBL_ResultBindingSource
        '
        Me.TBL_ResultBindingSource.DataMember = "TBL_Result"
        Me.TBL_ResultBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBL_ResultTableAdapter
        '
        Me.TBL_ResultTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BranchTableAdapter = Me.TBL_BranchTableAdapter
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LoginTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ResultTableAdapter = Me.TBL_ResultTableAdapter
        Me.TableAdapterManager.TBL_StudentTableAdapter = Me.TBL_StudentTableAdapter
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BranchTableAdapter
        '
        Me.TBL_BranchTableAdapter.ClearBeforeFill = True
        '
        'TBL_StudentTableAdapter
        '
        Me.TBL_StudentTableAdapter.ClearBeforeFill = True
        '
        'TBL_ResultDataGridView
        '
        Me.TBL_ResultDataGridView.AllowUserToAddRows = False
        Me.TBL_ResultDataGridView.AllowUserToDeleteRows = False
        Me.TBL_ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_ResultDataGridView.Location = New System.Drawing.Point(31, 36)
        Me.TBL_ResultDataGridView.Name = "TBL_ResultDataGridView"
        Me.TBL_ResultDataGridView.ReadOnly = True
        Me.TBL_ResultDataGridView.Size = New System.Drawing.Size(656, 252)
        Me.TBL_ResultDataGridView.TabIndex = 79
        Me.TBL_ResultDataGridView.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(506, 304)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 31)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBL_ResultDataGridView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 304)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbBrCode)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Exam_YearLabel)
        Me.GroupBox2.Controls.Add(Exam_SeasonLabel)
        Me.GroupBox2.Controls.Add(Me.cmbSeason)
        Me.GroupBox2.Controls.Add(Branch_CodeLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(114, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 138)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(635, 54)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Test_paper_icon
        Me.PictureBox2.Location = New System.Drawing.Point(26, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'frmMarksheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(794, 672)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMarksheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Marsheets"
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_ResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSeason As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents cmbBrCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_ResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_ResultTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_ResultDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBL_StudentTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
    Friend WithEvents TBLStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
