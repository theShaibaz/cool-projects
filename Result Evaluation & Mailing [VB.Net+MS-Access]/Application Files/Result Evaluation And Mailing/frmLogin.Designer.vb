<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.TBL_LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_LoginTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_LoginTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
        Me.User_PassTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCan = New System.Windows.Forms.Button
        Me.btnLogin = New System.Windows.Forms.Button
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.cmbID = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        User_IDLabel = New System.Windows.Forms.Label
        User_PassLabel = New System.Windows.Forms.Label
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Location = New System.Drawing.Point(28, 48)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.Size = New System.Drawing.Size(59, 17)
        User_IDLabel.TabIndex = 5
        User_IDLabel.Text = "User ID:"
        '
        'User_PassLabel
        '
        User_PassLabel.AutoSize = True
        User_PassLabel.Location = New System.Drawing.Point(28, 99)
        User_PassLabel.Name = "User_PassLabel"
        User_PassLabel.Size = New System.Drawing.Size(73, 17)
        User_PassLabel.TabIndex = 8
        User_PassLabel.Text = "Password:"
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_LoginBindingSource
        '
        Me.TBL_LoginBindingSource.DataMember = "TBL_Login"
        Me.TBL_LoginBindingSource.DataSource = Me.REM_DBDataSet
        '
        'TBL_LoginTableAdapter
        '
        Me.TBL_LoginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AtktTableAdapter = Nothing
        Me.TableAdapterManager.TBL_BranchTableAdapter = Nothing
        Me.TableAdapterManager.TBL_ClassTableAdapter = Nothing
        Me.TableAdapterManager.TBL_DeptTableAdapter = Nothing
        Me.TableAdapterManager.TBL_LoginTableAdapter = Me.TBL_LoginTableAdapter
        Me.TableAdapterManager.TBL_ResultTableAdapter = Nothing
        Me.TableAdapterManager.TBL_StudentTableAdapter = Nothing
        Me.TableAdapterManager.TBL_SubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'User_PassTextBox
        '
        Me.User_PassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_LoginBindingSource, "User_Pass", True))
        Me.User_PassTextBox.Location = New System.Drawing.Point(522, 266)
        Me.User_PassTextBox.Name = "User_PassTextBox"
        Me.User_PassTextBox.Size = New System.Drawing.Size(141, 20)
        Me.User_PassTextBox.TabIndex = 4
        Me.User_PassTextBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnCan)
        Me.GroupBox2.Controls.Add(Me.btnLogin)
        Me.GroupBox2.Controls.Add(Me.txtpass)
        Me.GroupBox2.Controls.Add(Me.cmbID)
        Me.GroupBox2.Controls.Add(User_IDLabel)
        Me.GroupBox2.Controls.Add(User_PassLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(266, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 214)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'btnCan
        '
        Me.btnCan.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Location = New System.Drawing.Point(212, 150)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 31)
        Me.btnCan.TabIndex = 3
        Me.btnCan.Text = "Cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(51, 150)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 31)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(149, 96)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(166, 23)
        Me.txtpass.TabIndex = 1
        Me.txtpass.UseSystemPasswordChar = True
        '
        'cmbID
        '
        Me.cmbID.DropDownHeight = 75
        Me.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID.DropDownWidth = 121
        Me.cmbID.FormattingEnabled = True
        Me.cmbID.IntegralHeight = False
        Me.cmbID.Location = New System.Drawing.Point(149, 45)
        Me.cmbID.Name = "cmbID"
        Me.cmbID.Size = New System.Drawing.Size(166, 24)
        Me.cmbID.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Login_Page_Image
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.CancelButton = Me.btnCan
        Me.ClientSize = New System.Drawing.Size(626, 255)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.User_PassTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login "
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBL_LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_LoginTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_LoginTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.REM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_PassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents cmbID As System.Windows.Forms.ComboBox
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
