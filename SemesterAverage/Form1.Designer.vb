<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemesterAverageForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbCourseOne = New System.Windows.Forms.Label()
        Me.lbCourseTwo = New System.Windows.Forms.Label()
        Me.lbCourseThree = New System.Windows.Forms.Label()
        Me.lbCourseFour = New System.Windows.Forms.Label()
        Me.lbCourseFive = New System.Windows.Forms.Label()
        Me.lbCourseSix = New System.Windows.Forms.Label()
        Me.tbCourseOneInput = New System.Windows.Forms.TextBox()
        Me.tbCourseTwoInput = New System.Windows.Forms.TextBox()
        Me.tbCourseThreeInput = New System.Windows.Forms.TextBox()
        Me.tbCourseFourInput = New System.Windows.Forms.TextBox()
        Me.tbCourseFiveInput = New System.Windows.Forms.TextBox()
        Me.tbCourseSixInput = New System.Windows.Forms.TextBox()
        Me.lbCourseOneGrade = New System.Windows.Forms.Label()
        Me.lbCourseTwoGrade = New System.Windows.Forms.Label()
        Me.lbCourseThreeGrade = New System.Windows.Forms.Label()
        Me.lbCourseFourGrade = New System.Windows.Forms.Label()
        Me.lbCourseFiveGrade = New System.Windows.Forms.Label()
        Me.lbCourseSixGrade = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.lbSemesterAverage = New System.Windows.Forms.Label()
        Me.lbSemesterGrade = New System.Windows.Forms.Label()
        Me.lbErrorMessage = New System.Windows.Forms.Label()
        Me.tipSemesterAverage = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(18, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.tipSemesterAverage.SetToolTip(Me.btnCalculate, "Click this button to calculate the semester average of all your courses.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(121, 326)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.tipSemesterAverage.SetToolTip(Me.btnReset, "Click this button to reset the entire form and enter new data.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(212, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.tipSemesterAverage.SetToolTip(Me.btnExit, "Click this button to exit the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbCourseOne
        '
        Me.lbCourseOne.Location = New System.Drawing.Point(48, 9)
        Me.lbCourseOne.Name = "lbCourseOne"
        Me.lbCourseOne.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseOne.TabIndex = 0
        Me.lbCourseOne.Text = "Course &1:"
        Me.lbCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseTwo
        '
        Me.lbCourseTwo.Location = New System.Drawing.Point(48, 32)
        Me.lbCourseTwo.Name = "lbCourseTwo"
        Me.lbCourseTwo.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseTwo.TabIndex = 1
        Me.lbCourseTwo.Text = "Course &2:"
        Me.lbCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseThree
        '
        Me.lbCourseThree.Location = New System.Drawing.Point(48, 55)
        Me.lbCourseThree.Name = "lbCourseThree"
        Me.lbCourseThree.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseThree.TabIndex = 2
        Me.lbCourseThree.Text = "Course &3:"
        Me.lbCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseFour
        '
        Me.lbCourseFour.Location = New System.Drawing.Point(48, 80)
        Me.lbCourseFour.Name = "lbCourseFour"
        Me.lbCourseFour.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseFour.TabIndex = 3
        Me.lbCourseFour.Text = "Course &4:"
        Me.lbCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseFive
        '
        Me.lbCourseFive.Location = New System.Drawing.Point(48, 107)
        Me.lbCourseFive.Name = "lbCourseFive"
        Me.lbCourseFive.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseFive.TabIndex = 4
        Me.lbCourseFive.Text = "Course &5:"
        Me.lbCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourseSix
        '
        Me.lbCourseSix.Location = New System.Drawing.Point(48, 131)
        Me.lbCourseSix.Name = "lbCourseSix"
        Me.lbCourseSix.Size = New System.Drawing.Size(52, 13)
        Me.lbCourseSix.TabIndex = 5
        Me.lbCourseSix.Text = "Course &6:"
        Me.lbCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbCourseOneInput
        '
        Me.tbCourseOneInput.Location = New System.Drawing.Point(106, 5)
        Me.tbCourseOneInput.Name = "tbCourseOneInput"
        Me.tbCourseOneInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCourseOneInput.TabIndex = 7
        Me.tipSemesterAverage.SetToolTip(Me.tbCourseOneInput, "Input final mark for course one.")
        '
        'tbCourseTwoInput
        '
        Me.tbCourseTwoInput.Location = New System.Drawing.Point(106, 32)
        Me.tbCourseTwoInput.Name = "tbCourseTwoInput"
        Me.tbCourseTwoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCourseTwoInput.TabIndex = 8
        Me.tipSemesterAverage.SetToolTip(Me.tbCourseTwoInput, "Input final mark for course two.")
        '
        'tbCourseThreeInput
        '
        Me.tbCourseThreeInput.Location = New System.Drawing.Point(106, 56)
        Me.tbCourseThreeInput.Name = "tbCourseThreeInput"
        Me.tbCourseThreeInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCourseThreeInput.TabIndex = 9
        Me.tipSemesterAverage.SetToolTip(Me.tbCourseThreeInput, "Input final mark for course three.")
        '
        'tbCourseFourInput
        '
        Me.tbCourseFourInput.Location = New System.Drawing.Point(106, 81)
        Me.tbCourseFourInput.Name = "tbCourseFourInput"
        Me.tbCourseFourInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCourseFourInput.TabIndex = 10
        Me.tipSemesterAverage.SetToolTip(Me.tbCourseFourInput, "Input final mark for course four.")
        '
        'tbCourseFiveInput
        '
        Me.tbCourseFiveInput.Location = New System.Drawing.Point(106, 107)
        Me.tbCourseFiveInput.Name = "tbCourseFiveInput"
        Me.tbCourseFiveInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCourseFiveInput.TabIndex = 11
        Me.tipSemesterAverage.SetToolTip(Me.tbCourseFiveInput, "Input final mark for course five.")
        '
        'tbCourseSixInput
        '
        Me.tbCourseSixInput.Location = New System.Drawing.Point(106, 131)
        Me.tbCourseSixInput.Name = "tbCourseSixInput"
        Me.tbCourseSixInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCourseSixInput.TabIndex = 12
        Me.tipSemesterAverage.SetToolTip(Me.tbCourseSixInput, "Input final mark for course six.")
        '
        'lbCourseOneGrade
        '
        Me.lbCourseOneGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseOneGrade.Location = New System.Drawing.Point(213, 7)
        Me.lbCourseOneGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseOneGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseOneGrade.Name = "lbCourseOneGrade"
        Me.lbCourseOneGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbCourseOneGrade.TabIndex = 14
        Me.lbCourseOneGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbCourseOneGrade, "Displays letter grade for course one.")
        '
        'lbCourseTwoGrade
        '
        Me.lbCourseTwoGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseTwoGrade.Location = New System.Drawing.Point(213, 30)
        Me.lbCourseTwoGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseTwoGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseTwoGrade.Name = "lbCourseTwoGrade"
        Me.lbCourseTwoGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbCourseTwoGrade.TabIndex = 15
        Me.lbCourseTwoGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbCourseTwoGrade, "Displays letter grade for course two.")
        '
        'lbCourseThreeGrade
        '
        Me.lbCourseThreeGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseThreeGrade.Location = New System.Drawing.Point(212, 54)
        Me.lbCourseThreeGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseThreeGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseThreeGrade.Name = "lbCourseThreeGrade"
        Me.lbCourseThreeGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbCourseThreeGrade.TabIndex = 16
        Me.lbCourseThreeGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbCourseThreeGrade, "Displays letter grade for course three.")
        '
        'lbCourseFourGrade
        '
        Me.lbCourseFourGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseFourGrade.Location = New System.Drawing.Point(212, 80)
        Me.lbCourseFourGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseFourGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseFourGrade.Name = "lbCourseFourGrade"
        Me.lbCourseFourGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbCourseFourGrade.TabIndex = 17
        Me.lbCourseFourGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbCourseFourGrade, "Displays letter grade for course four.")
        '
        'lbCourseFiveGrade
        '
        Me.lbCourseFiveGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseFiveGrade.Location = New System.Drawing.Point(212, 105)
        Me.lbCourseFiveGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseFiveGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseFiveGrade.Name = "lbCourseFiveGrade"
        Me.lbCourseFiveGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbCourseFiveGrade.TabIndex = 18
        Me.lbCourseFiveGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbCourseFiveGrade, "Displays letter grade for course five.")
        '
        'lbCourseSixGrade
        '
        Me.lbCourseSixGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourseSixGrade.Location = New System.Drawing.Point(212, 131)
        Me.lbCourseSixGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseSixGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbCourseSixGrade.Name = "lbCourseSixGrade"
        Me.lbCourseSixGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbCourseSixGrade.TabIndex = 19
        Me.lbCourseSixGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbCourseSixGrade, "Displays letter grade for course six.")
        '
        'lbSemester
        '
        Me.lbSemester.Location = New System.Drawing.Point(46, 162)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(54, 13)
        Me.lbSemester.TabIndex = 6
        Me.lbSemester.Text = "&Semester:"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSemesterAverage
        '
        Me.lbSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterAverage.Location = New System.Drawing.Point(106, 162)
        Me.lbSemesterAverage.MaximumSize = New System.Drawing.Size(90, 15)
        Me.lbSemesterAverage.MinimumSize = New System.Drawing.Size(90, 15)
        Me.lbSemesterAverage.Name = "lbSemesterAverage"
        Me.lbSemesterAverage.Size = New System.Drawing.Size(90, 15)
        Me.lbSemesterAverage.TabIndex = 13
        Me.lbSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbSemesterAverage, "Displays average for all six courses this semester.")
        '
        'lbSemesterGrade
        '
        Me.lbSemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterGrade.Location = New System.Drawing.Point(212, 162)
        Me.lbSemesterGrade.MaximumSize = New System.Drawing.Size(80, 15)
        Me.lbSemesterGrade.MinimumSize = New System.Drawing.Size(80, 15)
        Me.lbSemesterGrade.Name = "lbSemesterGrade"
        Me.lbSemesterGrade.Size = New System.Drawing.Size(80, 15)
        Me.lbSemesterGrade.TabIndex = 20
        Me.lbSemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbSemesterGrade, "Displays letter grade for the average of this semester.")
        '
        'lbErrorMessage
        '
        Me.lbErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbErrorMessage.Location = New System.Drawing.Point(12, 186)
        Me.lbErrorMessage.MaximumSize = New System.Drawing.Size(275, 125)
        Me.lbErrorMessage.MinimumSize = New System.Drawing.Size(275, 125)
        Me.lbErrorMessage.Name = "lbErrorMessage"
        Me.lbErrorMessage.Size = New System.Drawing.Size(275, 125)
        Me.lbErrorMessage.TabIndex = 21
        Me.lbErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tipSemesterAverage.SetToolTip(Me.lbErrorMessage, "Displays error messages when there are any problems with input.")
        '
        'SemesterAverageForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(299, 361)
        Me.Controls.Add(Me.lbErrorMessage)
        Me.Controls.Add(Me.lbSemesterGrade)
        Me.Controls.Add(Me.lbSemesterAverage)
        Me.Controls.Add(Me.lbSemester)
        Me.Controls.Add(Me.lbCourseSixGrade)
        Me.Controls.Add(Me.lbCourseFiveGrade)
        Me.Controls.Add(Me.lbCourseFourGrade)
        Me.Controls.Add(Me.lbCourseThreeGrade)
        Me.Controls.Add(Me.lbCourseTwoGrade)
        Me.Controls.Add(Me.lbCourseOneGrade)
        Me.Controls.Add(Me.tbCourseSixInput)
        Me.Controls.Add(Me.tbCourseFiveInput)
        Me.Controls.Add(Me.tbCourseFourInput)
        Me.Controls.Add(Me.tbCourseThreeInput)
        Me.Controls.Add(Me.tbCourseTwoInput)
        Me.Controls.Add(Me.tbCourseOneInput)
        Me.Controls.Add(Me.lbCourseSix)
        Me.Controls.Add(Me.lbCourseFive)
        Me.Controls.Add(Me.lbCourseFour)
        Me.Controls.Add(Me.lbCourseThree)
        Me.Controls.Add(Me.lbCourseTwo)
        Me.Controls.Add(Me.lbCourseOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.MaximumSize = New System.Drawing.Size(315, 400)
        Me.MinimumSize = New System.Drawing.Size(315, 400)
        Me.Name = "SemesterAverageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbCourseOne As Label
    Friend WithEvents lbCourseTwo As Label
    Friend WithEvents lbCourseThree As Label
    Friend WithEvents lbCourseFour As Label
    Friend WithEvents lbCourseFive As Label
    Friend WithEvents lbCourseSix As Label
    Friend WithEvents tbCourseOneInput As TextBox
    Friend WithEvents tbCourseTwoInput As TextBox
    Friend WithEvents tbCourseThreeInput As TextBox
    Friend WithEvents tbCourseFourInput As TextBox
    Friend WithEvents tbCourseFiveInput As TextBox
    Friend WithEvents tbCourseSixInput As TextBox
    Friend WithEvents lbCourseOneGrade As Label
    Friend WithEvents lbCourseTwoGrade As Label
    Friend WithEvents lbCourseThreeGrade As Label
    Friend WithEvents lbCourseFourGrade As Label
    Friend WithEvents lbCourseFiveGrade As Label
    Friend WithEvents lbCourseSixGrade As Label
    Friend WithEvents lbSemester As Label
    Friend WithEvents lbSemesterAverage As Label
    Friend WithEvents lbSemesterGrade As Label
    Friend WithEvents lbErrorMessage As Label
    Friend WithEvents tipSemesterAverage As ToolTip
End Class
