Public Class Form1

    Private AllStudents As New Collection
    Private currStudent As Student

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtIdNumber.Text.Length = 0 Then
            MessageBox.Show("Id number cannot be blank", "Error")
            Return
        End If

        If txtLastName.Text.Length = 0 Then
            MessageBox.Show("Last Name cannot be blank", "Error")
            Return
        End If

        Try
            currStudent = New Student(txtIdNumber.Text, txtLastName.Text, CDbl(txtAverage.Text))
            AllStudents.Add(currStudent, currStudent.IdNumber)
            btnCourseInfo.Enabled = True
        Catch ex As InvalidCastException
            MessageBox.Show("Test average must be a number", "Error")
        Catch ex As ArgumentException
            MessageBox.Show("Cannot add duplicate student ID to the collection", "Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub btnCourseInfo_Click(sender As Object, e As EventArgs) Handles btnCourseInfo.Click
        Form2.CurrStudent = currStudent
        Form2.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        lstStudents.Items.Clear()
        For Each stu As Student In AllStudents
            lstStudents.Items.Add(stu.ToString())
        Next
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'The Item property throws an exception if it is unable to 
        'find an item in the collection. Therefore, we call the Contains method first.
        lstStudents.Items.Clear()
        If AllStudents.Contains(txtFindId.Text) Then
            currStudent = CType(AllStudents.Item(txtFindId.Text), Student)
            lstStudents.Items.Add(currStudent.ToString())
            btnCourseInfo.Enabled = True

            txtIdNumber.Text = currStudent.IdNumber
            txtLastName.Text = currStudent.LastName
            txtAverage.Text = currStudent.TestAverage.ToString("n2")
        Else
            lstStudents.Items.Add("Student ID was not found")
        End If
    End Sub
End Class
