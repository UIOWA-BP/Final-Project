Public Class feedback

    ' declaring the variables that the employee inputs
    Private EmployeeID As Integer
    Private EmployeeName As String
    Private ManagerName As String
    Private ManagerScore As Integer
    Private EmployeeComment As String


    Public Sub New(ByVal EmployeeID As Integer, ByVal EmployeeName As String, ByVal ManagerName As String, ByVal ManagerScore As Integer, ByVal EmployeeComment As String)

        ' invoking accessors 
        employID = EmployeeID
        employName = EmployeeName
        manageName = ManagerName
        manageScore = ManagerScore
        employComment = EmployeeComment

    End Sub


    Sub New()
        ' complete the member initialization process 
    End Sub


    ' Property for EmployeeID
    Public Property employID() As Integer

        Get
            Return EmployeeID
        End Get
        Set(ByVal value As Integer)
            EmployeeID = value
        End Set

    End Property


    ' Property for EmployeeName
    Public Property employName() As String

        Get
            Return EmployeeName
        End Get
        Set(ByVal value As String)
            EmployeeName = value
        End Set

    End Property


    ' Property for ManagerName
    Public Property manageName() As String

        Get
            Return ManagerName
        End Get
        Set(ByVal value As String)
            ManagerName = value
        End Set

    End Property


    ' Property for ManagerScore
    Public Property manageScore() As Integer
        Get
            Return ManagerScore
        End Get
        Set(ByVal value As Integer)
            managerScore = value
        End Set
    End Property


    ' Property for EmployeeComments
    Public Property employComment() As String
        Get
            Return EmployeeComment
        End Get
        Set(ByVal value As String)
            EmployeeComment = value
        End Set

    End Property



End Class
