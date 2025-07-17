<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtLastName = New TextBox()
        txtAverage = New TextBox()
        txtFindId = New TextBox()
        txtIdNumber = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnFind = New Button()
        btnView = New Button()
        btnAdd = New Button()
        btnCourseInfo = New Button()
        lstStudents = New ListBox()
        SuspendLayout()
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(88, 51)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(100, 23)
        txtLastName.TabIndex = 0
        ' 
        ' txtAverage
        ' 
        txtAverage.Location = New Point(88, 105)
        txtAverage.Name = "txtAverage"
        txtAverage.Size = New Size(64, 23)
        txtAverage.TabIndex = 1
        ' 
        ' txtFindId
        ' 
        txtFindId.Location = New Point(28, 300)
        txtFindId.Name = "txtFindId"
        txtFindId.Size = New Size(80, 23)
        txtFindId.TabIndex = 2
        ' 
        ' txtIdNumber
        ' 
        txtIdNumber.Location = New Point(88, 10)
        txtIdNumber.Name = "txtIdNumber"
        txtIdNumber.Size = New Size(75, 23)
        txtIdNumber.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 5
        Label1.Text = "Student ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 6
        Label2.Text = "Last name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 7
        Label3.Text = "Test average:"
        ' 
        ' btnFind
        ' 
        btnFind.Location = New Point(32, 262)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(75, 23)
        btnFind.TabIndex = 8
        btnFind.Text = "Find by ID"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(33, 204)
        btnView.Name = "btnView"
        btnView.Size = New Size(75, 23)
        btnView.TabIndex = 9
        btnView.Text = "View All"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(331, 32)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(206, 23)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add to Collection"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnCourseInfo
        ' 
        btnCourseInfo.Location = New Point(331, 81)
        btnCourseInfo.Name = "btnCourseInfo"
        btnCourseInfo.Size = New Size(206, 23)
        btnCourseInfo.TabIndex = 11
        btnCourseInfo.Text = "Course Information"
        btnCourseInfo.UseVisualStyleBackColor = True
        ' 
        ' lstStudents
        ' 
        lstStudents.FormattingEnabled = True
        lstStudents.Location = New Point(175, 165)
        lstStudents.Name = "lstStudents"
        lstStudents.Size = New Size(362, 169)
        lstStudents.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 368)
        Controls.Add(lstStudents)
        Controls.Add(btnCourseInfo)
        Controls.Add(btnAdd)
        Controls.Add(btnView)
        Controls.Add(btnFind)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtIdNumber)
        Controls.Add(txtFindId)
        Controls.Add(txtAverage)
        Controls.Add(txtLastName)
        Name = "Form1"
        Text = "Student Course Collection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtFindId As TextBox
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCourseInfo As Button
    Friend WithEvents lstStudents As ListBox

End Class
