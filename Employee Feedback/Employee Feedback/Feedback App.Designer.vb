<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label_Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_employeeID = New System.Windows.Forms.TextBox()
        Me.label_department = New System.Windows.Forms.Label()
        Me.cb_department = New System.Windows.Forms.ComboBox()
        Me.button_submit = New System.Windows.Forms.Button()
        Me.label_score = New System.Windows.Forms.Label()
        Me.cb_score = New System.Windows.Forms.ComboBox()
        Me.label_comment = New System.Windows.Forms.Label()
        Me.tb_comment = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label_resultscore = New System.Windows.Forms.Label()
        Me.cb_resultdepartment = New System.Windows.Forms.ComboBox()
        Me.label_resultdepartment = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.label_employee = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label_Title
        '
        Me.label_Title.AutoSize = True
        Me.label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Title.Location = New System.Drawing.Point(19, 14)
        Me.label_Title.Name = "label_Title"
        Me.label_Title.Size = New System.Drawing.Size(420, 17)
        Me.label_Title.TabIndex = 0
        Me.label_Title.Text = "Employee Manager Evaluation, Please Submit Feedback."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter EmployeeID:"
        '
        'tb_employeeID
        '
        Me.tb_employeeID.Location = New System.Drawing.Point(151, 53)
        Me.tb_employeeID.Name = "tb_employeeID"
        Me.tb_employeeID.Size = New System.Drawing.Size(150, 20)
        Me.tb_employeeID.TabIndex = 2
        '
        'label_department
        '
        Me.label_department.AutoSize = True
        Me.label_department.Location = New System.Drawing.Point(47, 110)
        Me.label_department.Name = "label_department"
        Me.label_department.Size = New System.Drawing.Size(98, 13)
        Me.label_department.TabIndex = 3
        Me.label_department.Text = "Select Department:"
        '
        'cb_department
        '
        Me.cb_department.FormattingEnabled = True
        Me.cb_department.Location = New System.Drawing.Point(151, 102)
        Me.cb_department.Name = "cb_department"
        Me.cb_department.Size = New System.Drawing.Size(405, 21)
        Me.cb_department.TabIndex = 4
        '
        'button_submit
        '
        Me.button_submit.Location = New System.Drawing.Point(481, 50)
        Me.button_submit.Name = "button_submit"
        Me.button_submit.Size = New System.Drawing.Size(75, 23)
        Me.button_submit.TabIndex = 5
        Me.button_submit.Text = "Submit"
        Me.button_submit.UseVisualStyleBackColor = True
        '
        'label_score
        '
        Me.label_score.AutoSize = True
        Me.label_score.Location = New System.Drawing.Point(79, 160)
        Me.label_score.Name = "label_score"
        Me.label_score.Size = New System.Drawing.Size(66, 13)
        Me.label_score.TabIndex = 6
        Me.label_score.Text = "Enter Score:"
        '
        'cb_score
        '
        Me.cb_score.FormattingEnabled = True
        Me.cb_score.Location = New System.Drawing.Point(151, 151)
        Me.cb_score.Name = "cb_score"
        Me.cb_score.Size = New System.Drawing.Size(75, 21)
        Me.cb_score.TabIndex = 7
        '
        'label_comment
        '
        Me.label_comment.AutoSize = True
        Me.label_comment.Location = New System.Drawing.Point(63, 210)
        Me.label_comment.Name = "label_comment"
        Me.label_comment.Size = New System.Drawing.Size(82, 13)
        Me.label_comment.TabIndex = 8
        Me.label_comment.Text = "Enter Comment:"
        '
        'tb_comment
        '
        Me.tb_comment.Location = New System.Drawing.Point(151, 207)
        Me.tb_comment.Name = "tb_comment"
        Me.tb_comment.Size = New System.Drawing.Size(405, 84)
        Me.tb_comment.TabIndex = 9
        Me.tb_comment.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Feedback Results by Repartment Manager."
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(151, 575)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(405, 84)
        Me.RichTextBox1.TabIndex = 19
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Enter Comment:"
        '
        'label_resultscore
        '
        Me.label_resultscore.AutoSize = True
        Me.label_resultscore.Location = New System.Drawing.Point(58, 525)
        Me.label_resultscore.Name = "label_resultscore"
        Me.label_resultscore.Size = New System.Drawing.Size(87, 13)
        Me.label_resultscore.TabIndex = 16
        Me.label_resultscore.Text = "Employee Score:"
        '
        'cb_resultdepartment
        '
        Me.cb_resultdepartment.FormattingEnabled = True
        Me.cb_resultdepartment.Location = New System.Drawing.Point(151, 367)
        Me.cb_resultdepartment.Name = "cb_resultdepartment"
        Me.cb_resultdepartment.Size = New System.Drawing.Size(405, 21)
        Me.cb_resultdepartment.TabIndex = 14
        '
        'label_resultdepartment
        '
        Me.label_resultdepartment.AutoSize = True
        Me.label_resultdepartment.Location = New System.Drawing.Point(47, 375)
        Me.label_resultdepartment.Name = "label_resultdepartment"
        Me.label_resultdepartment.Size = New System.Drawing.Size(98, 13)
        Me.label_resultdepartment.TabIndex = 13
        Me.label_resultdepartment.Text = "Select Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "No. Responses:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 418)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Average:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(337, 418)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 23
        '
        'label_employee
        '
        Me.label_employee.AutoSize = True
        Me.label_employee.Location = New System.Drawing.Point(89, 475)
        Me.label_employee.Name = "label_employee"
        Me.label_employee.Size = New System.Drawing.Size(56, 13)
        Me.label_employee.TabIndex = 24
        Me.label_employee.Text = "Employee:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 466)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(151, 518)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 738)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.label_employee)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label_resultscore)
        Me.Controls.Add(Me.cb_resultdepartment)
        Me.Controls.Add(Me.label_resultdepartment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_comment)
        Me.Controls.Add(Me.label_comment)
        Me.Controls.Add(Me.cb_score)
        Me.Controls.Add(Me.label_score)
        Me.Controls.Add(Me.button_submit)
        Me.Controls.Add(Me.cb_department)
        Me.Controls.Add(Me.label_department)
        Me.Controls.Add(Me.tb_employeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_Title)
        Me.Name = "Form1"
        Me.Text = "Employee Feedback App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_Title As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents label_department As System.Windows.Forms.Label
    Friend WithEvents cb_department As System.Windows.Forms.ComboBox
    Friend WithEvents button_submit As System.Windows.Forms.Button
    Friend WithEvents label_score As System.Windows.Forms.Label
    Friend WithEvents cb_score As System.Windows.Forms.ComboBox
    Friend WithEvents label_comment As System.Windows.Forms.Label
    Friend WithEvents tb_comment As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label_resultscore As System.Windows.Forms.Label
    Friend WithEvents cb_resultdepartment As System.Windows.Forms.ComboBox
    Friend WithEvents label_resultdepartment As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents label_employee As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
