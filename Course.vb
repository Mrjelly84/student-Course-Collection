Public Class Course
    Public Property Id As String
    Public Property Credits As Integer
    Public Property Grade As Double

    Public Sub New(courseId As String, courseCredits As Integer, courseGrade As Double)
        Id = courseId
        Credits = courseCredits
        Grade = courseGrade
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Id}  {Credits}  Grade: {Grade}"
    End Function

End Class
