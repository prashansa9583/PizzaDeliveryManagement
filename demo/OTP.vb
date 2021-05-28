Public Class OTP
    Dim chessydip As Decimal
    Dim garlicbread As Decimal
    Dim parcel As Decimal
    Dim coke As Decimal
    Dim sprite As Decimal
    Dim mirinda As Decimal
    Dim small As Decimal
    Dim medium As Decimal
    Dim large As Decimal
    Dim extralarge As Decimal

    Public Property random As New Random()
    Public Property randomnumber As String



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Name = TextBox1.Text
        Dim Empid = TextBox2.Text
        Dim i As Integer
        For i = 0 To 9
            random.Next()
        Next
        randomnumber = (random.Next(1000, 9999)).ToString()
        Dim message As String
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("Please Enter Valid Details", "Invalid", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else
            message = "Hey " + Name + " Your OTP is " + randomnumber
            MessageBox.Show(message, "OTP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox3.Text = randomnumber) Then
            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Panel7.Show()

        Else
            MessageBox.Show("Enter valid OTP", "Sorry,Try Again!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True
        Panel7.Visible = False
    End Sub

    Private Sub OTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.Project' table. You can move, or remove it, as needed.
        Me.ProjectTableAdapter.Fill(Me.ProjectDataSet.Project)
        Panel7.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True
        Panel7.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "") Then
            MessageBox.Show("Please Enter Valid Details!! ", "Try Again!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Registered Successfully!!", "Thankyou!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If IsNumeric(TextBox4.Text) Then
            ErrorProvider1.SetError(TextBox4, "Only Text is Valid")
        Else
            ErrorProvider1.SetError(TextBox4, "")
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If Not IsNumeric(TextBox6.Text) Then
            ErrorProvider1.SetError(TextBox6, "Only Number is Valid")
        Else
            ErrorProvider1.SetError(TextBox6, "")
        End If
    End Sub






    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub chsyA_Click(sender As Object, e As EventArgs) Handles chsyA.Click
        txtchsy.Text += 1
    End Sub

    Private Sub garA_Click(sender As Object, e As EventArgs) Handles garA.Click
        Txtgarlic.Text += 1
    End Sub

    Private Sub PclA_Click(sender As Object, e As EventArgs) Handles PclA.Click
        txtpcl.Text += 1
    End Sub

    Private Sub cokeA_Click(sender As Object, e As EventArgs) Handles cokeA.Click
        txtcoke.Text += 1
    End Sub

    Private Sub sptA_Click(sender As Object, e As EventArgs) Handles sptA.Click
        txtspt.Text += 1
    End Sub

    Private Sub mirA_Click(sender As Object, e As EventArgs) Handles mirA.Click
        txtmir.Text += 1
    End Sub
    Private Sub smallA_Click(sender As Object, e As EventArgs) Handles smallA.Click
        txtsmall.Text += 1
    End Sub

    Private Sub mediumA_Click(sender As Object, e As EventArgs) Handles mediumA.Click
        txtmedium.Text += 1
    End Sub

    Private Sub largeA_Click(sender As Object, e As EventArgs) Handles largeA.Click
        txtlarge.Text += 1
    End Sub

    Private Sub elA_Click(sender As Object, e As EventArgs) Handles elA.Click
        txtel.Text += 1
    End Sub
    Private Sub chsyS_Click(sender As Object, e As EventArgs) Handles chsyS.Click
        txtchsy.Text -= 1
        If txtchsy.Text <= 0 Then
            txtchsy.Text = 0
        End If
    End Sub

    Private Sub garS_Click(sender As Object, e As EventArgs) Handles garS.Click
        Txtgarlic.Text -= 1
        If Txtgarlic.Text <= 0 Then
            Txtgarlic.Text = 0
        End If
        Txtgarlic.Text = 0
    End Sub

    Private Sub PclS_Click(sender As Object, e As EventArgs) Handles PclS.Click
        txtpcl.Text -= 1
        If txtpcl.Text <= 0 Then
            txtpcl.Text = 0
        End If
    End Sub

    Private Sub cokeS_Click(sender As Object, e As EventArgs) Handles cokeS.Click
        txtcoke.Text -= 1
        If txtcoke.Text <= 0 Then
            txtcoke.Text = 0
        End If
    End Sub

    Private Sub sptS_Click(sender As Object, e As EventArgs) Handles sptS.Click
        txtspt.Text -= 1
        If txtspt.Text <= 0 Then
            txtspt.Text = 0
        End If
    End Sub

    Private Sub mirS_Click(sender As Object, e As EventArgs) Handles mirS.Click
        txtmir.Text -= 1
        If txtmir.Text <= 0 Then
            txtmir.Text = 0
        End If
    End Sub

    Private Sub smallS_Click(sender As Object, e As EventArgs) Handles smallS.Click
        txtsmall.Text -= 1
        If txtsmall.Text <= 0 Then
            txtsmall.Text = 0
        End If
    End Sub

    Private Sub mediumS_Click(sender As Object, e As EventArgs) Handles mediumS.Click
        txtmedium.Text -= 1
        If txtmedium.Text <= 0 Then
            txtmedium.Text = 0
        End If
    End Sub

    Private Sub largeS_Click(sender As Object, e As EventArgs) Handles largeS.Click
        txtlarge.Text -= 1
        If txtlarge.Text <= 0 Then
            txtlarge.Text = 0
        End If
    End Sub

    Private Sub elS_Click(sender As Object, e As EventArgs) Handles elS.Click
        txtel.Text -= 1
        If txtel.Text <= 0 Then
            txtel.Text = 0
        End If
    End Sub

    Private Sub order_Click(sender As Object, e As EventArgs) Handles order.Click
        chessydip = txtchsy.Text * 30
        garlicbread = Txtgarlic.Text * 100
        parcel = txtpcl.Text * 75
        coke = txtcoke.Text * 20
        sprite = txtspt.Text * 20
        mirinda = txtmir.Text * 20
        small = txtsmall.Text * 150
        medium = txtmedium.Text * 300
        large = txtlarge.Text * 400
        extralarge = txtel.Text * 575

        txtTotal.Text = "Rs. " & Format(chessydip + garlicbread + parcel + coke + sprite + mirinda + small + medium + large + extralarge)

    End Sub

    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        txtchsy.Text = 0
        Txtgarlic.Text = 0
        txtpcl.Text = 0
        txtcoke.Text = 0
        txtspt.Text = 0
        txtmir.Text = 0
        txtsmall.Text = 0
        txtmedium.Text = 0
        txtlarge.Text = 0
        txtel.Text = 0
        txtTotal.Text = 0

        chessydip = 0
        garlicbread = 0
        parcel = 0
        coke = 0
        sprite = 0
        mirinda = 0
        small = 0
        medium = 0
        large = 0
        extralarge = 0

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False



    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False

        Bill.Label6.Text = TextBox4.Text
        Bill.Label7.Text = TextBox5.Text
        Bill.Label8.Text = TextBox6.Text
        Bill.Label9.Text = txtTotal.Text
        Bill.Label10.Text = DateTimePicker1.Text

        Me.Validate()
        Me.ProjectBindingSource.EndEdit()
        Me.ProjectTableAdapter.Update(Me.ProjectDataSet.Project)
        Me.ProjectTableAdapter.Fill(Me.ProjectDataSet.Project)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False
        Panel7.Visible = False


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Your Bill is Generating", "Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Bill.Show()

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "Only Text is Valid")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True
        Panel7.Visible = False
    End Sub
End Class