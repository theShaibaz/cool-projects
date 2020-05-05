<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtkt
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
        Dim ORLabel As System.Windows.Forms.Label
        Dim TWLabel As System.Windows.Forms.Label
        Dim PRLabel As System.Windows.Forms.Label
        Dim THLabel As System.Windows.Forms.Label
        Dim Subject_CodeLabel As System.Windows.Forms.Label
        Dim Subject_NameLabel As System.Windows.Forms.Label
        Dim Branch_CodeLabel As System.Windows.Forms.Label
        Dim Enrollment_NumberLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Seat_NumberLabel As System.Windows.Forms.Label
        Dim Exam_SeasonLabel As System.Windows.Forms.Label
        Dim Exam_YearLabel As System.Windows.Forms.Label
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.grpMarks = New System.Windows.Forms.GroupBox
        Me.TW_MaxLabel = New System.Windows.Forms.Label
        Me.TBLSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.OR_MaxLabel = New System.Windows.Forms.Label
        Me.PR_MaxLabel = New System.Windows.Forms.Label
        Me.TH_MaxLabel = New System.Windows.Forms.Label
        Me.Subject_NameTextBox1 = New System.Windows.Forms.TextBox
        Me.TBLAtktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ORTextBox = New System.Windows.Forms.TextBox
        Me.TWTextBox = New System.Windows.Forms.TextBox
        Me.PRTextBox = New System.Windows.Forms.TextBox
        Me.THTextBox = New System.Windows.Forms.TextBox
        Me.cmbSubCode = New System.Windows.Forms.ComboBox
        Me.grpBranch = New System.Windows.Forms.GroupBox
        Me.Student_NameTextBox1 = New System.Windows.Forms.TextBox
        Me.cmbEnroll = New System.Windows.Forms.ComboBox
        Me.TBLStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbBrCode = New System.Windows.Forms.ComboBox
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Seat_NumberTextBox = New System.Windows.Forms.TextBox
        Me.grpExam = New System.Windows.Forms.GroupBox
        Me.cmbSeason = New System.Windows.Forms.ComboBox
        Me.Exam_YearTextBox = New System.Windows.Forms.TextBox
        Me.TBL_AtktTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_AtktTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBL_StudentTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
        Me.TBL_SubjectTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox
        Me.Subject_NameTextBox = New System.Windows.Forms.TextBox
        Me.TBL_AtktDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.btnDelAll = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        ORLabel = New System.Windows.Forms.Label
        TWLabel = New System.Windows.Forms.Label
        PRLabel = New System.Windows.Forms.Label
        THLabel = New System.Windows.Forms.Label
        Subject_CodeLabel = New System.Windows.Forms.Label
        Subject_NameLabel = New System.Windows.Forms.Label
        Branch_CodeLabel = New System.Windows.Forms.Label
        Enrollment_NumberLabel = New System.Windows.Forms.Label
        Student_NameLabel = New System.Windows.Forms.Label
        Seat_NumberLabel = New System.Windows.Forms.Label
        Exam_SeasonLabel = New System.Windows.Forms.Label
        Exam_YearLabel = New System.Windows.Forms.Label
        Me.grpOpe.SuspendLayout()
        Me.grpMarks.SuspendLayout()
        CType(Me.TBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLAtktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBranch.SuspendLayout()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExam.SuspendLayout()
        CType(Me.TBL_AtktDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ORLabel
        '
        ORLabel.AutoSize = True
        ORLabel.Location = New System.Drawing.Point(39, 170)
        ORLabel.Name = "ORLabel"
        ORLabel.Size = New System.Drawing.Size(33, 17)
        ORLabel.TabIndex = 88
        ORLabel.Text = "OR:"
        '
        'TWLabel
        '
        TWLabel.AutoSize = True
        TWLabel.Location = New System.Drawing.Point(189, 171)
        TWLabel.Name = "TWLabel"
        TWLabel.Size = New System.Drawing.Size(34, 17)
        TWLabel.TabIndex = 90
        TWLabel.Text = "TW:"
        '
        'PRLabel
        '
        PRLabel.AutoSize = True
        PRLabel.Location = New System.Drawing.Point(192, 137)
        PRLabel.Name = "PRLabel"
        PRLabel.Size = New System.Drawing.Size(31, 17)
        PRLabel.TabIndex = 84
        PRLabel.Text = "PR:"
        '
        'THLabel
        '
        THLabel.AutoSize = True
        THLabel.Location = New System.Drawing.Point(40, 137)
        THLabel.Name = "THLabel"
        THLabel.Size = New System.Drawing.Size(31, 17)
        THLabel.TabIndex = 82
        THLabel.Text = "TH:"
        '
        'Subject_CodeLabel
        '
        Subject_CodeLabel.AutoSize = True
        Subject_CodeLabel.Location = New System.Drawing.Point(40, 50)
        Subject_CodeLabel.Name = "Subject_CodeLabel"
        Subject_CodeLabel.Size = New System.Drawing.Size(96, 17)
        Subject_CodeLabel.TabIndex = 65
        Subject_CodeLabel.Text = "Subject Code:"
        '
        'Subject_NameLabel
        '
        Subject_NameLabel.AutoSize = True
        Subject_NameLabel.Location = New System.Drawing.Point(40, 85)
        Subject_NameLabel.Name = "Subject_NameLabel"
        Subject_NameLabel.Size = New System.Drawing.Size(100, 17)
        Subject_NameLabel.TabIndex = 66
        Subject_NameLabel.Text = "Subject Name:"
        '
        'Branch_CodeLabel
        '
        Branch_CodeLabel.AutoSize = True
        Branch_CodeLabel.Location = New System.Drawing.Point(30, 39)
        Branch_CodeLabel.Name = "Branch_CodeLabel"
        Branch_CodeLabel.Size = New System.Drawing.Size(94, 17)
        Branch_CodeLabel.TabIndex = 66
        Branch_CodeLabel.Text = "Branch Code:"
        '
        'Enrollment_NumberLabel
        '
        Enrollment_NumberLabel.AutoSize = True
        Enrollment_NumberLabel.Location = New System.Drawing.Point(30, 78)
        Enrollment_NumberLabel.Name = "Enrollment_NumberLabel"
        Enrollment_NumberLabel.Size = New System.Drawing.Size(133, 17)
        Enrollment_NumberLabel.TabIndex = 67
        Enrollment_NumberLabel.Text = "Enrollment Number:"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(30, 122)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(102, 17)
        Student_NameLabel.TabIndex = 68
        Student_NameLabel.Text = "Student Name:"
        '
        'Seat_NumberLabel
        '
        Seat_NumberLabel.AutoSize = True
        Seat_NumberLabel.Location = New System.Drawing.Point(30, 164)
        Seat_NumberLabel.Name = "Seat_NumberLabel"
        Seat_NumberLabel.Size = New System.Drawing.Size(95, 17)
        Seat_NumberLabel.TabIndex = 70
        Seat_NumberLabel.Text = "Seat Number:"
        '
        'Exam_SeasonLabel
        '
        Exam_SeasonLabel.AutoSize = True
        Exam_SeasonLabel.Location = New System.Drawing.Point(66, 36)
        Exam_SeasonLabel.Name = "Exam_SeasonLabel"
        Exam_SeasonLabel.Size = New System.Drawing.Size(98, 17)
        Exam_SeasonLabel.TabIndex = 3
        Exam_SeasonLabel.Text = "Exam Season:"
        '
        'Exam_YearLabel
        '
        Exam_YearLabel.AutoSize = True
        Exam_YearLabel.Location = New System.Drawing.Point(66, 78)
        Exam_YearLabel.Name = "Exam_YearLabel"
        Exam_YearLabel.Size = New System.Drawing.Size(80, 17)
        Exam_YearLabel.TabIndex = 5
        Exam_YearLabel.Text = "Exam Year:"
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(333, 358)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 17
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(46, 358)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 14
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(140, 358)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 31)
        Me.btnPre.TabIndex = 15
        Me.btnPre.Text = "<<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(237, 358)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpOpe
        '
        Me.grpOpe.BackColor = System.Drawing.Color.Transparent
        Me.grpOpe.Controls.Add(Me.btnClose)
        Me.grpOpe.Controls.Add(Me.btnCan)
        Me.grpOpe.Controls.Add(Me.btnSave)
        Me.grpOpe.Controls.Add(Me.btnAdd)
        Me.grpOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpe.Location = New System.Drawing.Point(13, 476)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(399, 66)
        Me.grpOpe.TabIndex = 78
        Me.grpOpe.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(305, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(209, 23)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 12
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(113, 23)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(18, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpMarks
        '
        Me.grpMarks.BackColor = System.Drawing.Color.Transparent
        Me.grpMarks.Controls.Add(Me.TW_MaxLabel)
        Me.grpMarks.Controls.Add(Me.OR_MaxLabel)
        Me.grpMarks.Controls.Add(Me.PR_MaxLabel)
        Me.grpMarks.Controls.Add(Me.TH_MaxLabel)
        Me.grpMarks.Controls.Add(Me.Subject_NameTextBox1)
        Me.grpMarks.Controls.Add(Me.Label4)
        Me.grpMarks.Controls.Add(Me.Label3)
        Me.grpMarks.Controls.Add(Me.Label2)
        Me.grpMarks.Controls.Add(Me.Label1)
        Me.grpMarks.Controls.Add(ORLabel)
        Me.grpMarks.Controls.Add(Me.ORTextBox)
        Me.grpMarks.Controls.Add(TWLabel)
        Me.grpMarks.Controls.Add(Me.TWTextBox)
        Me.grpMarks.Controls.Add(PRLabel)
        Me.grpMarks.Controls.Add(Me.PRTextBox)
        Me.grpMarks.Controls.Add(THLabel)
        Me.grpMarks.Controls.Add(Me.THTextBox)
        Me.grpMarks.Controls.Add(Me.cmbSubCode)
        Me.grpMarks.Controls.Add(Subject_CodeLabel)
        Me.grpMarks.Controls.Add(Subject_NameLabel)
        Me.grpMarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMarks.Location = New System.Drawing.Point(419, 229)
        Me.grpMarks.Name = "grpMarks"
        Me.grpMarks.Size = New System.Drawing.Size(353, 230)
        Me.grpMarks.TabIndex = 77
        Me.grpMarks.TabStop = False
        Me.grpMarks.Text = "Marks Details"
        '
        'TW_MaxLabel
        '
        Me.TW_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "TW_Max", True))
        Me.TW_MaxLabel.Location = New System.Drawing.Point(298, 169)
        Me.TW_MaxLabel.Name = "TW_MaxLabel"
        Me.TW_MaxLabel.Size = New System.Drawing.Size(34, 23)
        Me.TW_MaxLabel.TabIndex = 107
        '
        'TBLSubjectBindingSource
        '
        Me.TBLSubjectBindingSource.DataMember = "TBL_Subject"
        Me.TBLSubjectBindingSource.DataSource = Me.REM_DBDataSet
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OR_MaxLabel
        '
        Me.OR_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "OR_Max", True))
        Me.OR_MaxLabel.Location = New System.Drawing.Point(140, 168)
        Me.OR_MaxLabel.Name = "OR_MaxLabel"
        Me.OR_MaxLabel.Size = New System.Drawing.Size(34, 23)
        Me.OR_MaxLabel.TabIndex = 106
        '
        'PR_MaxLabel
        '
        Me.PR_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "PR_Max", True))
        Me.PR_MaxLabel.Location = New System.Drawing.Point(300, 134)
        Me.PR_MaxLabel.Name = "PR_MaxLabel"
        Me.PR_MaxLabel.Size = New System.Drawing.Size(34, 23)
        Me.PR_MaxLabel.TabIndex = 105
        '
        'TH_MaxLabel
        '
        Me.TH_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "TH_Max", True))
        Me.TH_MaxLabel.Location = New System.Drawing.Point(141, 136)
        Me.TH_MaxLabel.Name = "TH_MaxLabel"
        Me.TH_MaxLabel.Size = New System.Drawing.Size(34, 23)
        Me.TH_MaxLabel.TabIndex = 104
        '
        'Subject_NameTextBox1
        '
        Me.Subject_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Subject_Name", True))
        Me.Subject_NameTextBox1.Location = New System.Drawing.Point(162, 82)
        Me.Subject_NameTextBox1.Name = "Subject_NameTextBox1"
        Me.Subject_NameTextBox1.ReadOnly = True
        Me.Subject_NameTextBox1.Size = New System.Drawing.Size(167, 23)
        Me.Subject_NameTextBox1.TabIndex = 103
        Me.Subject_NameTextBox1.TabStop = False
        '
        'TBLAtktBindingSource
        '
        Me.TBLAtktBindingSource.DataMember = "TBL_Atkt"
        Me.TBLAtktBindingSource.DataSource = Me.REM_DBDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 17)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 17)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "/"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 17)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "/"
        '
        'ORTextBox
        '
        Me.ORTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "OR", True))
        Me.ORTextBox.Location = New System.Drawing.Point(75, 167)
        Me.ORTextBox.MaxLength = 3
        Me.ORTextBox.Name = "ORTextBox"
        Me.ORTextBox.Size = New System.Drawing.Size(36, 23)
        Me.ORTextBox.TabIndex = 9
        Me.ORTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TWTextBox
        '
        Me.TWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "TW", True))
        Me.TWTextBox.Location = New System.Drawing.Point(231, 168)
        Me.TWTextBox.MaxLength = 3
        Me.TWTextBox.Name = "TWTextBox"
        Me.TWTextBox.Size = New System.Drawing.Size(40, 23)
        Me.TWTextBox.TabIndex = 10
        Me.TWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRTextBox
        '
        Me.PRTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "PR", True))
        Me.PRTextBox.Location = New System.Drawing.Point(231, 133)
        Me.PRTextBox.MaxLength = 3
        Me.PRTextBox.Name = "PRTextBox"
        Me.PRTextBox.Size = New System.Drawing.Size(40, 23)
        Me.PRTextBox.TabIndex = 8
        Me.PRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'THTextBox
        '
        Me.THTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.THTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "TH", True))
        Me.THTextBox.Location = New System.Drawing.Point(75, 134)
        Me.THTextBox.MaxLength = 3
        Me.THTextBox.Name = "THTextBox"
        Me.THTextBox.Size = New System.Drawing.Size(36, 23)
        Me.THTextBox.TabIndex = 7
        Me.THTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSubCode
        '
        Me.cmbSubCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Subject_Code", True))
        Me.cmbSubCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBLAtktBindingSource, "Subject_Code", True))
        Me.cmbSubCode.DataSource = Me.TBLSubjectBindingSource
        Me.cmbSubCode.DisplayMember = "Subject_Code"
        Me.cmbSubCode.DropDownHeight = 75
        Me.cmbSubCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubCode.FormattingEnabled = True
        Me.cmbSubCode.IntegralHeight = False
        Me.cmbSubCode.Location = New System.Drawing.Point(162, 47)
        Me.cmbSubCode.Name = "cmbSubCode"
        Me.cmbSubCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbSubCode.TabIndex = 6
        Me.cmbSubCode.ValueMember = "Subject_Code"
        '
        'grpBranch
        '
        Me.grpBranch.BackColor = System.Drawing.Color.Transparent
        Me.grpBranch.Controls.Add(Me.Student_NameTextBox1)
        Me.grpBranch.Controls.Add(Me.cmbEnroll)
        Me.grpBranch.Controls.Add(Me.cmbBrCode)
        Me.grpBranch.Controls.Add(Branch_CodeLabel)
        Me.grpBranch.Controls.Add(Enrollment_NumberLabel)
        Me.grpBranch.Controls.Add(Student_NameLabel)
        Me.grpBranch.Controls.Add(Seat_NumberLabel)
        Me.grpBranch.Controls.Add(Me.Seat_NumberTextBox)
        Me.grpBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBranch.Location = New System.Drawing.Point(12, 261)
        Me.grpBranch.Name = "grpBranch"
        Me.grpBranch.Size = New System.Drawing.Size(399, 198)
        Me.grpBranch.TabIndex = 76
        Me.grpBranch.TabStop = False
        Me.grpBranch.Text = "Branch Details"
        '
        'Student_NameTextBox1
        '
        Me.Student_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Student_Name", True))
        Me.Student_NameTextBox1.Location = New System.Drawing.Point(171, 116)
        Me.Student_NameTextBox1.Name = "Student_NameTextBox1"
        Me.Student_NameTextBox1.ReadOnly = True
        Me.Student_NameTextBox1.Size = New System.Drawing.Size(220, 23)
        Me.Student_NameTextBox1.TabIndex = 104
        Me.Student_NameTextBox1.TabStop = False
        '
        'cmbEnroll
        '
        Me.cmbEnroll.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Enrollment_Number", True))
        Me.cmbEnroll.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBLAtktBindingSource, "Enrollment_Number", True))
        Me.cmbEnroll.DataSource = Me.TBLStudentBindingSource
        Me.cmbEnroll.DisplayMember = "Enrollment_Number"
        Me.cmbEnroll.DropDownHeight = 75
        Me.cmbEnroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnroll.FormattingEnabled = True
        Me.cmbEnroll.IntegralHeight = False
        Me.cmbEnroll.Location = New System.Drawing.Point(171, 72)
        Me.cmbEnroll.Name = "cmbEnroll"
        Me.cmbEnroll.Size = New System.Drawing.Size(184, 24)
        Me.cmbEnroll.TabIndex = 4
        Me.cmbEnroll.ValueMember = "Enrollment_Number"
        '
        'TBLStudentBindingSource
        '
        Me.TBLStudentBindingSource.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'cmbBrCode
        '
        Me.cmbBrCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Branch_Code", True))
        Me.cmbBrCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBLAtktBindingSource, "Branch_Code", True))
        Me.cmbBrCode.DataSource = Me.TBLBranchBindingSource
        Me.cmbBrCode.DisplayMember = "Branch_Code"
        Me.cmbBrCode.DropDownHeight = 75
        Me.cmbBrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrCode.FormattingEnabled = True
        Me.cmbBrCode.IntegralHeight = False
        Me.cmbBrCode.Location = New System.Drawing.Point(171, 32)
        Me.cmbBrCode.Name = "cmbBrCode"
        Me.cmbBrCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbBrCode.TabIndex = 3
        Me.cmbBrCode.ValueMember = "Branch_Code"
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'Seat_NumberTextBox
        '
        Me.Seat_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Seat_Number", True))
        Me.Seat_NumberTextBox.Location = New System.Drawing.Point(171, 158)
        Me.Seat_NumberTextBox.MaxLength = 8
        Me.Seat_NumberTextBox.Name = "Seat_NumberTextBox"
        Me.Seat_NumberTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Seat_NumberTextBox.TabIndex = 5
        '
        'grpExam
        '
        Me.grpExam.BackColor = System.Drawing.Color.Transparent
        Me.grpExam.Controls.Add(Me.cmbSeason)
        Me.grpExam.Controls.Add(Exam_SeasonLabel)
        Me.grpExam.Controls.Add(Exam_YearLabel)
        Me.grpExam.Controls.Add(Me.Exam_YearTextBox)
        Me.grpExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExam.Location = New System.Drawing.Point(12, 136)
        Me.grpExam.Name = "grpExam"
        Me.grpExam.Size = New System.Drawing.Size(399, 119)
        Me.grpExam.TabIndex = 75
        Me.grpExam.TabStop = False
        Me.grpExam.Text = "Exam Details"
        '
        'cmbSeason
        '
        Me.cmbSeason.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBLAtktBindingSource, "Exam_Season", True))
        Me.cmbSeason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Exam_Season", True))
        Me.cmbSeason.DropDownHeight = 75
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.IntegralHeight = False
        Me.cmbSeason.Items.AddRange(New Object() {"Summer", "Winter"})
        Me.cmbSeason.Location = New System.Drawing.Point(176, 32)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(121, 24)
        Me.cmbSeason.TabIndex = 1
        '
        'Exam_YearTextBox
        '
        Me.Exam_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLAtktBindingSource, "Exam_Year", True))
        Me.Exam_YearTextBox.Location = New System.Drawing.Point(176, 75)
        Me.Exam_YearTextBox.MaxLength = 4
        Me.Exam_YearTextBox.Name = "Exam_YearTextBox"
        Me.Exam_YearTextBox.Size = New System.Drawing.Size(75, 23)
        Me.Exam_YearTextBox.TabIndex = 2
        '
        'TBL_AtktTableAdapter
        '
        Me.TBL_AtktTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Me.TBL_AtktTableAdapter
        Me.TableAdapterManager.TBL_BranchTableAdapter = Me.TBL_BranchTableAdapter
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LoginTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ResultTableAdapter = Nothing
        Me.TableAdapterManager.TBL_StudentTableAdapter = Me.TBL_StudentTableAdapter
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Me.TBL_SubjectTableAdapter
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
        'TBL_SubjectTableAdapter
        '
        Me.TBL_SubjectTableAdapter.ClearBeforeFill = True
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLStudentBindingSource, "Student_Name", True))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(39, 570)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Student_NameTextBox.TabIndex = 76
        '
        'Subject_NameTextBox
        '
        Me.Subject_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "Subject_Name", True))
        Me.Subject_NameTextBox.Location = New System.Drawing.Point(164, 570)
        Me.Subject_NameTextBox.Name = "Subject_NameTextBox"
        Me.Subject_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Subject_NameTextBox.TabIndex = 80
        '
        'TBL_AtktDataGridView
        '
        Me.TBL_AtktDataGridView.AllowUserToAddRows = False
        Me.TBL_AtktDataGridView.AllowUserToDeleteRows = False
        Me.TBL_AtktDataGridView.AutoGenerateColumns = False
        Me.TBL_AtktDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_AtktDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TBL_AtktDataGridView.DataSource = Me.TBLAtktBindingSource
        Me.TBL_AtktDataGridView.Location = New System.Drawing.Point(29, 164)
        Me.TBL_AtktDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.TBL_AtktDataGridView.Name = "TBL_AtktDataGridView"
        Me.TBL_AtktDataGridView.ReadOnly = True
        Me.TBL_AtktDataGridView.Size = New System.Drawing.Size(396, 179)
        Me.TBL_AtktDataGridView.TabIndex = 107
        Me.TBL_AtktDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Exam_Season"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Exam Season"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Exam_Year"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Exam Year"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Branch_Code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Branch Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Enrollment_Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Enrollment Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Subject_Code"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subject Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Student_Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Student Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Seat_Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Seat Number"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Subject_Name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Subject Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TH"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TH"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PR"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "OR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "OR"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TW"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TW"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.btnDelAll)
        Me.grpSearch.Controls.Add(Me.Label5)
        Me.grpSearch.Controls.Add(Me.Label6)
        Me.grpSearch.Controls.Add(Me.btnDel)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.btnShowAll)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.cmbSearch)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.TBL_AtktDataGridView)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(785, 136)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(451, 406)
        Me.grpSearch.TabIndex = 108
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Result"
        '
        'btnDelAll
        '
        Me.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAll.Location = New System.Drawing.Point(171, 128)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(100, 25)
        Me.btnDelAll.TabIndex = 111
        Me.btnDelAll.Text = "Delete A&ll"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Search By :"
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(333, 128)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 25)
        Me.btnDel.TabIndex = 23
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(333, 99)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 25)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Location = New System.Drawing.Point(46, 128)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 25)
        Me.btnShowAll.TabIndex = 21
        Me.btnShowAll.Text = "S&how All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(46, 99)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Sea&rch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(271, 58)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 23)
        Me.txtSearch.TabIndex = 19
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownHeight = 75
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.IntegralHeight = False
        Me.cmbSearch.Items.AddRange(New Object() {"Exam Season", "Exam Year", "Branch Code", "Enrollment Number", "Student Name", "Seat Number"})
        Me.cmbSearch.Location = New System.Drawing.Point(46, 57)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 24)
        Me.cmbSearch.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(278, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(635, 54)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Test_paper_icon
        Me.PictureBox2.Location = New System.Drawing.Point(72, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 109
        Me.PictureBox2.TabStop = False
        '
        'frmAtkt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(1248, 555)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.Subject_NameTextBox)
        Me.Controls.Add(Me.Student_NameTextBox)
        Me.Controls.Add(Me.grpOpe)
        Me.Controls.Add(Me.grpMarks)
        Me.Controls.Add(Me.grpBranch)
        Me.Controls.Add(Me.grpExam)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAtkt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result Entry (A.T.K.T.)"
        Me.grpOpe.ResumeLayout(False)
        Me.grpMarks.ResumeLayout(False)
        Me.grpMarks.PerformLayout()
        CType(Me.TBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLAtktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBranch.ResumeLayout(False)
        Me.grpBranch.PerformLayout()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExam.ResumeLayout(False)
        Me.grpExam.PerformLayout()
        CType(Me.TBL_AtktDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grpMarks As System.Windows.Forms.GroupBox
    Friend WithEvents Subject_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TWTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents THTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbSubCode As System.Windows.Forms.ComboBox
    Friend WithEvents grpBranch As System.Windows.Forms.GroupBox
    Friend WithEvents Student_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbEnroll As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBrCode As System.Windows.Forms.ComboBox
    Friend WithEvents Seat_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpExam As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSeason As System.Windows.Forms.ComboBox
    Friend WithEvents Exam_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBLAtktBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_AtktTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_AtktTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_StudentTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
    Friend WithEvents TBLStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SubjectTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
    Friend WithEvents TBLSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TW_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents OR_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents PR_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents TH_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBL_AtktDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
End Class
