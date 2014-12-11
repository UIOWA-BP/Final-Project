Imports System.IO

Public Class employeeFeedback

    ' this is handled when the form loads
    Private Sub employeeFeedback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        ' setting the default text for the two comboboxes
        combo_department.Text = File.ReadAllLines("departments.txt")(0).Split(ControlChars.Tab)(0)
        combo_department_results.Text = ""

        ' INSERT READING THE FEEDBACK DOCUMENT HERE 

        ' disables employee combo by default
        combo_employee.Enabled = False

        ' clearing out two textboxes
        tb_responses.Clear()
        tb_average.Clear()

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

        ' setting employeeID equal to value of the textbox
        input_employeeID = Convert.ToInt32(Val(tb_employeeID.Text))

    End Sub

    ' this handles when the combobox for department results is changed
    Private Sub combo_department_results_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_department_results.SelectedIndexChanged

        ' clearing out the feedback results 
        ' can use String.Empty as well
        tb_employeescore.Text = ""
        tb_comment.Text = ""
        tb_responses.Text = ""
        tb_comments_results.Text = ""

    End Sub


    ' below we can use LINQ or StreamWriter/Reader??

    ' this handles checking the employeeID from employees.txt
    Function Check_EmployeeID(ByVal empID As Integer) As Integer

    End Function

    ' this handles checking the managers name from departments.txt
    Function Check_ManagerDept(ByVal managerDept As Integer) As Integer

    End Function


    ' this handles checking the employees department from employees.txt
    Function Check_EmployeeDept(ByRef employeeDept As String) As String

    End Function









End Class
