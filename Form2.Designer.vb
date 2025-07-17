<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Me.txtCredits = New TextBox()
        Button2 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnClose = New Button()
        Label1 = New Label()
        Label5 = New Label()
        txtCourseNumber = New TextBox()
        Me.txtGrade = New TextBox()
        lstCourses = New ListBox()
        lblStudent = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Me.txtGrade)
        GroupBox1.Controls.Add(txtCourseNumber)
        GroupBox1.Controls.Add(Me.txtCredits)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(45, 43)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(432, 156)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Course Info"
        ' 
        ' txtCredits
        ' 
        Me.txtCredits.Location = New Point(293, 34)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New Size(100, 23)
        Me.txtCredits.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(286, 70)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(243, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 2
        Label4.Text = "Credits"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 1
        Label3.Text = "Grade"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 0
        Label2.Text = "Course number"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(58, 219)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 3
        Label1.Text = "Student name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(524, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 4
        Label5.Text = "Existing Courses:"
        ' 
        ' txtCourseNumber
        ' 
        txtCourseNumber.Location = New Point(117, 34)
        txtCourseNumber.Name = "txtCourseNumber"
        txtCourseNumber.Size = New Size(100, 23)
        txtCourseNumber.TabIndex = 5
        ' 
        ' txtGrade
        ' 
        Me.txtGrade.Location = New Point(117, 81)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New Size(52, 23)
        Me.txtGrade.TabIndex = 6
        ' 
        ' lstCourses
        ' 
        lstCourses.FormattingEnabled = True
        lstCourses.Location = New Point(524, 55)
        lstCourses.Name = "lstCourses"
        lstCourses.Size = New Size(255, 169)
        lstCourses.TabIndex = 5
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudent.Location = New Point(139, 6)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(73, 15)
        lblStudent.TabIndex = 6
        lblStudent.Text = "(lblStudent)"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 247)
        Controls.Add(lblStudent)
        Controls.Add(lstCourses)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(btnClose)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Course Information Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtCourseNumber As TextBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents lblStudent As Label
End Class
