Public Class Student
    Public Property IdNumber As String
    Public Property LastName As String
    Private testAvg As Double
    Public Property Courses As Dictionary(Of String, Course)

    Public Property TestAverage As Double
        Get
            Return testAvg
        End Get
        Set(value As Double)
            If value >= 0.0 And value <= 100.0 Then
                testAvg = value
            Else
                MessageBox.Show("Invalid test Average", "Error")
            End If
        End Set
    End Property

    Public Sub New(id As String, lName As String, avg As Double)
        IdNumber = id
        LastName = lName
        TestAverage = avg
        Courses = New Dictionary(Of String, Course)
    End Sub

    Public Overrides Function ToString() As String
        Return $"{IdNumber}, {LastName}, Test Average = {TestAverage.ToString("n2")}"
    End Function
End Class
