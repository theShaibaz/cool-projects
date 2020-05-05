<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResult
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
        Dim Enrollment_NumberLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Seat_NumberLabel As System.Windows.Forms.Label
        Dim Subject_CodeLabel As System.Windows.Forms.Label
        Dim Subject_NameLabel As System.Windows.Forms.Label
        Dim THLabel As System.Windows.Forms.Label
        Dim PRLabel As System.Windows.Forms.Label
        Dim ORLabel As System.Windows.Forms.Label
        Dim TWLabel As System.Windows.Forms.Label
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_ResultTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBL_ClassTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ClassTableAdapter
        Me.TBL_StudentTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
        Me.TBL_SubjectTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
        Me.cmbSeason = New System.Windows.Forms.ComboBox
        Me.Exam_YearTextBox = New System.Windows.Forms.TextBox
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpExam = New System.Windows.Forms.GroupBox
        Me.grpBranch = New System.Windows.Forms.GroupBox
        Me.Student_NameTextBox1 = New System.Windows.Forms.TextBox
        Me.cmbEnroll = New System.Windows.Forms.ComboBox
        Me.TBLClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbBrCode = New System.Windows.Forms.ComboBox
        Me.Seat_NumberTextBox = New System.Windows.Forms.TextBox
        Me.TBLClassBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox
        Me.grpMarks = New System.Windows.Forms.GroupBox
        Me.Subject_NameTextBox1 = New System.Windows.Forms.TextBox
        Me.TW_MaxLabel = New System.Windows.Forms.Label
        Me.OR_MaxLabel = New System.Windows.Forms.Label
        Me.PR_MaxLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TH_MaxLabel = New System.Windows.Forms.Label
        Me.ORTextBox = New System.Windows.Forms.TextBox
        Me.TWTextBox = New System.Windows.Forms.TextBox
        Me.PRTextBox = New System.Windows.Forms.TextBox
        Me.THTextBox = New System.Windows.Forms.TextBox
        Me.cmbSubCode = New System.Windows.Forms.ComboBox
        Me.Subject_NameTextBox = New System.Windows.Forms.TextBox
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.btnDelAll = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TBL_ResultDataGridView = New System.Windows.Forms.DataGridView
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
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.TBLBranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchTBLSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Exam_SeasonLabel = New System.Windows.Forms.Label
        Exam_YearLabel = New System.Windows.Forms.Label
        Branch_CodeLabel = New System.Windows.Forms.Label
        Enrollment_NumberLabel = New System.Windows.Forms.Label
        Student_NameLabel = New System.Windows.Forms.Label
        Seat_NumberLabel = New System.Windows.Forms.Label
        Subject_CodeLabel = New System.Windows.Forms.Label
        Subject_NameLabel = New System.Windows.Forms.Label
        THLabel = New System.Windows.Forms.Label
        PRLabel = New System.Windows.Forms.Label
        ORLabel = New System.Windows.Forms.Label
        TWLabel = New System.Windows.Forms.Label
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExam.SuspendLayout()
        Me.grpBranch.SuspendLayout()
        CType(Me.TBLClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLClassBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMarks.SuspendLayout()
        Me.grpOpe.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.TBL_ResultDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchTBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exam_SeasonLabel
        '
        Exam_SeasonLabel.AutoSize = True
        Exam_SeasonLabel.Location = New System.Drawing.Point(51, 36)
        Exam_SeasonLabel.Name = "Exam_SeasonLabel"
        Exam_SeasonLabel.Size = New System.Drawing.Size(98, 17)
        Exam_SeasonLabel.TabIndex = 3
        Exam_SeasonLabel.Text = "Exam Season:"
        '
        'Exam_YearLabel
        '
        Exam_YearLabel.AutoSize = True
        Exam_YearLabel.Location = New System.Drawing.Point(51, 76)
        Exam_YearLabel.Name = "Exam_YearLabel"
        Exam_YearLabel.Size = New System.Drawing.Size(80, 17)
        Exam_YearLabel.TabIndex = 5
        Exam_YearLabel.Text = "Exam Year:"
        '
        'Branch_CodeLabel
        '
        Branch_CodeLabel.AutoSize = True
        Branch_CodeLabel.Location = New System.Drawing.Point(20, 39)
        Branch_CodeLabel.Name = "Branch_CodeLabel"
        Branch_CodeLabel.Size = New System.Drawing.Size(94, 17)
        Branch_CodeLabel.TabIndex = 66
        Branch_CodeLabel.Text = "Branch Code:"
        '
        'Enrollment_NumberLabel
        '
        Enrollment_NumberLabel.AutoSize = True
        Enrollment_NumberLabel.Location = New System.Drawing.Point(20, 82)
        Enrollment_NumberLabel.Name = "Enrollment_NumberLabel"
        Enrollment_NumberLabel.Size = New System.Drawing.Size(133, 17)
        Enrollment_NumberLabel.TabIndex = 67
        Enrollment_NumberLabel.Text = "Enrollment Number:"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(20, 126)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(102, 17)
        Student_NameLabel.TabIndex = 68
        Student_NameLabel.Text = "Student Name:"
        '
        'Seat_NumberLabel
        '
        Seat_NumberLabel.AutoSize = True
        Seat_NumberLabel.Location = New System.Drawing.Point(20, 167)
        Seat_NumberLabel.Name = "Seat_NumberLabel"
        Seat_NumberLabel.Size = New System.Drawing.Size(95, 17)
        Seat_NumberLabel.TabIndex = 70
        Seat_NumberLabel.Text = "Seat Number:"
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
        'THLabel
        '
        THLabel.AutoSize = True
        THLabel.Location = New System.Drawing.Point(40, 137)
        THLabel.Name = "THLabel"
        THLabel.Size = New System.Drawing.Size(31, 17)
        THLabel.TabIndex = 82
        THLabel.Text = "TH:"
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
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.TBL_ClassTableAdapter = Me.TBL_ClassTableAdapter
        Me.TableAdapterManager.TBL_DeptTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LoginTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ResultTableAdapter = Me.TBL_ResultTableAdapter
        Me.TableAdapterManager.TBL_StudentTableAdapter = Me.TBL_StudentTableAdapter
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Me.TBL_SubjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BranchTableAdapter
        '
        Me.TBL_BranchTableAdapter.ClearBeforeFill = True
        '
        'TBL_ClassTableAdapter
        '
        Me.TBL_ClassTableAdapter.ClearBeforeFill = True
        '
        'TBL_StudentTableAdapter
        '
        Me.TBL_StudentTableAdapter.ClearBeforeFill = True
        '
        'TBL_SubjectTableAdapter
        '
        Me.TBL_SubjectTableAdapter.ClearBeforeFill = True
        '
        'cmbSeason
        '
        Me.cmbSeason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "Exam_Season", True))
        Me.cmbSeason.DropDownHeight = 75
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.IntegralHeight = False
        Me.cmbSeason.Items.AddRange(New Object() {"Summer", "Winter"})
        Me.cmbSeason.Location = New System.Drawing.Point(179, 33)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(121, 24)
        Me.cmbSeason.TabIndex = 1
        '
        'Exam_YearTextBox
        '
        Me.Exam_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "Exam_Year", True))
        Me.Exam_YearTextBox.Location = New System.Drawing.Point(179, 74)
        Me.Exam_YearTextBox.MaxLength = 4
        Me.Exam_YearTextBox.Name = "Exam_YearTextBox"
        Me.Exam_YearTextBox.Size = New System.Drawing.Size(75, 23)
        Me.Exam_YearTextBox.TabIndex = 2
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLSubjectBindingSource
        '
        Me.TBLSubjectBindingSource.DataMember = "TBL_Subject"
        Me.TBLSubjectBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLStudentBindingSource
        '
        Me.TBLStudentBindingSource.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'grpExam
        '
        Me.grpExam.BackColor = System.Drawing.Color.Transparent
        Me.grpExam.Controls.Add(Me.cmbSeason)
        Me.grpExam.Controls.Add(Exam_SeasonLabel)
        Me.grpExam.Controls.Add(Exam_YearLabel)
        Me.grpExam.Controls.Add(Me.Exam_YearTextBox)
        Me.grpExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExam.Location = New System.Drawing.Point(16, 131)
        Me.grpExam.Name = "grpExam"
        Me.grpExam.Size = New System.Drawing.Size(396, 120)
        Me.grpExam.TabIndex = 41
        Me.grpExam.TabStop = False
        Me.grpExam.Text = "Exam Details"
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
        Me.grpBranch.Location = New System.Drawing.Point(16, 279)
        Me.grpBranch.Name = "grpBranch"
        Me.grpBranch.Size = New System.Drawing.Size(396, 211)
        Me.grpBranch.TabIndex = 66
        Me.grpBranch.TabStop = False
        Me.grpBranch.Text = "Branch Details"
        '
        'Student_NameTextBox1
        '
        Me.Student_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "Student_Name", True))
        Me.Student_NameTextBox1.Location = New System.Drawing.Point(179, 124)
        Me.Student_NameTextBox1.Name = "Student_NameTextBox1"
        Me.Student_NameTextBox1.ReadOnly = True
        Me.Student_NameTextBox1.Size = New System.Drawing.Size(211, 23)
        Me.Student_NameTextBox1.TabIndex = 104
        Me.Student_NameTextBox1.TabStop = False
        '
        'cmbEnroll
        '
        Me.cmbEnroll.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_ResultBindingSource, "Enrollment_Number", True))
        Me.cmbEnroll.DataSource = Me.TBLClassBindingSource
        Me.cmbEnroll.DisplayMember = "Enrollment_Number"
        Me.cmbEnroll.DropDownHeight = 75
        Me.cmbEnroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEnroll.FormattingEnabled = True
        Me.cmbEnroll.IntegralHeight = False
        Me.cmbEnroll.Location = New System.Drawing.Point(179, 80)
        Me.cmbEnroll.Name = "cmbEnroll"
        Me.cmbEnroll.Size = New System.Drawing.Size(157, 24)
        Me.cmbEnroll.TabIndex = 3
        Me.cmbEnroll.ValueMember = "Enrollment_Number"
        '
        'TBLClassBindingSource
        '
        Me.TBLClassBindingSource.DataMember = "TBL_Class"
        Me.TBLClassBindingSource.DataSource = Me.REM_DBDataSet
        '
        'cmbBrCode
        '
        Me.cmbBrCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_ResultBindingSource, "Branch_Code", True))
        Me.cmbBrCode.DataSource = Me.TBLBranchBindingSource
        Me.cmbBrCode.DisplayMember = "Branch_Code"
        Me.cmbBrCode.DropDownHeight = 75
        Me.cmbBrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrCode.FormattingEnabled = True
        Me.cmbBrCode.IntegralHeight = False
        Me.cmbBrCode.Location = New System.Drawing.Point(179, 36)
        Me.cmbBrCode.Name = "cmbBrCode"
        Me.cmbBrCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbBrCode.TabIndex = 3
        Me.cmbBrCode.TabStop = False
        Me.cmbBrCode.ValueMember = "Branch_Code"
        '
        'Seat_NumberTextBox
        '
        Me.Seat_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "Seat_Number", True))
        Me.Seat_NumberTextBox.Location = New System.Drawing.Point(179, 165)
        Me.Seat_NumberTextBox.MaxLength = 8
        Me.Seat_NumberTextBox.Name = "Seat_NumberTextBox"
        Me.Seat_NumberTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Seat_NumberTextBox.TabIndex = 4
        '
        'TBLClassBindingSource1
        '
        Me.TBLClassBindingSource1.DataMember = "TBL_Class"
        Me.TBLClassBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource2
        '
        Me.TBLBranchBindingSource2.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource2.DataSource = Me.REM_DBDataSet
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLClassBindingSource, "Student_Name", True))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(38, 632)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.ReadOnly = True
        Me.Student_NameTextBox.Size = New System.Drawing.Size(211, 20)
        Me.Student_NameTextBox.TabIndex = 103
        '
        'grpMarks
        '
        Me.grpMarks.BackColor = System.Drawing.Color.Transparent
        Me.grpMarks.Controls.Add(Me.Subject_NameTextBox1)
        Me.grpMarks.Controls.Add(Me.TW_MaxLabel)
        Me.grpMarks.Controls.Add(Me.OR_MaxLabel)
        Me.grpMarks.Controls.Add(Me.PR_MaxLabel)
        Me.grpMarks.Controls.Add(Me.Label4)
        Me.grpMarks.Controls.Add(Me.Label3)
        Me.grpMarks.Controls.Add(Me.Label2)
        Me.grpMarks.Controls.Add(Me.Label1)
        Me.grpMarks.Controls.Add(Me.TH_MaxLabel)
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
        Me.grpMarks.Location = New System.Drawing.Point(424, 231)
        Me.grpMarks.Name = "grpMarks"
        Me.grpMarks.Size = New System.Drawing.Size(353, 230)
        Me.grpMarks.TabIndex = 67
        Me.grpMarks.TabStop = False
        Me.grpMarks.Text = "Marks Details"
        '
        'Subject_NameTextBox1
        '
        Me.Subject_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "Subject_Name", True))
        Me.Subject_NameTextBox1.Location = New System.Drawing.Point(169, 82)
        Me.Subject_NameTextBox1.Name = "Subject_NameTextBox1"
        Me.Subject_NameTextBox1.ReadOnly = True
        Me.Subject_NameTextBox1.Size = New System.Drawing.Size(156, 23)
        Me.Subject_NameTextBox1.TabIndex = 103
        Me.Subject_NameTextBox1.TabStop = False
        '
        'TW_MaxLabel
        '
        Me.TW_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "TW_Max", True))
        Me.TW_MaxLabel.Location = New System.Drawing.Point(298, 167)
        Me.TW_MaxLabel.Name = "TW_MaxLabel"
        Me.TW_MaxLabel.Size = New System.Drawing.Size(34, 25)
        Me.TW_MaxLabel.TabIndex = 101
        '
        'OR_MaxLabel
        '
        Me.OR_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "OR_Max", True))
        Me.OR_MaxLabel.Location = New System.Drawing.Point(143, 169)
        Me.OR_MaxLabel.Name = "OR_MaxLabel"
        Me.OR_MaxLabel.Size = New System.Drawing.Size(34, 25)
        Me.OR_MaxLabel.TabIndex = 100
        '
        'PR_MaxLabel
        '
        Me.PR_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "PR_Max", True))
        Me.PR_MaxLabel.Location = New System.Drawing.Point(298, 133)
        Me.PR_MaxLabel.Name = "PR_MaxLabel"
        Me.PR_MaxLabel.Size = New System.Drawing.Size(34, 25)
        Me.PR_MaxLabel.TabIndex = 99
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
        'TH_MaxLabel
        '
        Me.TH_MaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "TH_Max", True))
        Me.TH_MaxLabel.Location = New System.Drawing.Point(142, 140)
        Me.TH_MaxLabel.Name = "TH_MaxLabel"
        Me.TH_MaxLabel.Size = New System.Drawing.Size(34, 25)
        Me.TH_MaxLabel.TabIndex = 94
        '
        'ORTextBox
        '
        Me.ORTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "OR", True))
        Me.ORTextBox.Location = New System.Drawing.Point(75, 167)
        Me.ORTextBox.MaxLength = 3
        Me.ORTextBox.Name = "ORTextBox"
        Me.ORTextBox.Size = New System.Drawing.Size(36, 23)
        Me.ORTextBox.TabIndex = 8
        Me.ORTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TWTextBox
        '
        Me.TWTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "TW", True))
        Me.TWTextBox.Location = New System.Drawing.Point(231, 168)
        Me.TWTextBox.MaxLength = 3
        Me.TWTextBox.Name = "TWTextBox"
        Me.TWTextBox.Size = New System.Drawing.Size(40, 23)
        Me.TWTextBox.TabIndex = 9
        Me.TWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRTextBox
        '
        Me.PRTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "PR", True))
        Me.PRTextBox.Location = New System.Drawing.Point(231, 133)
        Me.PRTextBox.MaxLength = 3
        Me.PRTextBox.Name = "PRTextBox"
        Me.PRTextBox.Size = New System.Drawing.Size(40, 23)
        Me.PRTextBox.TabIndex = 7
        Me.PRTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'THTextBox
        '
        Me.THTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.THTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ResultBindingSource, "TH", True))
        Me.THTextBox.Location = New System.Drawing.Point(75, 134)
        Me.THTextBox.MaxLength = 3
        Me.THTextBox.Name = "THTextBox"
        Me.THTextBox.Size = New System.Drawing.Size(36, 23)
        Me.THTextBox.TabIndex = 6
        Me.THTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSubCode
        '
        Me.cmbSubCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_ResultBindingSource, "Subject_Code", True))
        Me.cmbSubCode.DataSource = Me.TBLSubjectBindingSource
        Me.cmbSubCode.DisplayMember = "Subject_Code"
        Me.cmbSubCode.DropDownHeight = 75
        Me.cmbSubCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubCode.FormattingEnabled = True
        Me.cmbSubCode.IntegralHeight = False
        Me.cmbSubCode.Location = New System.Drawing.Point(169, 47)
        Me.cmbSubCode.Name = "cmbSubCode"
        Me.cmbSubCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbSubCode.TabIndex = 5
        Me.cmbSubCode.ValueMember = "Subject_Code"
        '
        'Subject_NameTextBox
        '
        Me.Subject_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLSubjectBindingSource, "Subject_Name", True))
        Me.Subject_NameTextBox.Location = New System.Drawing.Point(268, 632)
        Me.Subject_NameTextBox.Name = "Subject_NameTextBox"
        Me.Subject_NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Subject_NameTextBox.TabIndex = 102
        '
        'grpOpe
        '
        Me.grpOpe.BackColor = System.Drawing.Color.Transparent
        Me.grpOpe.Controls.Add(Me.btnClose)
        Me.grpOpe.Controls.Add(Me.btnCan)
        Me.grpOpe.Controls.Add(Me.btnSave)
        Me.grpOpe.Controls.Add(Me.btnAdd)
        Me.grpOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpe.Location = New System.Drawing.Point(16, 505)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(396, 67)
        Me.grpOpe.TabIndex = 73
        Me.grpOpe.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(303, 24)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(207, 24)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 11
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(113, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(18, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(374, 413)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 16
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(82, 413)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 13
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(176, 413)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 31)
        Me.btnPre.TabIndex = 14
        Me.btnPre.Text = "<<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(275, 413)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.btnDelAll)
        Me.grpSearch.Controls.Add(Me.Label5)
        Me.grpSearch.Controls.Add(Me.Label6)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.TBL_ResultDataGridView)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnDel)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.btnShowAll)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.cmbSearch)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(788, 112)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(505, 460)
        Me.grpSearch.TabIndex = 77
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Result"
        '
        'btnDelAll
        '
        Me.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAll.Location = New System.Drawing.Point(189, 135)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(100, 25)
        Me.btnDelAll.TabIndex = 80
        Me.btnDelAll.Text = "Delete A&ll"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Search By :"
        '
        'TBL_ResultDataGridView
        '
        Me.TBL_ResultDataGridView.AllowUserToAddRows = False
        Me.TBL_ResultDataGridView.AllowUserToDeleteRows = False
        Me.TBL_ResultDataGridView.AutoGenerateColumns = False
        Me.TBL_ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_ResultDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.TBL_ResultDataGridView.DataSource = Me.TBL_ResultBindingSource
        Me.TBL_ResultDataGridView.Location = New System.Drawing.Point(30, 175)
        Me.TBL_ResultDataGridView.Name = "TBL_ResultDataGridView"
        Me.TBL_ResultDataGridView.ReadOnly = True
        Me.TBL_ResultDataGridView.Size = New System.Drawing.Size(450, 220)
        Me.TBL_ResultDataGridView.TabIndex = 77
        Me.TBL_ResultDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Exam_Season"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Exam Season"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Exam_Year"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Exam Year"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Branch_Code"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Branch Code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Enrollment_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Enrollment Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Subject_Code"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Subject Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Student_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Student Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Seat_Number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Seat Number"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Subject_Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Subject Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 85
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TH"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TH"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 30
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PR"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 30
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "OR"
        Me.DataGridViewTextBoxColumn12.HeaderText = "OR"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 30
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TW"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TW"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 30
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(361, 135)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 25)
        Me.btnDel.TabIndex = 22
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(361, 106)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 25)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Location = New System.Drawing.Point(55, 135)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 25)
        Me.btnShowAll.TabIndex = 20
        Me.btnShowAll.Text = "S&how All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(55, 106)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Sea&rch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(299, 65)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 23)
        Me.txtSearch.TabIndex = 18
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownHeight = 75
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.IntegralHeight = False
        Me.cmbSearch.Items.AddRange(New Object() {"Exam Season", "Exam Year", "Branch Code", "Enrollment Number", "Student Name", "Seat Number"})
        Me.cmbSearch.Location = New System.Drawing.Point(55, 64)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(121, 24)
        Me.cmbSearch.TabIndex = 17
        '
        'TBLBranchBindingSource1
        '
        Me.TBLBranchBindingSource1.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchTBLSubjectBindingSource
        '
        Me.TBLBranchTBLSubjectBindingSource.DataMember = "TBL_BranchTBL_Subject"
        Me.TBLBranchTBLSubjectBindingSource.DataSource = Me.TBLBranchBindingSource
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(322, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(635, 54)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Test_paper_icon
        Me.PictureBox2.Location = New System.Drawing.Point(79, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(1317, 594)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.Subject_NameTextBox)
        Me.Controls.Add(Me.Student_NameTextBox)
        Me.Controls.Add(Me.grpOpe)
        Me.Controls.Add(Me.grpMarks)
        Me.Controls.Add(Me.grpBranch)
        Me.Controls.Add(Me.grpExam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result Entry"
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExam.ResumeLayout(False)
        Me.grpExam.PerformLayout()
        Me.grpBranch.ResumeLayout(False)
        Me.grpBranch.PerformLayout()
        CType(Me.TBLClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLClassBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMarks.ResumeLayout(False)
        Me.grpMarks.PerformLayout()
        Me.grpOpe.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.TBL_ResultDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchTBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_ResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_ResultTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents cmbSeason As System.Windows.Forms.ComboBox
    Friend WithEvents Exam_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SubjectTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
    Friend WithEvents TBLSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_StudentTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
    Friend WithEvents TBLStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpExam As System.Windows.Forms.GroupBox
    Friend WithEvents grpBranch As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBrCode As System.Windows.Forms.ComboBox
    Friend WithEvents Seat_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpMarks As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSubCode As System.Windows.Forms.ComboBox
    Friend WithEvents ORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TWTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents THTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TH_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents PR_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TW_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents OR_MaxLabel As System.Windows.Forms.Label
    Friend WithEvents cmbEnroll As System.Windows.Forms.ComboBox
    Friend WithEvents TBL_ClassTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ClassTableAdapter
    Friend WithEvents TBLClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TBLClassBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchTBLSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBL_ResultDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
End Class
