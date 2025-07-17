Public Class Form1

    Private allStudents As New Collection
    Private currStudent As Student


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtIdNumber.Text.Length = 0 Then
            MessageBox.Show("Id number cannot be blank", "Error")
            Return
        End If
        If txtLastName.Text.Length = 0 Then
            MessageBox.Show("Last Name cannot be black", "Error")
            Return
        End If

        Try
            currStudent = New Student(txtIdNumber.Text, txtLastName.Text, CDbl(txtAverage.Text))
            allStudents.Add(currStudent, currStudent.IdNumber)
            btnCourseInfo.Enabled = True
        Catch ex As InvalidCastException
            MessageBox.Show("Test average must be a number", "Error")
        Catch ex As ArgumentException
            MessageBox.Show("Cannot add duplicate student Id to the collection", "Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try

    End Sub

    Private Sub btnCourseInfo_Click(sender As Object, e As EventArgs) Handles btnCourseInfo.Click
        Form2.CurrStudent = currStudent
        Form2.ShowDialog()
    End Sub
End Class
