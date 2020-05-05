<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDept
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
        Dim Short_CodeLabel As System.Windows.Forms.Label
        Dim Department_NameLabel As System.Windows.Forms.Label
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_DeptTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_DeptTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_DeptDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Short_CodeTextBox = New System.Windows.Forms.TextBox
        Me.Department_NameTextBox = New System.Windows.Forms.TextBox
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpDept = New System.Windows.Forms.GroupBox
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnEdit = New System.Windows.Forms.Button
        Short_CodeLabel = New System.Windows.Forms.Label
        Department_NameLabel = New System.Windows.Forms.Label
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_DeptDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpe.SuspendLayout()
        Me.grpDept.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Short_CodeLabel
        '
        Short_CodeLabel.AutoSize = True
        Short_CodeLabel.Location = New System.Drawing.Point(21, 42)
        Short_CodeLabel.Name = "Short_CodeLabel"
        Short_CodeLabel.Size = New System.Drawing.Size(83, 17)
        Short_CodeLabel.TabIndex = 1
        Short_CodeLabel.Text = "Short Code:"
        '
        'Department_NameLabel
        '
        Department_NameLabel.AutoSize = True
        Department_NameLabel.Location = New System.Drawing.Point(21, 84)
        Department_NameLabel.Name = "Department_NameLabel"
        Department_NameLabel.Size = New System.Drawing.Size(127, 17)
        Department_NameLabel.TabIndex = 3
        Department_NameLabel.Text = "Department Name:"
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_DeptBindingSource
        '
        Me.TBL_DeptBindingSource.DataMember = "TBL_Dept"
        Me.TBL_DeptBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBL_DeptTableAdapter
        '
        Me.TBL_DeptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BranchTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Me.TBL_DeptTableAdapter
        Me.TableAdapterManager.TBL_LoginTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ResultTableAdapter = Nothing
        Me.TableAdapterManager.TBL_StudentTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_DeptDataGridView
        '
        Me.TBL_DeptDataGridView.AutoGenerateColumns = False
        Me.TBL_DeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_DeptDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TBL_DeptDataGridView.DataSource = Me.TBL_DeptBindingSource
        Me.TBL_DeptDataGridView.Location = New System.Drawing.Point(35, 71)
        Me.TBL_DeptDataGridView.Name = "TBL_DeptDataGridView"
        Me.TBL_DeptDataGridView.ReadOnly = True
        Me.TBL_DeptDataGridView.Size = New System.Drawing.Size(313, 166)
        Me.TBL_DeptDataGridView.TabIndex = 1
        Me.TBL_DeptDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Short_Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Short Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Department_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Department Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'Short_CodeTextBox
        '
        Me.Short_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_DeptBindingSource, "Short_Code", True))
        Me.Short_CodeTextBox.Location = New System.Drawing.Point(184, 39)
        Me.Short_CodeTextBox.Name = "Short_CodeTextBox"
        Me.Short_CodeTextBox.Size = New System.Drawing.Size(81, 23)
        Me.Short_CodeTextBox.TabIndex = 1
        '
        'Department_NameTextBox
        '
        Me.Department_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_DeptBindingSource, "Department_Name", True))
        Me.Department_NameTextBox.Location = New System.Drawing.Point(184, 81)
        Me.Department_NameTextBox.Name = "Department_NameTextBox"
        Me.Department_NameTextBox.Size = New System.Drawing.Size(201, 23)
        Me.Department_NameTextBox.TabIndex = 2
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(289, 255)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(22, 255)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(111, 255)
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
        Me.btnNext.Location = New System.Drawing.Point(200, 255)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 8
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
        Me.grpOpe.Location = New System.Drawing.Point(43, 305)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(407, 74)
        Me.grpOpe.TabIndex = 15
        Me.grpOpe.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(114, 26)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(212, 26)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 4
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(19, 26)
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
        Me.btnClose.Location = New System.Drawing.Point(310, 26)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 31)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpDept
        '
        Me.grpDept.BackColor = System.Drawing.Color.Transparent
        Me.grpDept.Controls.Add(Me.Department_NameTextBox)
        Me.grpDept.Controls.Add(Department_NameLabel)
        Me.grpDept.Controls.Add(Me.Short_CodeTextBox)
        Me.grpDept.Controls.Add(Short_CodeLabel)
        Me.grpDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDept.Location = New System.Drawing.Point(43, 166)
        Me.grpDept.Name = "grpDept"
        Me.grpDept.Size = New System.Drawing.Size(407, 133)
        Me.grpDept.TabIndex = 16
        Me.grpDept.TabStop = False
        Me.grpDept.Text = "Department Details"
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.TBL_DeptDataGridView)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(487, 113)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(385, 309)
        Me.grpSearch.TabIndex = 18
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "All Departments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(635, 54)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Organizational_Chart
        Me.PictureBox2.Location = New System.Drawing.Point(62, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(50, 40)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 25)
        Me.btnEdit.TabIndex = 27
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(909, 451)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpOpe)
        Me.Controls.Add(Me.grpDept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Department"
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_DeptDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpe.ResumeLayout(False)
        Me.grpDept.ResumeLayout(False)
        Me.grpDept.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_DeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_DeptTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_DeptTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_DeptDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Short_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Department_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpDept As System.Windows.Forms.GroupBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
