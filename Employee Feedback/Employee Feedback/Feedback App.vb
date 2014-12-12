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

        ' Creating an array for displaying the departments
        Dim deptName As String()

        For Each line In File.ReadAllLines("departments.txt")
            deptName = line.Split(ControlChars.Tab)
            combo_department.Items.Add(deptName(0))
            combo_department_results.Items.Add(deptName(0))
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
    ' 
    Function Check_EmployeeID(ByVal empID As Integer) As Integer

        Dim check_employeeID_query = From line In File.ReadAllLines("employees.txt")
                            Let employeeInformation As String() = line.Split(ControlChars.Tab)
                            Where Convert.ToInt32(employeeInformation(0) = empID)
                        Select line

        Return check_employeeID_query.Count


    End Function








End Class
