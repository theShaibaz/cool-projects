<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBranch
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
        Dim Branch_CodeLabel As System.Windows.Forms.Label
        Dim Branch_NameLabel As System.Windows.Forms.Label
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_DeptTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_DeptTableAdapter
        Me.grpBranch = New System.Windows.Forms.GroupBox
        Me.Branch_NameComboBox = New System.Windows.Forms.ComboBox
        Me.Branch_CodeTextBox = New System.Windows.Forms.TextBox
        Me.TBLDeptBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.TBL_BranchDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Branch_CodeLabel = New System.Windows.Forms.Label
        Branch_NameLabel = New System.Windows.Forms.Label
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBranch.SuspendLayout()
        CType(Me.TBLDeptBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpe.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.TBL_BranchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Branch_CodeLabel
        '
        Branch_CodeLabel.AutoSize = True
        Branch_CodeLabel.Location = New System.Drawing.Point(23, 42)
        Branch_CodeLabel.Name = "Branch_CodeLabel"
        Branch_CodeLabel.Size = New System.Drawing.Size(94, 17)
        Branch_CodeLabel.TabIndex = 7
        Branch_CodeLabel.Text = "Branch Code:"
        '
        'Branch_NameLabel
        '
        Branch_NameLabel.AutoSize = True
        Branch_NameLabel.Location = New System.Drawing.Point(23, 89)
        Branch_NameLabel.Name = "Branch_NameLabel"
        Branch_NameLabel.Size = New System.Drawing.Size(127, 17)
        Branch_NameLabel.TabIndex = 10
        Branch_NameLabel.Text = "Department Name:"
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_BranchBindingSource
        '
        Me.TBL_BranchBindingSource.DataMember = "TBL_Branch"
        Me.TBL_BranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBL_BranchTableAdapter
        '
        Me.TBL_BranchTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBL_StudentTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_DeptTableAdapter
        '
        Me.TBL_DeptTableAdapter.ClearBeforeFill = True
        '
        'grpBranch
        '
        Me.grpBranch.BackColor = System.Drawing.Color.Transparent
        Me.grpBranch.Controls.Add(Me.Branch_NameComboBox)
        Me.grpBranch.Controls.Add(Branch_CodeLabel)
        Me.grpBranch.Controls.Add(Me.Branch_CodeTextBox)
        Me.grpBranch.Controls.Add(Branch_NameLabel)
        Me.grpBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBranch.Location = New System.Drawing.Point(33, 209)
        Me.grpBranch.Name = "grpBranch"
        Me.grpBranch.Size = New System.Drawing.Size(341, 137)
        Me.grpBranch.TabIndex = 13
        Me.grpBranch.TabStop = False
        Me.grpBranch.Text = "Branch Details"
        '
        'Branch_NameComboBox
        '
        Me.Branch_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_BranchBindingSource, "Branch_Name", True))
        Me.Branch_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_BranchBindingSource, "Branch_Name", True))
        Me.Branch_NameComboBox.DataSource = Me.TBLDeptBindingSource
        Me.Branch_NameComboBox.DisplayMember = "Department_Name"
        Me.Branch_NameComboBox.DropDownHeight = 75
        Me.Branch_NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Branch_NameComboBox.FormattingEnabled = True
        Me.Branch_NameComboBox.IntegralHeight = False
        Me.Branch_NameComboBox.Location = New System.Drawing.Point(159, 86)
        Me.Branch_NameComboBox.Name = "Branch_NameComboBox"
        Me.Branch_NameComboBox.Size = New System.Drawing.Size(164, 24)
        Me.Branch_NameComboBox.TabIndex = 2
        Me.Branch_NameComboBox.ValueMember = "Department_Name"
        '
        'Branch_CodeTextBox
        '
        Me.Branch_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_BranchBindingSource, "Branch_Code", True))
        Me.Branch_CodeTextBox.Location = New System.Drawing.Point(159, 39)
        Me.Branch_CodeTextBox.Name = "Branch_CodeTextBox"
        Me.Branch_CodeTextBox.Size = New System.Drawing.Size(164, 23)
        Me.Branch_CodeTextBox.TabIndex = 1
        '
        'TBLDeptBindingSource1
        '
        Me.TBLDeptBindingSource1.DataMember = "TBL_Dept"
        Me.TBLDeptBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLDeptBindingSource
        '
        Me.TBLDeptBindingSource.DataMember = "TBL_Dept"
        Me.TBLDeptBindingSource.DataSource = Me.REM_DBDataSet
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(172, 30)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 4
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(91, 30)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(253, 30)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(10, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpOpe
        '
        Me.grpOpe.BackColor = System.Drawing.Color.Transparent
        Me.grpOpe.Controls.Add(Me.btnSave)
        Me.grpOpe.Controls.Add(Me.btnCan)
        Me.grpOpe.Controls.Add(Me.btnAdd)
        Me.grpOpe.Controls.Add(Me.btnClose)
        Me.grpOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpe.Location = New System.Drawing.Point(33, 352)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(341, 76)
        Me.grpOpe.TabIndex = 11
        Me.grpOpe.TabStop = False
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(297, 320)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(19, 320)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(111, 320)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(75, 31)
        Me.btnPre.TabIndex = 7
        Me.btnPre.Text = "<<"
        Me.btnPre.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(205, 320)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Controls.Add(Me.btnDel)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.TBL_BranchDataGridView)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(394, 126)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(383, 378)
        Me.grpSearch.TabIndex = 15
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Branch"
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(203, 59)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(117, 25)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(49, 59)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 25)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'TBL_BranchDataGridView
        '
        Me.TBL_BranchDataGridView.AllowUserToAddRows = False
        Me.TBL_BranchDataGridView.AllowUserToDeleteRows = False
        Me.TBL_BranchDataGridView.AutoGenerateColumns = False
        Me.TBL_BranchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_BranchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TBL_BranchDataGridView.DataSource = Me.TBL_BranchBindingSource
        Me.TBL_BranchDataGridView.Location = New System.Drawing.Point(28, 110)
        Me.TBL_BranchDataGridView.Name = "TBL_BranchDataGridView"
        Me.TBL_BranchDataGridView.ReadOnly = True
        Me.TBL_BranchDataGridView.Size = New System.Drawing.Size(320, 191)
        Me.TBL_BranchDataGridView.TabIndex = 13
        Me.TBL_BranchDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Branch_Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Branch Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Branch_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(544, 46)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Organizational_Chart
        Me.PictureBox2.Location = New System.Drawing.Point(31, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'frmBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(818, 532)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpOpe)
        Me.Controls.Add(Me.grpBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBranch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Branch"
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBranch.ResumeLayout(False)
        Me.grpBranch.PerformLayout()
        CType(Me.TBLDeptBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpe.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        CType(Me.TBL_BranchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grpBranch As System.Windows.Forms.GroupBox
    Friend WithEvents Branch_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents TBL_BranchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents TBL_DeptTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_DeptTableAdapter
    Friend WithEvents Branch_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TBLDeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLDeptBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
