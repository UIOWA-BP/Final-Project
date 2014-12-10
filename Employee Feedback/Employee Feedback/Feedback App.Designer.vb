<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeeFeedback
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
        Me.managerNameLabel = New System.Windows.Forms.Label()
        Me.tb_comments_results = New System.Windows.Forms.TextBox()
        Me.label_comments_results = New System.Windows.Forms.Label()
        Me.tb_employeescore = New System.Windows.Forms.TextBox()
        Me.label_employeescore = New System.Windows.Forms.Label()
        Me.combo_employee = New System.Windows.Forms.ComboBox()
        Me.label_employee_results = New System.Windows.Forms.Label()
        Me.tb_average = New System.Windows.Forms.TextBox()
        Me.label_average = New System.Windows.Forms.Label()
        Me.tb_responses = New System.Windows.Forms.TextBox()
        Me.label_responses = New System.Windows.Forms.Label()
        Me.combo_department_results = New System.Windows.Forms.ComboBox()
        Me.label_department_results = New System.Windows.Forms.Label()
        Me.label_results = New System.Windows.Forms.Label()
        Me.tb_comment = New System.Windows.Forms.TextBox()
        Me.label_comments = New System.Windows.Forms.Label()
        Me.combo_score = New System.Windows.Forms.ComboBox()
        Me.label_score = New System.Windows.Forms.Label()
        Me.combo_department = New System.Windows.Forms.ComboBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.label_department = New System.Windows.Forms.Label()
        Me.tb_employeeID = New System.Windows.Forms.TextBox()
        Me.label_employeeID = New System.Windows.Forms.Label()
        Me.label_evaluation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'managerNameLabel
        '
        Me.managerNameLabel.AutoSize = True
        Me.managerNameLabel.Location = New System.Drawing.Point(36, 381)
        Me.managerNameLabel.Name = "managerNameLabel"
        Me.managerNameLabel.Size = New System.Drawing.Size(0, 13)
        Me.managerNameLabel.TabIndex = 48
        '
        'tb_comments_results
        '
        Me.tb_comments_results.Location = New System.Drawing.Point(147, 541)
        Me.tb_comments_results.Name = "tb_comments_results"
        Me.tb_comments_results.Size = New System.Drawing.Size(348, 20)
        Me.tb_comments_results.TabIndex = 47
        '
        'label_comments_results
        '
        Me.label_comments_results.AutoSize = True
        Me.label_comments_results.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_comments_results.Location = New System.Drawing.Point(34, 541)
        Me.label_comments_results.Name = "label_comments_results"
        Me.label_comments_results.Size = New System.Drawing.Size(64, 15)
        Me.label_comments_results.TabIndex = 46
        Me.label_comments_results.Text = "Comment:"
        '
        'tb_employeescore
        '
        Me.tb_employeescore.Location = New System.Drawing.Point(147, 504)
        Me.tb_employeescore.Name = "tb_employeescore"
        Me.tb_employeescore.Size = New System.Drawing.Size(100, 20)
        Me.tb_employeescore.TabIndex = 45
        '
        'label_employeescore
        '
        Me.label_employeescore.AutoSize = True
        Me.label_employeescore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_employeescore.Location = New System.Drawing.Point(34, 504)
        Me.label_employeescore.Name = "label_employeescore"
        Me.label_employeescore.Size = New System.Drawing.Size(94, 15)
        Me.label_employeescore.TabIndex = 44
        Me.label_employeescore.Text = "Employee Score:"
        '
        'combo_employee
        '
        Me.combo_employee.FormattingEnabled = True
        Me.combo_employee.Location = New System.Drawing.Point(147, 461)
        Me.combo_employee.Name = "combo_employee"
        Me.combo_employee.Size = New System.Drawing.Size(121, 21)
        Me.combo_employee.TabIndex = 43
        '
        'label_employee_results
        '
        Me.label_employee_results.AutoSize = True
        Me.label_employee_results.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_employee_results.Location = New System.Drawing.Point(36, 463)
        Me.label_employee_results.Name = "label_employee_results"
        Me.label_employee_results.Size = New System.Drawing.Size(62, 15)
        Me.label_employee_results.TabIndex = 42
        Me.label_employee_results.Text = "Employee:"
        '
        'tb_average
        '
        Me.tb_average.Location = New System.Drawing.Point(362, 420)
        Me.tb_average.Name = "tb_average"
        Me.tb_average.Size = New System.Drawing.Size(100, 20)
        Me.tb_average.TabIndex = 41
        '
        'label_average
        '
        Me.label_average.AutoSize = True
        Me.label_average.Location = New System.Drawing.Point(293, 422)
        Me.label_average.Name = "label_average"
        Me.label_average.Size = New System.Drawing.Size(50, 13)
        Me.label_average.TabIndex = 40
        Me.label_average.Text = "Average:"
        '
        'tb_responses
        '
        Me.tb_responses.Location = New System.Drawing.Point(147, 422)
        Me.tb_responses.Name = "tb_responses"
        Me.tb_responses.Size = New System.Drawing.Size(100, 20)
        Me.tb_responses.TabIndex = 39
        '
        'label_responses
        '
        Me.label_responses.AutoSize = True
        Me.label_responses.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_responses.Location = New System.Drawing.Point(34, 422)
        Me.label_responses.Name = "label_responses"
        Me.label_responses.Size = New System.Drawing.Size(82, 15)
        Me.label_responses.TabIndex = 38
        Me.label_responses.Text = "No. Response:"
        '
        'combo_department_results
        '
        Me.combo_department_results.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_department_results.FormattingEnabled = True
        Me.combo_department_results.Location = New System.Drawing.Point(147, 345)
        Me.combo_department_results.Name = "combo_department_results"
        Me.combo_department_results.Size = New System.Drawing.Size(348, 21)
        Me.combo_department_results.TabIndex = 37
        '
        'label_department_results
        '
        Me.label_department_results.AutoSize = True
        Me.label_department_results.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_department_results.Location = New System.Drawing.Point(34, 347)
        Me.label_department_results.Name = "label_department_results"
        Me.label_department_results.Size = New System.Drawing.Size(107, 15)
        Me.label_department_results.TabIndex = 36
        Me.label_department_results.Text = "Select Department:"
        '
        'label_results
        '
        Me.label_results.AutoSize = True
        Me.label_results.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_results.Location = New System.Drawing.Point(30, 314)
        Me.label_results.Name = "label_results"
        Me.label_results.Size = New System.Drawing.Size(243, 15)
        Me.label_results.TabIndex = 35
        Me.label_results.Text = "Feedback Results by Department Manager"
        '
        'tb_comment
        '
        Me.tb_comment.Location = New System.Drawing.Point(147, 191)
        Me.tb_comment.Multiline = True
        Me.tb_comment.Name = "tb_comment"
        Me.tb_comment.Size = New System.Drawing.Size(348, 60)
        Me.tb_comment.TabIndex = 34
        '
        'label_comments
        '
        Me.label_comments.AutoSize = True
        Me.label_comments.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_comments.Location = New System.Drawing.Point(34, 196)
        Me.label_comments.Name = "label_comments"
        Me.label_comments.Size = New System.Drawing.Size(94, 15)
        Me.label_comments.TabIndex = 33
        Me.label_comments.Text = "Enter Comment:"
        '
        'combo_score
        '
        Me.combo_score.FormattingEnabled = True
        Me.combo_score.Location = New System.Drawing.Point(147, 151)
        Me.combo_score.Name = "combo_score"
        Me.combo_score.Size = New System.Drawing.Size(72, 21)
        Me.combo_score.TabIndex = 32
        '
        'label_score
        '
        Me.label_score.AutoSize = True
        Me.label_score.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_score.Location = New System.Drawing.Point(34, 153)
        Me.label_score.Name = "label_score"
        Me.label_score.Size = New System.Drawing.Size(69, 15)
        Me.label_score.TabIndex = 31
        Me.label_score.Text = "Enter Score:"
        '
        'combo_department
        '
        Me.combo_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_department.FormattingEnabled = True
        Me.combo_department.Location = New System.Drawing.Point(147, 106)
        Me.combo_department.Name = "combo_department"
        Me.combo_department.Size = New System.Drawing.Size(348, 21)
        Me.combo_department.TabIndex = 30
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(380, 66)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(115, 20)
        Me.SubmitButton.TabIndex = 29
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'label_department
        '
        Me.label_department.AutoSize = True
        Me.label_department.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_department.Location = New System.Drawing.Point(34, 108)
        Me.label_department.Name = "label_department"
        Me.label_department.Size = New System.Drawing.Size(107, 15)
        Me.label_department.TabIndex = 28
        Me.label_department.Text = "Select Department:"
        '
        'tb_employeeID
        '
        Me.tb_employeeID.Location = New System.Drawing.Point(147, 63)
        Me.tb_employeeID.Name = "tb_employeeID"
        Me.tb_employeeID.Size = New System.Drawing.Size(139, 20)
        Me.tb_employeeID.TabIndex = 27
        '
        'label_employeeID
        '
        Me.label_employeeID.AutoSize = True
        Me.label_employeeID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_employeeID.Location = New System.Drawing.Point(34, 66)
        Me.label_employeeID.Name = "label_employeeID"
        Me.label_employeeID.Size = New System.Drawing.Size(103, 15)
        Me.label_employeeID.TabIndex = 26
        Me.label_employeeID.Text = "Enter EmployeeID:"
        '
        'label_evaluation
        '
        Me.label_evaluation.AutoSize = True
        Me.label_evaluation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_evaluation.Location = New System.Drawing.Point(30, 20)
        Me.label_evaluation.Name = "label_evaluation"
        Me.label_evaluation.Size = New System.Drawing.Size(307, 15)
        Me.label_evaluation.TabIndex = 25
        Me.label_evaluation.Text = "Employee Manger Evaluation, Please Submit Feedback"
        '
        'employeeFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 596)
        Me.Controls.Add(Me.managerNameLabel)
        Me.Controls.Add(Me.tb_comments_results)
        Me.Controls.Add(Me.label_comments_results)
        Me.Controls.Add(Me.tb_employeescore)
        Me.Controls.Add(Me.label_employeescore)
        Me.Controls.Add(Me.combo_employee)
        Me.Controls.Add(Me.label_employee_results)
        Me.Controls.Add(Me.tb_average)
        Me.Controls.Add(Me.label_average)
        Me.Controls.Add(Me.tb_responses)
        Me.Controls.Add(Me.label_responses)
        Me.Controls.Add(Me.combo_department_results)
        Me.Controls.Add(Me.label_department_results)
        Me.Controls.Add(Me.label_results)
        Me.Controls.Add(Me.tb_comment)
        Me.Controls.Add(Me.label_comments)
        Me.Controls.Add(Me.combo_score)
        Me.Controls.Add(Me.label_score)
        Me.Controls.Add(Me.combo_department)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.label_department)
        Me.Controls.Add(Me.tb_employeeID)
        Me.Controls.Add(Me.label_employeeID)
        Me.Controls.Add(Me.label_evaluation)
        Me.Name = "employeeFeedback"
        Me.Text = "Employee Feedback App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents managerNameLabel As System.Windows.Forms.Label
    Friend WithEvents tb_comments_results As System.Windows.Forms.TextBox
    Friend WithEvents label_comments_results As System.Windows.Forms.Label
    Friend WithEvents tb_employeescore As System.Windows.Forms.TextBox
    Friend WithEvents label_employeescore As System.Windows.Forms.Label
    Friend WithEvents combo_employee As System.Windows.Forms.ComboBox
    Friend WithEvents label_employee_results As System.Windows.Forms.Label
    Friend WithEvents tb_average As System.Windows.Forms.TextBox
    Friend WithEvents label_average As System.Windows.Forms.Label
    Friend WithEvents tb_responses As System.Windows.Forms.TextBox
    Friend WithEvents label_responses As System.Windows.Forms.Label
    Friend WithEvents combo_department_results As System.Windows.Forms.ComboBox
    Friend WithEvents label_department_results As System.Windows.Forms.Label
    Friend WithEvents label_results As System.Windows.Forms.Label
    Friend WithEvents tb_comment As System.Windows.Forms.TextBox
    Friend WithEvents label_comments As System.Windows.Forms.Label
    Friend WithEvents combo_score As System.Windows.Forms.ComboBox
    Friend WithEvents label_score As System.Windows.Forms.Label
    Friend WithEvents combo_department As System.Windows.Forms.ComboBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents label_department As System.Windows.Forms.Label
    Friend WithEvents tb_employeeID As System.Windows.Forms.TextBox
    Friend WithEvents label_employeeID As System.Windows.Forms.Label
    Friend WithEvents label_evaluation As System.Windows.Forms.Label

End Class
