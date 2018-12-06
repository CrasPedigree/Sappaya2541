Public Class FrmLab2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Me.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim Vistra, Computer, Total, CommissionVis, CommissionCom, Commission As Double
        Vistra = txtVis.Text
        Computer = txtCom.Text

        Total = Vistra + Computer

        CommissionVis = Val(Vistra * 5) / 100
        CommissionCom = Val(Computer * 10) / 100

        lbl1.Text = Total
        lbl2.Text = CommissionVis
        lbl3.Text = CommissionCom
        lbl4.Text = CommissionVis + CommissionCom

    End Sub
End Class