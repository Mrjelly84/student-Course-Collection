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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnClose = New Button()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        txtCourseNumber = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtGrade = New TextBox()
        btnSave = New Button()
        txtCredits = New TextBox()
        lstCourses = New ListBox()
        lblStudent = New Label()
        Label4 = New Label()
        errProvider = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(errProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(19, 250)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(88, 29)
        btnClose.TabIndex = 12
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(541, 43)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 17
        Label5.Text = "Existing Courses:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtCourseNumber)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtGrade)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(txtCredits)
        GroupBox1.Location = New Point(19, 65)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(500, 168)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Course Info"
        ' 
        ' txtCourseNumber
        ' 
        txtCourseNumber.Location = New Point(169, 38)
        txtCourseNumber.Margin = New Padding(5, 5, 5, 5)
        txtCourseNumber.Name = "txtCourseNumber"
        txtCourseNumber.Size = New Size(110, 23)
        txtCourseNumber.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 43)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Course number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(306, 43)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 1
        Label2.Text = "Credits"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 81)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "Grade"
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(169, 76)
        txtGrade.Margin = New Padding(5, 5, 5, 5)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(61, 23)
        txtGrade.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(342, 81)
        btnSave.Margin = New Padding(5, 5, 5, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(85, 32)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtCredits
        ' 
        txtCredits.Location = New Point(376, 36)
        txtCredits.Margin = New Padding(5, 5, 5, 5)
        txtCredits.Name = "txtCredits"
        txtCredits.Size = New Size(51, 23)
        txtCredits.TabIndex = 1
        ' 
        ' lstCourses
        ' 
        lstCourses.FormattingEnabled = True
        lstCourses.Location = New Point(541, 65)
        lstCourses.Margin = New Padding(4, 3, 4, 3)
        lstCourses.Name = "lstCourses"
        lstCourses.Size = New Size(243, 169)
        lstCourses.TabIndex = 15
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudent.Location = New Point(135, 23)
        lblStudent.Margin = New Padding(5, 0, 5, 0)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(93, 17)
        lblStudent.TabIndex = 14
        lblStudent.Text = "(lblStudent)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 22)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 13
        Label4.Text = "Student name:"
        ' 
        ' errProvider
        ' 
        errProvider.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(821, 315)
        Controls.Add(btnClose)
        Controls.Add(Label5)
        Controls.Add(GroupBox1)
        Controls.Add(lstCourses)
        Controls.Add(lblStudent)
        Controls.Add(Label4)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "courses"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(errProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCourseNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents lblStudent As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents errProvider As ErrorProvider
End Class
