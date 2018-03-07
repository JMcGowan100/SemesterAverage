'Author: Jaylan McGowan
'Date: February 20, 2018
'File Name: 
'Project Name: Semester Average
'Description: 

Public Class SemesterAverageForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim courses(5) As Double
        Dim validNumberOne As Double
        Dim validNumberTwo As Double
        Dim validNumberThree As Double
        Dim validNumberFour As Double
        Dim validNumberFive As Double
        Dim validNumberSix As Double

        courses(0) = tbCourseOneInput.Text
        courses(1) = tbCourseTwoInput.Text
        courses(2) = tbCourseThreeInput.Text
        courses(3) = tbCourseFourInput.Text
        courses(4) = tbCourseFiveInput.Text
        courses(5) = tbCourseSixInput.Text

        validNumberOne = InputVariable(courses(0))


    End Sub

    Private Function InputVariable(numberInput As Double) As Double



    End Function

    Private Function LetterGrade(numberInput As Double) As Double

        Dim grade As String

        If numberInput >= 90 And numberInput <= 100 Then
            grade = "A+"
        ElseIf numberInput >= 85 And numberInput <= 89 Then
            grade = "A"
        ElseIf numberInput >= 80 And numberInput <= 84 Then
            grade = "A-"
        ElseIf numberInput >= 77 And numberInput <= 79 Then
            grade = "B+"
        ElseIf numberInput >= 73 And numberInput <= 76 Then
            grade = "B"
        ElseIf numberInput >= 70 And numberInput <= 72 Then
            grade = "B-"
        ElseIf numberInput >= 67 And numberInput <= 69 Then
            grade = "C+"
        ElseIf numberInput >= 63 And numberInput <= 66 Then
            grade = "C"
        ElseIf numberInput >= 60 And numberInput <= 62 Then
            grade = "C-"
        ElseIf numberInput >= 57 And numberInput <= 59 Then
            grade = "D+"
        ElseIf numberInput >= 53 And numberInput <= 56 Then
            grade = "D"
        ElseIf numberInput >= 50 And numberInput <= 52 Then
            grade = "D-"
        Else
            grade = "F"
        End If

        Return grade

    End Function


End Class
