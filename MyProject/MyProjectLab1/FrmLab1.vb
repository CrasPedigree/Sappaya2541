Public Class FrmLab1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim salary, salaryperyear, tax As Double
        salary = txt1.Text
        salary = Val(salary * 12)

        salaryperyear = Val(salary * 5) / 100

        tax = Val(salary) - Val(salaryperyear)

        lbl1.Text = salary
        lbl2.Text = salaryperyear
        lbl3.Text = tax

    End Sub
End Class
