<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClass
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
        Dim ClassLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Enrollment_NumberLabel As System.Windows.Forms.Label
        Dim Roll_NoLabel As System.Windows.Forms.Label
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_ClassTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ClassTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBL_ResultTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
        Me.TBL_StudentTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
        Me.TBL_SubjectTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.btnDelAll = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.TBL_ClassDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.TBLClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpStudent = New System.Windows.Forms.GroupBox
        Me.Roll_NoTextBox = New System.Windows.Forms.TextBox
        Me.Enrollment_NumberComboBox = New System.Windows.Forms.ComboBox
        Me.TBL_StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_NameComboBox = New System.Windows.Forms.ComboBox
        Me.ClassComboBox = New System.Windows.Forms.ComboBox
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLStudentBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLStudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.TBLStudentTBLResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchTBLSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        ClassLabel = New System.Windows.Forms.Label
        Student_NameLabel = New System.Windows.Forms.Label
        Enrollment_NumberLabel = New System.Windows.Forms.Label
        Roll_NoLabel = New System.Windows.Forms.Label
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.TBL_ClassDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudent.SuspendLayout()
        CType(Me.TBL_StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLStudentBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLStudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpe.SuspendLayout()
        CType(Me.TBLStudentTBLResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchTBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(37, 49)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(46, 17)
        ClassLabel.TabIndex = 1
        ClassLabel.Text = "Class:"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(37, 91)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(102, 17)
        Student_NameLabel.TabIndex = 3
        Student_NameLabel.Text = "Student Name:"
        '
        'Enrollment_NumberLabel
        '
        Enrollment_NumberLabel.AutoSize = True
        Enrollment_NumberLabel.Location = New System.Drawing.Point(37, 135)
        Enrollment_NumberLabel.Name = "Enrollment_NumberLabel"
        Enrollment_NumberLabel.Size = New System.Drawing.Size(133, 17)
        Enrollment_NumberLabel.TabIndex = 5
        Enrollment_NumberLabel.Text = "Enrollment Number:"
        '
        'Roll_NoLabel
        '
        Roll_NoLabel.AutoSize = True
        Roll_NoLabel.Location = New System.Drawing.Point(37, 180)
        Roll_NoLabel.Name = "Roll_NoLabel"
        Roll_NoLabel.Size = New System.Drawing.Size(58, 17)
        Roll_NoLabel.TabIndex = 7
        Roll_NoLabel.Text = "Roll No:"
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_ClassBindingSource
        '
        Me.TBL_ClassBindingSource.DataMember = "TBL_Class"
        Me.TBL_ClassBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBL_ClassTableAdapter
        '
        Me.TBL_ClassTableAdapter.ClearBeforeFill = True
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
        'TBL_ResultTableAdapter
        '
        Me.TBL_ResultTableAdapter.ClearBeforeFill = True
        '
        'TBL_StudentTableAdapter
        '
        Me.TBL_StudentTableAdapter.ClearBeforeFill = True
        '
        'TBL_SubjectTableAdapter
        '
        Me.TBL_SubjectTableAdapter.ClearBeforeFill = True
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.btnDelAll)
        Me.grpSearch.Controls.Add(Me.btnDel)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.TBL_ClassDataGridView)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(455, 205)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(490, 364)
        Me.grpSearch.TabIndex = 18
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Student"
        '
        'btnDelAll
        '
        Me.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAll.Location = New System.Drawing.Point(318, 43)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(100, 25)
        Me.btnDelAll.TabIndex = 28
        Me.btnDelAll.Text = "Delete A&ll"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(189, 43)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 25)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(60, 43)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 25)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(364, 301)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 10
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(74, 301)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 7
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'TBL_ClassDataGridView
        '
        Me.TBL_ClassDataGridView.AllowUserToAddRows = False
        Me.TBL_ClassDataGridView.AllowUserToDeleteRows = False
        Me.TBL_ClassDataGridView.AutoGenerateColumns = False
        Me.TBL_ClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_ClassDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TBL_ClassDataGridView.DataSource = Me.TBL_ClassBindingSource
        Me.TBL_ClassDataGridView.Location = New System.Drawing.Point(34, 84)
        Me.TBL_ClassDataGridView.Name = "TBL_ClassDataGridView"
        Me.TBL_ClassDataGridView.ReadOnly = True
        Me.TBL_ClassDataGridView.Size = New System.Drawing.Size(420, 198)
        Me.TBL_ClassDataGridView.TabIndex = 25
        Me.TBL_ClassDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Student_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Student Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Enrollment_Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Enrollment Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Roll_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Roll No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(170, 301)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 31)
        Me.btnPre.TabIndex = 8
        Me.btnPre.Text = "<<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(267, 301)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'TBLClassBindingSource
        '
        Me.TBLClassBindingSource.DataMember = "TBL_Class"
        Me.TBLClassBindingSource.DataSource = Me.REM_DBDataSet
        '
        'grpStudent
        '
        Me.grpStudent.BackColor = System.Drawing.Color.Transparent
        Me.grpStudent.Controls.Add(Me.Roll_NoTextBox)
        Me.grpStudent.Controls.Add(Me.Enrollment_NumberComboBox)
        Me.grpStudent.Controls.Add(Me.Student_NameComboBox)
        Me.grpStudent.Controls.Add(Me.ClassComboBox)
        Me.grpStudent.Controls.Add(Roll_NoLabel)
        Me.grpStudent.Controls.Add(ClassLabel)
        Me.grpStudent.Controls.Add(Enrollment_NumberLabel)
        Me.grpStudent.Controls.Add(Student_NameLabel)
        Me.grpStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudent.Location = New System.Drawing.Point(31, 240)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(393, 227)
        Me.grpStudent.TabIndex = 19
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Student Details"
        '
        'Roll_NoTextBox
        '
        Me.Roll_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ClassBindingSource, "Roll_No", True))
        Me.Roll_NoTextBox.Location = New System.Drawing.Point(197, 177)
        Me.Roll_NoTextBox.Name = "Roll_NoTextBox"
        Me.Roll_NoTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Roll_NoTextBox.TabIndex = 3
        '
        'Enrollment_NumberComboBox
        '
        Me.Enrollment_NumberComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ClassBindingSource, "Enrollment_Number", True))
        Me.Enrollment_NumberComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_ClassBindingSource, "Enrollment_Number", True))
        Me.Enrollment_NumberComboBox.DataSource = Me.TBL_StudentBindingSource
        Me.Enrollment_NumberComboBox.DisplayMember = "Enrollment_Number"
        Me.Enrollment_NumberComboBox.DropDownHeight = 75
        Me.Enrollment_NumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Enrollment_NumberComboBox.FormattingEnabled = True
        Me.Enrollment_NumberComboBox.IntegralHeight = False
        Me.Enrollment_NumberComboBox.Location = New System.Drawing.Point(197, 132)
        Me.Enrollment_NumberComboBox.Name = "Enrollment_NumberComboBox"
        Me.Enrollment_NumberComboBox.Size = New System.Drawing.Size(172, 24)
        Me.Enrollment_NumberComboBox.TabIndex = 2
        Me.Enrollment_NumberComboBox.ValueMember = "Enrollment_Number"
        '
        'TBL_StudentBindingSource
        '
        Me.TBL_StudentBindingSource.DataMember = "TBL_Student"
        Me.TBL_StudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'Student_NameComboBox
        '
        Me.Student_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_ClassBindingSource, "Student_Name", True))
        Me.Student_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_ClassBindingSource, "Student_Name", True))
        Me.Student_NameComboBox.DataSource = Me.TBL_StudentBindingSource
        Me.Student_NameComboBox.DisplayMember = "Student_Name"
        Me.Student_NameComboBox.DropDownHeight = 75
        Me.Student_NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Student_NameComboBox.FormattingEnabled = True
        Me.Student_NameComboBox.IntegralHeight = False
        Me.Student_NameComboBox.Location = New System.Drawing.Point(197, 88)
        Me.Student_NameComboBox.Name = "Student_NameComboBox"
        Me.Student_NameComboBox.Size = New System.Drawing.Size(172, 24)
        Me.Student_NameComboBox.TabIndex = 1
        Me.Student_NameComboBox.ValueMember = "Student_Name"
        '
        'ClassComboBox
        '
        Me.ClassComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_ClassBindingSource, "Class", True))
        Me.ClassComboBox.DataSource = Me.TBLBranchBindingSource
        Me.ClassComboBox.DisplayMember = "Branch_Code"
        Me.ClassComboBox.DropDownHeight = 75
        Me.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.IntegralHeight = False
        Me.ClassComboBox.Location = New System.Drawing.Point(197, 46)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(104, 24)
        Me.ClassComboBox.TabIndex = 1
        Me.ClassComboBox.TabStop = False
        Me.ClassComboBox.ValueMember = "Branch_Code"
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource5
        '
        Me.TBLBranchBindingSource5.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource5.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource4
        '
        Me.TBLBranchBindingSource4.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource4.DataSource = Me.REM_DBDataSet
        '
        'TBLStudentBindingSource
        '
        Me.TBLStudentBindingSource.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource2
        '
        Me.TBLBranchBindingSource2.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource2.DataSource = Me.REM_DBDataSet
        '
        'TBLStudentBindingSource2
        '
        Me.TBLStudentBindingSource2.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource2.DataSource = Me.REM_DBDataSet
        '
        'TBLStudentBindingSource1
        '
        Me.TBLStudentBindingSource1.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource1
        '
        Me.TBLBranchBindingSource1.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'grpOpe
        '
        Me.grpOpe.BackColor = System.Drawing.Color.Transparent
        Me.grpOpe.Controls.Add(Me.btnSave)
        Me.grpOpe.Controls.Add(Me.btnCan)
        Me.grpOpe.Controls.Add(Me.btnAdd)
        Me.grpOpe.Controls.Add(Me.btnClose)
        Me.grpOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpe.Location = New System.Drawing.Point(31, 473)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(393, 70)
        Me.grpOpe.TabIndex = 20
        Me.grpOpe.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(110, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(206, 24)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 5
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(17, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(302, 24)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TBLStudentTBLResultBindingSource
        '
        Me.TBLStudentTBLResultBindingSource.DataMember = "TBL_StudentTBL_Result"
        Me.TBLStudentTBLResultBindingSource.DataSource = Me.TBLStudentBindingSource
        '
        'TBLBranchBindingSource3
        '
        Me.TBLBranchBindingSource3.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource3.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource6
        '
        Me.TBLBranchBindingSource6.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource6.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchTBLSubjectBindingSource
        '
        Me.TBLBranchTBLSubjectBindingSource.DataMember = "TBL_BranchTBL_Subject"
        Me.TBLBranchTBLSubjectBindingSource.DataSource = Me.TBLBranchBindingSource
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(635, 54)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.student_icon_1106111526
        Me.PictureBox2.Location = New System.Drawing.Point(68, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'frmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(993, 610)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpOpe)
        Me.Controls.Add(Me.grpStudent)
        Me.Controls.Add(Me.grpSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClass"
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        CType(Me.TBL_ClassDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        CType(Me.TBL_StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLStudentBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLStudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpe.ResumeLayout(False)
        CType(Me.TBLStudentTBLResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchTBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_ClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_ClassTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ClassTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents grpStudent As System.Windows.Forms.GroupBox
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents TBLBranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClassComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TBLBranchBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_StudentTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
    Friend WithEvents TBL_StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_ResultTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
    Friend WithEvents TBLStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLStudentTBLResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLStudentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLStudentBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SubjectTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
    Friend WithEvents TBLBranchTBLSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_ClassDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Roll_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Enrollment_NumberComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Student_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
