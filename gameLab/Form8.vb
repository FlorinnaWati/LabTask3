Public Class Form8
    Private Sub txtcalculate_Click(sender As Object, e As EventArgs) Handles txtcalculate.Click
        Dim txtanswer As Integer = 10 + 55

        ' Check if the sum is correct
        If txtanswer = 65 Then
            ' Show a message box indicating correct result
            ' MessageBox.Show("Correct! The sum is 65.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Move to the next form
            Dim nextForm As New Form7()
            Form7.Show()
            Me.Hide()
        Else
            ' Show a message box indicating incorrect result
            MessageBox.Show("Incorrect! YOU DEADDD. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class