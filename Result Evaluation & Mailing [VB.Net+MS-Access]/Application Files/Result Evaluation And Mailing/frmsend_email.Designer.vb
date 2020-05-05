<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsend_email
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
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.txtSub = New System.Windows.Forms.TextBox
        Me.btnSend = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TBLResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REM_DBDataSet = New WindowsApplication1.REM_DBDataSet
        Me.cmbSeason = New System.Windows.Forms.ComboBox
        Me.cmbBrCode = New System.Windows.Forms.ComboBox
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.REMDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_ResultTableAdapter = New WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REMDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(129, 67)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.ReadOnly = True
        Me.txtFrom.Size = New System.Drawing.Size(245, 23)
        Me.txtFrom.TabIndex = 0
        Me.txtFrom.TabStop = False
        '
        'txtSub
        '
        Me.txtSub.Location = New System.Drawing.Point(129, 115)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(245, 23)
        Me.txtSub.TabIndex = 4
        '
        'btnSend
        '
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Location = New System.Drawing.Point(129, 199)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(245, 37)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send Emails"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Exam Season :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Exam Year :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brach Code :"
        '
        'btnShow
        '
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Location = New System.Drawing.Point(52, 199)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(260, 37)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show Results"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(735, 228)
        Me.DataGridView1.TabIndex = 7
        Me.DataGridView1.TabStop = False
        '
        'TBLResultBindingSource
        '
        Me.TBLResultBindingSource.DataMember = "TBL_Result"
        Me.TBLResultBindingSource.DataSource = Me.REM_DBDataSet
        '
        'REM_DBDataSet
        '
        Me.REM_DBDataSet.DataSetName = "REM_DBDataSet"
        Me.REM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbSeason
        '
        Me.cmbSeason.DropDownHeight = 75
        Me.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSeason.FormattingEnabled = True
        Me.cmbSeason.IntegralHeight = False
        Me.cmbSeason.Items.AddRange(New Object() {"Summer", "Winter"})
        Me.cmbSeason.Location = New System.Drawing.Point(191, 46)
        Me.cmbSeason.Name = "cmbSeason"
        Me.cmbSeason.Size = New System.Drawing.Size(121, 24)
        Me.cmbSeason.TabIndex = 0
        '
        'cmbBrCode
        '
        Me.cmbBrCode.DropDownHeight = 75
        Me.cmbBrCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrCode.FormattingEnabled = True
        Me.cmbBrCode.IntegralHeight = False
        Me.cmbBrCode.Location = New System.Drawing.Point(191, 145)
        Me.cmbBrCode.Name = "cmbBrCode"
        Me.cmbBrCode.Size = New System.Drawing.Size(121, 24)
        Me.cmbBrCode.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(191, 97)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(121, 23)
        Me.txtYear.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "From:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Subject:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbBrCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.cmbSeason)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 277)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Results"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Controls.Add(Me.txtFrom)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSub)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(447, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 277)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Send E-Mails"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(35, 391)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(816, 283)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Results"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(212, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(635, 54)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Result Evaluation and Mailing"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.email_icon
        Me.PictureBox2.Location = New System.Drawing.Point(40, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'REMDBDataSetBindingSource
        '
        Me.REMDBDataSetBindingSource.DataSource = Me.REM_DBDataSet
        Me.REMDBDataSetBindingSource.Position = 0
        '
        'TBL_ResultTableAdapter
        '
        Me.TBL_ResultTableAdapter.ClearBeforeFill = True
        '
        'frmsend_email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.light_blue_plain_images_147902
        Me.ClientSize = New System.Drawing.Size(889, 696)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmsend_email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Email"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REMDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtSub As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSeason As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBrCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents REMDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REM_DBDataSet As WindowsApplication1.REM_DBDataSet
    Friend WithEvents TBLResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBL_ResultTableAdapter As WindowsApplication1.REM_DBDataSetTableAdapters.TBL_ResultTableAdapter
End Class
