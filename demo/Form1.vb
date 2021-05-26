Public Class EMPLOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OTP As New OTP
        If (user.Text = ("Pizzahub") And pass.Text = ("pass123")) Then
            MsgBox("login successful")
            OTP.Show()
            Me.Hide()

        Else
            MsgBox("invalid username or password")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        pass.PasswordChar = "*"
    End Sub

End Class
