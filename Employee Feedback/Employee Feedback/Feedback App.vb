Imports System.IO

Public Class employeeFeedback

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

        ' disables employee combo by default
        combo_employee.Enabled = False

        ' clearing out two textboxes
        tb_responses.Clear()
        tb_average.Clear()

    End Sub




End Class
