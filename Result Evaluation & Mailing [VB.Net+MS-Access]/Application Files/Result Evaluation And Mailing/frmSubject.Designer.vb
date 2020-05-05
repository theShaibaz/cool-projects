<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubject
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
        Dim TH_MaxLabel As System.Windows.Forms.Label
        Dim PR_MaxLabel As System.Windows.Forms.Label
        Dim OR_MaxLabel As System.Windows.Forms.Label
        Dim TW_MaxLabel As System.Windows.Forms.Label
        Dim TH_MinLabel As System.Windows.Forms.Label
        Dim PR_MinLabel As System.Windows.Forms.Label
        Dim OR_MinLabel As System.Windows.Forms.Label
        Dim TW_MinLabel As System.Windows.Forms.Label
        Dim Subject_CodeLabel As System.Windows.Forms.Label
        Dim Branch_CodeLabel As System.Windows.Forms.Label
        Dim Subject_NameLabel As System.Windows.Forms.Label
        Me.grpMax = New System.Windows.Forms.GroupBox
        Me.TH_MaxTextBox = New System.Windows.Forms.TextBox
        Me.TBL_SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.PR_MaxTextBox = New System.Windows.Forms.TextBox
        Me.OR_MaxTextBox = New System.Windows.Forms.TextBox
        Me.TW_MaxTextBox = New System.Windows.Forms.TextBox
        Me.grpMin = New System.Windows.Forms.GroupBox
        Me.TH_MinTextBox = New System.Windows.Forms.TextBox
        Me.PR_MinTextBox = New System.Windows.Forms.TextBox
        Me.OR_MinTextBox = New System.Windows.Forms.TextBox
        Me.TW_MinTextBox = New System.Windows.Forms.TextBox
        Me.grpSub = New System.Windows.Forms.GroupBox
        Me.cmbBrCode = New System.Windows.Forms.ComboBox
        Me.Subject_CodeTextBox = New System.Windows.Forms.TextBox
        Me.Subject_NameTextBox = New System.Windows.Forms.TextBox
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.TBL_SubjectDataGridView = New System.Windows.Forms.DataGridView
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
        Me.btnPre = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnShowAll = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TBL_SubjectTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBL_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLSubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        TH_MaxLabel = New System.Windows.Forms.Label
        PR_MaxLabel = New System.Windows.Forms.Label
        OR_MaxLabel = New System.Windows.Forms.Label
        TW_MaxLabel = New System.Windows.Forms.Label
        TH_MinLabel = New System.Windows.Forms.Label
        PR_MinLabel = New System.Windows.Forms.Label
        OR_MinLabel = New System.Windows.Forms.Label
        TW_MinLabel = New System.Windows.Forms.Label
        Subject_CodeLabel = New System.Windows.Forms.Label
        Branch_CodeLabel = New System.Windows.Forms.Label
        Subject_NameLabel = New System.Windows.Forms.Label
        Me.grpMax.SuspendLayout()
        CType(Me.TBL_SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMin.SuspendLayout()
        Me.grpSub.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.TBL_SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TH_MaxLabel
        '
        TH_MaxLabel.AutoSize = True
        TH_MaxLabel.Location = New System.Drawing.Point(18, 39)
        TH_MaxLabel.Name = "TH_MaxLabel"
        TH_MaxLabel.Size = New System.Drawing.Size(64, 17)
        TH_MaxLabel.TabIndex = 29
        TH_MaxLabel.Text = "TH Max :"
        '
        'PR_MaxLabel
        '
        PR_MaxLabel.AutoSize = True
        PR_MaxLabel.Location = New System.Drawing.Point(21, 74)
        PR_MaxLabel.Name = "PR_MaxLabel"
        PR_MaxLabel.Size = New System.Drawing.Size(64, 17)
        PR_MaxLabel.TabIndex = 33
        PR_MaxLabel.Text = "PR Max :"
        '
        'OR_MaxLabel
        '
        OR_MaxLabel.AutoSize = True
        OR_MaxLabel.Location = New System.Drawing.Point(18, 111)
        OR_MaxLabel.Name = "OR_MaxLabel"
        OR_MaxLabel.Size = New System.Drawing.Size(66, 17)
        OR_MaxLabel.TabIndex = 37
        OR_MaxLabel.Text = "OR Max :"
        '
        'TW_MaxLabel
        '
        TW_MaxLabel.AutoSize = True
        TW_MaxLabel.Location = New System.Drawing.Point(18, 147)
        TW_MaxLabel.Name = "TW_MaxLabel"
        TW_MaxLabel.Size = New System.Drawing.Size(67, 17)
        TW_MaxLabel.TabIndex = 41
        TW_MaxLabel.Text = "TW Max :"
        '
        'TH_MinLabel
        '
        TH_MinLabel.AutoSize = True
        TH_MinLabel.Location = New System.Drawing.Point(19, 39)
        TH_MinLabel.Name = "TH_MinLabel"
        TH_MinLabel.Size = New System.Drawing.Size(61, 17)
        TH_MinLabel.TabIndex = 49
        TH_MinLabel.Text = "TH Min :"
        '
        'PR_MinLabel
        '
        PR_MinLabel.AutoSize = True
        PR_MinLabel.Location = New System.Drawing.Point(19, 74)
        PR_MinLabel.Name = "PR_MinLabel"
        PR_MinLabel.Size = New System.Drawing.Size(61, 17)
        PR_MinLabel.TabIndex = 51
        PR_MinLabel.Text = "PR Min :"
        '
        'OR_MinLabel
        '
        OR_MinLabel.AutoSize = True
        OR_MinLabel.Location = New System.Drawing.Point(19, 108)
        OR_MinLabel.Name = "OR_MinLabel"
        OR_MinLabel.Size = New System.Drawing.Size(63, 17)
        OR_MinLabel.TabIndex = 53
        OR_MinLabel.Text = "OR Min :"
        '
        'TW_MinLabel
        '
        TW_MinLabel.AutoSize = True
        TW_MinLabel.Location = New System.Drawing.Point(19, 147)
        TW_MinLabel.Name = "TW_MinLabel"
        TW_MinLabel.Size = New System.Drawing.Size(64, 17)
        TW_MinLabel.TabIndex = 55
        TW_MinLabel.Text = "TW Min :"
        '
        'Subject_CodeLabel
        '
        Subject_CodeLabel.AutoSize = True
        Subject_CodeLabel.Location = New System.Drawing.Point(32, 42)
        Subject_CodeLabel.Name = "Subject_CodeLabel"
        Subject_CodeLabel.Size = New System.Drawing.Size(100, 17)
        Subject_CodeLabel.TabIndex = 32
        Subject_CodeLabel.Text = "Subject Code :"
        '
        'Branch_CodeLabel
        '
        Branch_CodeLabel.AutoSize = True
        Branch_CodeLabel.Location = New System.Drawing.Point(32, 89)
        Branch_CodeLabel.Name = "Branch_CodeLabel"
        Branch_CodeLabel.Size = New System.Drawing.Size(98, 17)
        Branch_CodeLabel.TabIndex = 34
        Branch_CodeLabel.Text = "Branch Code :"
        '
        'Subject_NameLabel
        '
        Subject_NameLabel.AutoSize = True
        Subject_NameLabel.Location = New System.Drawing.Point(32, 137)
        Subject_NameLabel.Name = "Subject_NameLabel"
        Subject_NameLabel.Size = New System.Drawing.Size(104, 17)
        Subject_NameLabel.TabIndex = 35
        Subject_NameLabel.Text = "Subject Name :"
        '
        'grpMax
        '
        Me.grpMax.BackColor = System.Drawing.Color.Transparent
        Me.grpMax.Controls.Add(TH_MaxLabel)
        Me.grpMax.Controls.Add(Me.TH_MaxTextBox)
        Me.grpMax.Controls.Add(PR_MaxLabel)
        Me.grpMax.Controls.Add(Me.PR_MaxTextBox)
        Me.grpMax.Controls.Add(OR_MaxLabel)
        Me.grpMax.Controls.Add(Me.OR_MaxTextBox)
        Me.grpMax.Controls.Add(TW_MaxLabel)
        Me.grpMax.Controls.Add(Me.TW_MaxTextBox)
        Me.grpMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMax.Location = New System.Drawing.Point(21, 336)
        Me.grpMax.Name = "grpMax"
        Me.grpMax.Size = New System.Drawing.Size(148, 195)
        Me.grpMax.TabIndex = 1
        Me.grpMax.TabStop = False
        Me.grpMax.Text = "Maximum"
        '
        'TH_MaxTextBox
        '
        Me.TH_MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "TH_Max", True))
        Me.TH_MaxTextBox.Location = New System.Drawing.Point(84, 36)
        Me.TH_MaxTextBox.MaxLength = 3
        Me.TH_MaxTextBox.Name = "TH_MaxTextBox"
        Me.TH_MaxTextBox.Size = New System.Drawing.Size(43, 23)
        Me.TH_MaxTextBox.TabIndex = 4
        '
        'TBL_SubjectBindingSource
        '
        Me.TBL_SubjectBindingSource.DataMember = "TBL_Subject"
        Me.TBL_SubjectBindingSource.DataSource = Me.REM_DBDataSet
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PR_MaxTextBox
        '
        Me.PR_MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "PR_Max", True))
        Me.PR_MaxTextBox.Location = New System.Drawing.Point(84, 71)
        Me.PR_MaxTextBox.MaxLength = 3
        Me.PR_MaxTextBox.Name = "PR_MaxTextBox"
        Me.PR_MaxTextBox.Size = New System.Drawing.Size(43, 23)
        Me.PR_MaxTextBox.TabIndex = 5
        '
        'OR_MaxTextBox
        '
        Me.OR_MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "OR_Max", True))
        Me.OR_MaxTextBox.Location = New System.Drawing.Point(84, 108)
        Me.OR_MaxTextBox.MaxLength = 3
        Me.OR_MaxTextBox.Name = "OR_MaxTextBox"
        Me.OR_MaxTextBox.Size = New System.Drawing.Size(43, 23)
        Me.OR_MaxTextBox.TabIndex = 6
        '
        'TW_MaxTextBox
        '
        Me.TW_MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "TW_Max", True))
        Me.TW_MaxTextBox.Location = New System.Drawing.Point(84, 144)
        Me.TW_MaxTextBox.MaxLength = 3
        Me.TW_MaxTextBox.Name = "TW_MaxTextBox"
        Me.TW_MaxTextBox.Size = New System.Drawing.Size(43, 23)
        Me.TW_MaxTextBox.TabIndex = 7
        '
        'grpMin
        '
        Me.grpMin.BackColor = System.Drawing.Color.Transparent
        Me.grpMin.Controls.Add(TH_MinLabel)
        Me.grpMin.Controls.Add(Me.TH_MinTextBox)
        Me.grpMin.Controls.Add(PR_MinLabel)
        Me.grpMin.Controls.Add(Me.PR_MinTextBox)
        Me.grpMin.Controls.Add(OR_MinLabel)
        Me.grpMin.Controls.Add(Me.OR_MinTextBox)
        Me.grpMin.Controls.Add(TW_MinLabel)
        Me.grpMin.Controls.Add(Me.TW_MinTextBox)
        Me.grpMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMin.Location = New System.Drawing.Point(282, 337)
        Me.grpMin.Name = "grpMin"
        Me.grpMin.Size = New System.Drawing.Size(152, 194)
        Me.grpMin.TabIndex = 2
        Me.grpMin.TabStop = False
        Me.grpMin.Text = "Minimum"
        '
        'TH_MinTextBox
        '
        Me.TH_MinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "TH_Min", True))
        Me.TH_MinTextBox.Location = New System.Drawing.Point(84, 33)
        Me.TH_MinTextBox.MaxLength = 2
        Me.TH_MinTextBox.Name = "TH_MinTextBox"
        Me.TH_MinTextBox.Size = New System.Drawing.Size(43, 23)
        Me.TH_MinTextBox.TabIndex = 8
        '
        'PR_MinTextBox
        '
        Me.PR_MinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "PR_Min", True))
        Me.PR_MinTextBox.Location = New System.Drawing.Point(84, 68)
        Me.PR_MinTextBox.MaxLength = 2
        Me.PR_MinTextBox.Name = "PR_MinTextBox"
        Me.PR_MinTextBox.Size = New System.Drawing.Size(43, 23)
        Me.PR_MinTextBox.TabIndex = 9
        '
        'OR_MinTextBox
        '
        Me.OR_MinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "OR_Min", True))
        Me.OR_MinTextBox.Location = New System.Drawing.Point(84, 102)
        Me.OR_MinTextBox.MaxLength = 2
        Me.OR_MinTextBox.Name = "OR_MinTextBox"
        Me.OR_MinTextBox.Size = New System.Drawing.Size(43, 23)
        Me.OR_MinTextBox.TabIndex = 10
        '
        'TW_MinTextBox
        '
        Me.TW_MinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "TW_Min", True))
        Me.TW_MinTextBox.Location = New System.Drawing.Point(84, 141)
        Me.TW_MinTextBox.MaxLength = 2
        Me.TW_MinTextBox.Name = "TW_MinTextBox"
        Me.TW_MinTextBox.Size = New System.Drawing.Size(43, 23)
        Me.TW_MinTextBox.TabIndex = 11
        '
        'grpSub
        '
        Me.grpSub.BackColor = System.Drawing.Color.Transparent
        Me.grpSub.Controls.Add(Me.cmbBrCode)
        Me.grpSub.Controls.Add(Subject_CodeLabel)
        Me.grpSub.Controls.Add(Me.Subject_CodeTextBox)
        Me.grpSub.Controls.Add(Branch_CodeLabel)
        Me.grpSub.Controls.Add(Subject_NameLabel)
        Me.grpSub.Controls.Add(Me.Subject_NameTextBox)
        Me.grpSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSub.Location = New System.Drawing.Point(21, 140)
        Me.grpSub.Name = "grpSub"
        Me.grpSub.Size = New System.Drawing.Size(413, 185)
        Me.grpSub.TabIndex = 0
        Me.grpSub.TabStop = False
        Me.grpSub.Text = "Subject Details"
        '
        'cmbBrCode
        '
        Me.cmbBrCode.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_SubjectBindingSource, "Branch_Code", True))
        Me.cmbBrCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "Branch_Code", True))
        Me.cmbBrCode.DataSource = Me.TBLBranchBindingSource1
        Me.cmbBrCode.DisplayMember = "Branch_Code"
        Me.cmbBrCode.DropDownHeight = 75
        Me.cmbBrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrCode.FormattingEnabled = True
        Me.cmbBrCode.IntegralHeight = False
        Me.cmbBrCode.Location = New System.Drawing.Point(172, 86)
        Me.cmbBrCode.Name = "cmbBrCode"
        Me.cmbBrCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbBrCode.TabIndex = 2
        Me.cmbBrCode.ValueMember = "Branch_Code"
        '
        'Subject_CodeTextBox
        '
        Me.Subject_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "Subject_Code", True))
        Me.Subject_CodeTextBox.Location = New System.Drawing.Point(172, 39)
        Me.Subject_CodeTextBox.Name = "Subject_CodeTextBox"
        Me.Subject_CodeTextBox.Size = New System.Drawing.Size(121, 23)
        Me.Subject_CodeTextBox.TabIndex = 1
        '
        'Subject_NameTextBox
        '
        Me.Subject_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_SubjectBindingSource, "Subject_Name", True))
        Me.Subject_NameTextBox.Location = New System.Drawing.Point(172, 134)
        Me.Subject_NameTextBox.Name = "Subject_NameTextBox"
        Me.Subject_NameTextBox.Size = New System.Drawing.Size(218, 23)
        Me.Subject_NameTextBox.TabIndex = 3
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.TBL_SubjectDataGridView)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Controls.Add(Me.cmbSearch)
        Me.grpSearch.Controls.Add(Me.btnDel)
        Me.grpSearch.Controls.Add(Me.btnShowAll)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(454, 140)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(494, 474)
        Me.grpSearch.TabIndex = 33
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Enter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Search By :"
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(355, 422)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 18
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(64, 422)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 15
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'TBL_SubjectDataGridView
        '
        Me.TBL_SubjectDataGridView.AllowUserToAddRows = False
        Me.TBL_SubjectDataGridView.AllowUserToDeleteRows = False
        Me.TBL_SubjectDataGridView.AutoGenerateColumns = False
        Me.TBL_SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_SubjectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TBL_SubjectDataGridView.DataSource = Me.TBL_SubjectBindingSource
        Me.TBL_SubjectDataGridView.Location = New System.Drawing.Point(39, 183)
        Me.TBL_SubjectDataGridView.Name = "TBL_SubjectDataGridView"
        Me.TBL_SubjectDataGridView.ReadOnly = True
        Me.TBL_SubjectDataGridView.Size = New System.Drawing.Size(420, 220)
        Me.TBL_SubjectDataGridView.TabIndex = 39
        Me.TBL_SubjectDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Subject_Code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subject Code"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Subject_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subject Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TH_Max"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TH Max"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TH_Min"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TH Min"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PR_Max"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PR Max"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PR_Min"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PR Min"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OR_Max"
        Me.DataGridViewTextBoxColumn9.HeaderText = "OR Max"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OR_Min"
        Me.DataGridViewTextBoxColumn10.HeaderText = "OR Min"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TW_Max"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TW Max"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TW_Min"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TW Min"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(157, 422)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 31)
        Me.btnPre.TabIndex = 16
        Me.btnPre.Text = "<<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(260, 60)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 23)
        Me.txtSearch.TabIndex = 20
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(253, 422)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownHeight = 75
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmbSearch.IntegralHeight = False
        Me.cmbSearch.Items.AddRange(New Object() {"Subject ID", "Subject Code", "Subject Name", "Branch Code"})
        Me.cmbSearch.Location = New System.Drawing.Point(61, 59)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(142, 24)
        Me.cmbSearch.TabIndex = 19
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(353, 137)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 25)
        Me.btnDel.TabIndex = 24
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Location = New System.Drawing.Point(61, 137)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(75, 25)
        Me.btnShowAll.TabIndex = 22
        Me.btnShowAll.Text = "S&how All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(353, 104)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 25)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(61, 104)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Sea&rch"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnCan)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 542)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 72)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(214, 25)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 13
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(122, 25)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(26, 25)
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
        Me.btnClose.Location = New System.Drawing.Point(309, 25)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(635, 54)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.library_icon
        Me.PictureBox2.Location = New System.Drawing.Point(45, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'TBL_SubjectTableAdapter
        '
        Me.TBL_SubjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BranchTableAdapter = Me.TBL_BranchTableAdapter
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LoginTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ResultTableAdapter = Nothing
        Me.TableAdapterManager.TBL_StudentTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Me.TBL_SubjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BranchTableAdapter
        '
        Me.TBL_BranchTableAdapter.ClearBeforeFill = True
        '
        'TBL_BranchBindingSource
        '
        Me.TBL_BranchBindingSource.DataMember = "TBL_Branch"
        Me.TBL_BranchBindingSource.DataSource = Me.REM_DBDataSet
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
        'TBLBranchBindingSource1
        '
        Me.TBLBranchBindingSource1.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'frmSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(990, 669)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpSub)
        Me.Controls.Add(Me.grpMin)
        Me.Controls.Add(Me.grpMax)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Information"
        Me.grpMax.ResumeLayout(False)
        Me.grpMax.PerformLayout()
        CType(Me.TBL_SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMin.ResumeLayout(False)
        Me.grpMin.PerformLayout()
        Me.grpSub.ResumeLayout(False)
        Me.grpSub.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.TBL_SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLSubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_SubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_SubjectTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_SubjectTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents TBL_BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grpMax As System.Windows.Forms.GroupBox
    Friend WithEvents TH_MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PR_MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OR_MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TW_MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpMin As System.Windows.Forms.GroupBox
    Friend WithEvents TH_MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PR_MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OR_MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TW_MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpSub As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBrCode As System.Windows.Forms.ComboBox
    Friend WithEvents Subject_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TBLSubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TBL_SubjectDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TBLBranchBindingSource1 As System.Windows.Forms.BindingSource
End Class
