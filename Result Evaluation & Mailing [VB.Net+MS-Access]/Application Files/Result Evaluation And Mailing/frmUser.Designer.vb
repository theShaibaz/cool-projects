<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim User_PassLabel As System.Windows.Forms.Label
        Me.grpUser = New System.Windows.Forms.GroupBox
        Me.chkShow = New System.Windows.Forms.CheckBox
        Me.cmbUID = New System.Windows.Forms.ComboBox
        Me.User_PassTextBox = New System.Windows.Forms.TextBox
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnPre = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.grpOpe = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.TBL_LoginDataGridView = New System.Windows.Forms.DataGridView
        Me.btnEdit = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TBL_LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_LoginTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_LoginTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.TBL_BranchTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
        Me.TBLBranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLLoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLBranchBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        User_IDLabel = New System.Windows.Forms.Label
        User_PassLabel = New System.Windows.Forms.Label
        Me.grpUser.SuspendLayout()
        Me.grpOpe.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.TBL_LoginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLLoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBranchBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Location = New System.Drawing.Point(42, 46)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.Size = New System.Drawing.Size(63, 17)
        User_IDLabel.TabIndex = 7
        User_IDLabel.Text = "User ID :"
        '
        'User_PassLabel
        '
        User_PassLabel.AutoSize = True
        User_PassLabel.Location = New System.Drawing.Point(42, 88)
        User_PassLabel.Name = "User_PassLabel"
        User_PassLabel.Size = New System.Drawing.Size(77, 17)
        User_PassLabel.TabIndex = 9
        User_PassLabel.Text = "Password :"
        '
        'grpUser
        '
        Me.grpUser.BackColor = System.Drawing.Color.Transparent
        Me.grpUser.Controls.Add(Me.chkShow)
        Me.grpUser.Controls.Add(Me.cmbUID)
        Me.grpUser.Controls.Add(User_IDLabel)
        Me.grpUser.Controls.Add(User_PassLabel)
        Me.grpUser.Controls.Add(Me.User_PassTextBox)
        Me.grpUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUser.Location = New System.Drawing.Point(38, 153)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(413, 157)
        Me.grpUser.TabIndex = 7
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "User Information"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(190, 119)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(126, 21)
        Me.chkShow.TabIndex = 3
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'cmbUID
        '
        Me.cmbUID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TBL_LoginBindingSource, "User_ID", True))
        Me.cmbUID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_LoginBindingSource, "User_ID", True))
        Me.cmbUID.DataSource = Me.TBLBranchBindingSource2
        Me.cmbUID.DisplayMember = "Branch_Code"
        Me.cmbUID.DropDownHeight = 75
        Me.cmbUID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUID.FormattingEnabled = True
        Me.cmbUID.IntegralHeight = False
        Me.cmbUID.Location = New System.Drawing.Point(190, 39)
        Me.cmbUID.Name = "cmbUID"
        Me.cmbUID.Size = New System.Drawing.Size(194, 24)
        Me.cmbUID.TabIndex = 1
        Me.cmbUID.ValueMember = "Branch_Code"
        '
        'User_PassTextBox
        '
        Me.User_PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_LoginBindingSource, "User_Pass", True))
        Me.User_PassTextBox.Location = New System.Drawing.Point(190, 82)
        Me.User_PassTextBox.Name = "User_PassTextBox"
        Me.User_PassTextBox.Size = New System.Drawing.Size(194, 23)
        Me.User_PassTextBox.TabIndex = 2
        Me.User_PassTextBox.UseSystemPasswordChar = True
        '
        'btnCan
        '
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(214, 25)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 5
        Me.btnCan.Text = "&Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.Location = New System.Drawing.Point(306, 267)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 31)
        Me.btnLast.TabIndex = 10
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.Location = New System.Drawing.Point(18, 267)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 31)
        Me.btnFirst.TabIndex = 7
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPre
        '
        Me.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPre.Location = New System.Drawing.Point(114, 267)
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
        Me.btnNext.Location = New System.Drawing.Point(210, 267)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpOpe
        '
        Me.grpOpe.BackColor = System.Drawing.Color.Transparent
        Me.grpOpe.Controls.Add(Me.btnCan)
        Me.grpOpe.Controls.Add(Me.btnSave)
        Me.grpOpe.Controls.Add(Me.btnAdd)
        Me.grpOpe.Controls.Add(Me.btnClose)
        Me.grpOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpe.Location = New System.Drawing.Point(38, 316)
        Me.grpOpe.Name = "grpOpe"
        Me.grpOpe.Size = New System.Drawing.Size(413, 72)
        Me.grpOpe.TabIndex = 17
        Me.grpOpe.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(122, 25)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 4
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
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.TBL_LoginDataGridView)
        Me.grpSearch.Controls.Add(Me.btnPre)
        Me.grpSearch.Controls.Add(Me.btnLast)
        Me.grpSearch.Controls.Add(Me.btnNext)
        Me.grpSearch.Controls.Add(Me.btnFirst)
        Me.grpSearch.Controls.Add(Me.btnEdit)
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(486, 115)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(401, 318)
        Me.grpSearch.TabIndex = 19
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "All Accounts"
        '
        'TBL_LoginDataGridView
        '
        Me.TBL_LoginDataGridView.AllowUserToAddRows = False
        Me.TBL_LoginDataGridView.AllowUserToDeleteRows = False
        Me.TBL_LoginDataGridView.AutoGenerateColumns = False
        Me.TBL_LoginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBL_LoginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TBL_LoginDataGridView.DataSource = Me.TBL_LoginBindingSource
        Me.TBL_LoginDataGridView.Location = New System.Drawing.Point(52, 72)
        Me.TBL_LoginDataGridView.Name = "TBL_LoginDataGridView"
        Me.TBL_LoginDataGridView.ReadOnly = True
        Me.TBL_LoginDataGridView.Size = New System.Drawing.Size(295, 176)
        Me.TBL_LoginDataGridView.TabIndex = 30
        Me.TBL_LoginDataGridView.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(213, 35)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 25)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "&Edit Account"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.feature_users
        Me.PictureBox2.Location = New System.Drawing.Point(43, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 54)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Result Evaluation and Mailing"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "User_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "User_Pass"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'TBL_LoginBindingSource
        '
        Me.TBL_LoginBindingSource.DataMember = "TBL_Login"
        Me.TBL_LoginBindingSource.DataSource = Me.REM_DBDataSet
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_LoginTableAdapter
        '
        Me.TBL_LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BranchTableAdapter = Me.TBL_BranchTableAdapter
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LoginTableAdapter = Me.TBL_LoginTableAdapter
        Me.TableAdapterManager.TBL_ResultTableAdapter = Nothing
        Me.TableAdapterManager.TBL_StudentTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_BranchTableAdapter
        '
        Me.TBL_BranchTableAdapter.ClearBeforeFill = True
        '
        'TBLBranchBindingSource
        '
        Me.TBLBranchBindingSource.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLLoginBindingSource
        '
        Me.TBLLoginBindingSource.DataMember = "TBL_Login"
        Me.TBLLoginBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource1
        '
        Me.TBLBranchBindingSource1.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource1.DataSource = Me.REM_DBDataSet
        '
        'TBLBranchBindingSource2
        '
        Me.TBLBranchBindingSource2.DataMember = "TBL_Branch"
        Me.TBLBranchBindingSource2.DataSource = Me.REM_DBDataSet
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(921, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpOpe)
        Me.Controls.Add(Me.grpUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New User"
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.grpOpe.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        CType(Me.TBL_LoginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLLoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBranchBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_LoginTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_LoginTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grpUser As System.Windows.Forms.GroupBox
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents User_PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPre As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents grpOpe As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents TBL_BranchTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_BranchTableAdapter
    Friend WithEvents cmbUID As System.Windows.Forms.ComboBox
    Friend WithEvents TBLBranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents TBLLoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBLBranchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_LoginDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBLBranchBindingSource2 As System.Windows.Forms.BindingSource
End Class
