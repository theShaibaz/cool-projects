<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Dim Enrollment_NumberLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Email_IDLabel As System.Windows.Forms.Label
        Dim BranchLabel As System.Windows.Forms.Label
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_StudentTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBL_DeptTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_DeptTableAdapter
        Me.TBL_SubjectTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
        Me.grpStudent = New System.Windows.Forms.GroupBox
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.Enrollment_NumberTextBox = New System.Windows.Forms.TextBox
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox
        Me.Email_IDTextBox = New System.Windows.Forms.TextBox
        Me.TBLDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.btnDelAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TBL_StudentDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchTBLSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Enrollment_NumberLabel = New System.Windows.Forms.Label
        Student_NameLabel = New System.Windows.Forms.Label
        Email_IDLabel = New System.Windows.Forms.Label
        BranchLabel = New System.Windows.Forms.Label
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudent.SuspendLayout()
        CType(Me.TBLDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpe.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.TBL_StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchTBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Enrollment_NumberLabel
        '
        Enrollment_NumberLabel.AutoSize = True
        Enrollment_NumberLabel.Location = New System.Drawing.Point(26, 44)
        Enrollment_NumberLabel.Name = "Enrollment_NumberLabel"
        Enrollment_NumberLabel.Size = New System.Drawing.Size(137, 17)
        Enrollment_NumberLabel.TabIndex = 7
        Enrollment_NumberLabel.Text = "Enrollment Number :"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(26, 135)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(106, 17)
        Student_NameLabel.TabIndex = 9
        Student_NameLabel.Text = "Student Name :"
        '
        'Email_IDLabel
        '
        Email_IDLabel.AutoSize = True
        Email_IDLabel.Location = New System.Drawing.Point(26, 181)
        Email_IDLabel.Name = "Email_IDLabel"
        Email_IDLabel.Size = New System.Drawing.Size(67, 17)
        Email_IDLabel.TabIndex = 11
        Email_IDLabel.Text = "Email ID :"
        '
        'BranchLabel
        '
        BranchLabel.AutoSize = True
        BranchLabel.Location = New System.Drawing.Point(26, 89)
        BranchLabel.Name = "BranchLabel"
        BranchLabel.Size = New System.Drawing.Size(61, 17)
        BranchLabel.TabIndex = 14
        BranchLabel.Text = "Branch :"
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_StudentBindingSource
        '
        Me.TBL_StudentBindingSource.DataMember = "TBL_Student"
        Me.TBL_StudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBL_StudentTableAdapter
        '
        Me.TBL_StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BranchTableAdapter = Me.TBL_BranchTableAdapter
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Me.TBL_DeptTableAdapter
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
        'TBL_DeptTableAdapter
        '
        Me.TBL_DeptTableAdapter.ClearBeforeFill = True
        '
        'TBL_SubjectTableAdapter
        '
        Me.TBL_SubjectTableAdapter.ClearBeforeFill = True
        '
        'grpStudent
        '
        Me.grpStudent.BackColor = System.Drawing.Color.Transparent
        Me.grpStudent.Controls.Add(BranchLabel)
        Me.grpStudent.Controls.Add(Me.BranchComboBox)
        Me.grpStudent.Controls.Add(Enrollment_NumberLabel)
        Me.grpStudent.Controls.Add(Me.Enrollment_NumberTextBox)
        Me.grpStudent.Controls.Add(Student_NameLabel)
        Me.grpStudent.Controls.Add(Me.Student_NameTextBox)
        Me.grpStudent.Controls.Add(Email_IDLabel)
        Me.grpStudent.Controls.Add(Me.Email_IDTextBox)
        Me.grpStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStudent.Location = New System.Drawing.Point(35, 184)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(417, 240)
        Me.grpStudent.TabIndex = 9
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Student Details"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_StudentBindingSource, "Branch", True))
        Me.BranchComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_StudentBindingSource, "Branch", True))
        Me.BranchComboBox.DataSource = Me.TBLDeptBindingSource
        Me.BranchComboBox.DisplayMember = "Short_Code"
        Me.BranchComboBox.DropDownHeight = 75
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.IntegralHeight = False
        Me.BranchComboBox.Location = New System.Drawing.Point(181, 86)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(69, 24)
        Me.BranchComboBox.TabIndex = 2
        Me.BranchComboBox.ValueMember = "Short_Code"
        '
        'Enrollment_NumberTextBox
        '
        Me.Enrollment_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_StudentBindingSource, "Enrollment_Number", True))
        Me.Enrollment_NumberTextBox.Location = New System.Drawing.Point(181, 41)
        Me.Enrollment_NumberTextBox.Name = "Enrollment_NumberTextBox"
        Me.Enrollment_NumberTextBox.Size = New System.Drawing.Size(170, 23)
        Me.Enrollment_NumberTextBox.TabIndex = 1
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_StudentBindingSource, "Student_Name", True))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(181, 132)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.Size = New System.Drawing.Size(221, 23)
        Me.Student_NameTextBox.TabIndex = 3
        '
        'Email_IDTextBox
        '
        Me.Email_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_StudentBindingSource, "Email_ID", True))
        Me.Email_IDTextBox.Location = New System.Drawing.Point(181, 178)
        Me.Email_IDTextBox.Name = "Email_IDTextBox"
        Me.Email_IDTextBox.Size = New System.Drawing.Size(221, 23)
        Me.Email_IDTextBox.TabIndex = 4
        '
        'TBLDeptBindingSource
        '
        Me.TBLDeptBindingSource.DataMember = "TBL_Dept"
        Me.TBLDeptBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLStudentBindingSource
        '
        Me.TBLStudentBindingSource.DataMember = "TBL_Student"
        Me.TBLStudentBindingSource.DataSource = Me.REM_DBDataSet
        '
        'btnLast
        '
        Me.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(350, 387)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 11
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(56, 387)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 8
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(152, 387)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 31)
        Me.btnPre.TabIndex = 9
        Me.btnPre.Text = "<<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(250, 387)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpOpe
        '
        Me.grpOpe.BackColor = System.Drawing.Color.Transparent
        Me.grpOpe.Controls.Add(Me.btnSave)
        Me.grpOpe.Controls.Add(Me.btnCan)
        Me.grpOpe.Controls.Add(Me.btnAdd)
        Me.grpOpe.Controls.Add(Me.btnClose)
        Me.grpOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpe.Location = New System.Drawing.Point(35, 432)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(417, 75)
        Me.grpOpe.TabIndex = 15
        Me.grpOpe.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(118, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(214, 24)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 6
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(22, 24)
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
        Me.btnClose.Location = New System.Drawing.Point(310, 24)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.btnDelAll)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Controls.Add(Me.TBL_StudentDataGridView)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.btnDel)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.btnShowAll)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.cmbSearch)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(491, 133)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(488, 434)
        Me.grpSearch.TabIndex = 17
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Student"
        '
        'btnDelAll
        '
        Me.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAll.Location = New System.Drawing.Point(187, 142)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(100, 25)
        Me.btnDelAll.TabIndex = 44
        Me.btnDelAll.Text = "Delete A&ll"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Enter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Search By :"
        '
        'TBL_StudentDataGridView
        '
        Me.TBL_StudentDataGridView.AllowUserToAddRows = False
        Me.TBL_StudentDataGridView.AllowUserToDeleteRows = False
        Me.TBL_StudentDataGridView.AutoGenerateColumns = False
        Me.TBL_StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TBL_StudentDataGridView.DataSource = Me.TBL_StudentBindingSource
        Me.TBL_StudentDataGridView.Location = New System.Drawing.Point(34, 183)
        Me.TBL_StudentDataGridView.Name = "TBL_StudentDataGridView"
        Me.TBL_StudentDataGridView.ReadOnly = True
        Me.TBL_StudentDataGridView.Size = New System.Drawing.Size(419, 190)
        Me.TBL_StudentDataGridView.TabIndex = 25
        Me.TBL_StudentDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Enrollment_Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Enrollment Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Branch"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Branch"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Student_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Student Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(350, 142)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 25)
        Me.btnDel.TabIndex = 17
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(350, 109)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 25)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Location = New System.Drawing.Point(56, 142)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 25)
        Me.btnShowAll.TabIndex = 15
        Me.btnShowAll.Text = "S&how All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(56, 109)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Sea&rch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(288, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 23)
        Me.txtSearch.TabIndex = 13
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownHeight = 75
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.IntegralHeight = False
        Me.cmbSearch.Items.AddRange(New Object() {"Enrollment Number", "Student Name", "Branch "})
        Me.cmbSearch.Location = New System.Drawing.Point(56, 60)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(135, 24)
        Me.cmbSearch.TabIndex = 12
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchTBLSubjectBindingSource
        '
        Me.TBLBranchTBLSubjectBindingSource.DataMember = "TBL_BranchTBL_Subject"
        Me.TBLBranchTBLSubjectBindingSource.DataSource = Me.TBLBranchBindingSource
        '
        'TBLBranchBindingSource1
        '
        Me.TBLBranchBindingSource1.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(635, 54)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.graduated_icon
        Me.PictureBox2.Location = New System.Drawing.Point(58, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(1011, 579)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpStudent)
        Me.Controls.Add(Me.grpOpe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        CType(Me.TBLDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpe.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.TBL_StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchTBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_StudentTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_StudentTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grpStudent As System.Windows.Forms.GroupBox
    Friend WithEvents Enrollment_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TBL_StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SubjectTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
    Friend WithEvents TBLBranchTBLSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_DeptTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_DeptTableAdapter
    Friend WithEvents TBLDeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
End Class
