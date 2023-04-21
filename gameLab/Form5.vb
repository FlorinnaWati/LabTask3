Option Explicit On
Option Strict On

Public Class Form5
    Private Sub InputBoxButton_Click(sender As Object, e As EventArgs) Handles InputBoxButton.Click

        Dim message, title, defaultValue As String
        Dim myValue As Object

        'set prompt
        message = "Please Input Your review"

        'set title
        title = "REVIEW"

        'set default
        defaultValue = "Please Enter a review"

        'display message, title and default

        myValue = InputBox(message, title, defaultValue)

        'If user has clicked Cancel, set myValue to defaultValue.

        If myValue Is "" Then
            myValue = defaultValue
            MsgBox("myValue = " & defaultValue,
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                   "Review Box")
        Else
            MsgBox(Environment.NewLine & "Thank You",
                  MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                  "Review Box")
        End If

    End Sub
End Class
