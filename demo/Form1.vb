Public Class EMPLOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OTP As New OTP
        If (user.Text = ("PizzaHub") And pass.Text = ("pass123")) Then
            MessageBox.Show("Login Successful", "Welcome!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            OTP.Show()
            Me.Hide()
            OTP.ProjectBindingSource.AddNew()


        Else
            MessageBox.Show("Invalid Username or Password", "Try Again!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        pass.PasswordChar = "*"
    End Sub


End Class
