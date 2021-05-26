Imports System.Net.Mail
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class OTP

    Public Property random As New Random()
    Public Property randomNumber As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox3.Text = randomNumber) Then
            MessageBox.Show("Login Successfully")
        Else
            MessageBox.Show("Enter valid OTP")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name = TextBox1.Text
        Dim Email = TextBox2.Text
        Dim sender1 = "Pizzahub"
        Dim i As Integer
        For i = 0 To 9
            random.Next()
        Next
        randomNumber = (random.Next(100000, 999999)).ToString()
        Dim message As String
        message = "Hey  " + Name + "your OTP is " + randomNumber

        Dim EmailMessage As New MailMessage()
        EmailMessage.From = New MailAddress("pizzahub573@gmail.com")
        EmailMessage.To.Add(Email)
        EmailMessage.Subject = "OTP"
        EmailMessage.Body = message
        Dim SMTP = New SmtpClient("smtp.gmail.com")
        SMTP.Port = 587
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("pizzahub573@gmail.com", "pizza@hub1782")
        SMTP.Send(EmailMessage)
        MsgBox("Email Sent Successfully")
    End Sub
End Class

