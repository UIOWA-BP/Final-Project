Imports System.IO

Public Class employeeFeedback


    ' this is handled when the form loads
    Private Sub employeeFeedback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SubmitButton.Enabled = False
        For i = 1 To 10
            ' populate combobox with values 1-10
            combo_score.Items.Add(i)
        Next

        ' setting default value of combobox to 1
        combo_score.Text = 1

        ' setting default value of combobox to Select Employee
        combo_employee.Text = "Select Employee"

        ' display department names in the two comboboxes
        Dim departmentname As String()

        For Each line In File.ReadAllLines("departments.txt")
            departmentname = line.Split(ControlChars.Tab)
            combo_department.Items.Add(departmentname(0))
            combo_department_results.Items.Add(departmentname(0))
        Next

        ' inserts the text into the combo boxes
        combo_department.Text = File.ReadAllLines("departments.txt")(0).Split(ControlChars.Tab)(0)
        combo_department_results.Text = String.Empty

        ' disables employee combo by default
        combo_employee.Enabled = False

        ' clearing out two textboxes
        tb_responses.Clear()
        tb_average.Clear()

        ' we need to read employee feedback



    End Sub



    ' this handles when the combobox for department results is changed
    Private Sub combo_department_results_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_department_results.SelectedIndexChanged

        ' clearing out the feedback results 
        ' can use String.Empty as well
        tb_employeescore.Text = ""
        tb_comment.Text = ""
        tb_responses.Text = ""
        tb_comments_results.Text = ""

        Dim manager As String
        Dim score As Integer = 0
        Dim average As Integer = 0

        manager = Check_Manager(combo_department_results.Text)
        managerNameLabel.Text = manager


    End Sub


    ' below we can use LINQ or StreamWriter/Reader??

    ' this handles checking the employeeID from employees.txt
    ' 
    Function Check_EmployeeID(ByVal empID As Integer) As Boolean

        Dim check_employeeID_query = From line In File.ReadAllLines("employees.txt")
                            Let employeeInformation As String() = line.Split(ControlChars.Tab)
                            Where Convert.ToInt32(employeeInformation(0) = empID)
                        Select line

        If check_employeeID_query.Count = 0 Then
            Return False
        Else
            Return True
        End If


    End Function

    'Returns a true/false statement on if the employee has already submitted a feedback
    Function feedback_Completed(ByVal empID As Integer) As Boolean

        Dim check_employeeID_query = From line In File.ReadAllLines("feedback.txt")
                           Let employeeInformation As String() = line.Split(ControlChars.Tab)
                           Where Convert.ToInt32(employeeInformation(0) = empID)
                       Select line

        If check_employeeID_query.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    ' this handles checking the manager name based on department name
    Function Check_Manager(ByVal dept As String) As String

        Dim check_Manager_query = From line In File.ReadAllLines("departments.txt")
                            Let checkManager As String() = line.Split(ControlChars.Tab)
                            Where checkManager(0) = dept
                        Select line

        Dim manager_record As String() = check_Manager_query(0).Split(ControlChars.Tab)
        Return manager_record(1)

    End Function

    ' this handles checking the employee name based on employeeID
    Function getName(ByVal empID As String) As String

        Dim check_Emp_query = From line In File.ReadAllLines("employees.txt")
                            Let checkEmp As String() = line.Split(ControlChars.Tab)
                            Where checkEmp(0) = empID
                        Select line

        Dim emp_record As String() = check_Emp_query(0).Split(ControlChars.Tab)
        Return emp_record(1)

    End Function

    

    'Varify that employee has the correct department 
    Function verifyDept(ByVal empID As String) As String

        Dim check_Emp_query = From line In File.ReadAllLines("employees.txt")
                    Let checkEmp As String() = line.Split(ControlChars.Tab)
                    Where checkEmp(0) = empID
                Select line

        Dim emp_record As String() = check_Emp_query(0).Split(ControlChars.Tab)
        Return emp_record(2)

    End Function

    Sub reset()

        tb_employeeID.Text = String.Empty
        combo_department.SelectedIndex = 0
        combo_score.SelectedIndex = 0
        tb_comment.Text = String.Empty
        tb_employeeID.Focus()


    End Sub
    ' this handles when the submit button is clicked
    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click

        ' declaring variables
        Dim input_employeeID As Integer
        Dim input_employeeName As String
        Dim input_managerName As String
        Dim input_departmentName As String
        Dim input_managerScore As Integer
        Dim input_employeeComment As String
        Dim output_feedback As feedback
        Dim input_enter_Score As String



        ' setting employeeID equal to value of the textbox
        input_employeeID = Convert.ToInt32(Val(tb_employeeID.Text))
        input_departmentName = combo_department.Text
        input_enter_Score = Convert.ToInt32(Val(combo_score.Text))
        input_employeeComment = tb_comment.Text

        'Checks to see if all the fields are filled out
        If input_employeeID = 0 Or input_employeeComment = String.Empty Then
            MsgBox("Please make sure the EmployeeID and Comments are filled out!")
            Exit Sub
        End If

        'Checks to see if the emp id is a valid employee
        If Check_EmployeeID(input_employeeID) = False Then
            MsgBox("Please enter a vaild employeeID!")
            tb_employeeID.Clear()
            tb_employeeID.Focus()
            Exit Sub
        End If


        'Checks to see if the employee has already filled out a feedback form
        If feedback_Completed(input_employeeID) = True Then
            MsgBox("It shows that you have already filled out a feedback form. If you haven't contact your manager.")
            Exit Sub
        End If


        If verifyDept(tb_employeeID.Text) <> combo_department.Text Then
            MsgBox("Please only submit feedback on your own department!")
            Exit Sub
        End If

        Dim output As StreamWriter
        output = New StreamWriter("feedback.txt", True)

        output.Write(tb_employeeID.Text & ControlChars.Tab)
        output.Write(getName(tb_employeeID.Text) & ControlChars.Tab)
        output.Write(Check_Manager(combo_department.Text) & ControlChars.Tab)
        output.Write(input_enter_Score & ControlChars.Tab)
        output.Write(input_employeeComment & ControlChars.CrLf)
        output.Close()
        MsgBox("Thank you for your feedback!")
        reset()




    End Sub




End Class
