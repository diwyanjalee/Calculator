Public Class formcal
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim ResultNumber As Single
    Dim ArithemeticProcess As String

    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        txtCal.Text = txtCal.Text & "0"
    End Sub

    Private Sub Btndot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndot.Click
        txtCal.Text = txtCal.Text & "."
    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        txtCal.Text = txtCal.Text & "1"
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        txtCal.Text = txtCal.Text & "2"
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        txtCal.Text = txtCal.Text & "3"
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        txtCal.Text = txtCal.Text & "4"
    End Sub

    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        txtCal.Text = txtCal.Text & "5"
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        txtCal.Text = txtCal.Text & "6"
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        txtCal.Text = txtCal.Text & "7"
    End Sub

    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        txtCal.Text = txtCal.Text & "8"
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        txtCal.Text = txtCal.Text & "9"
    End Sub

    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        txtCal.Clear()
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        FirstNumber = Val(txtCal.Text)
        txtCal.Text = "0"
        ArithemeticProcess = "+"
    End Sub

    Private Sub Btnsub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsub.Click
        FirstNumber = Val(txtCal.Text)
        txtCal.Text = "0"
        ArithemeticProcess = "-"
    End Sub

    Private Sub Btnmul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmul.Click
        FirstNumber = Val(txtCal.Text)
        txtCal.Text = "0"
        ArithemeticProcess = "*"
    End Sub

    Private Sub Btndiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndiv.Click
        FirstNumber = Val(txtCal.Text)
        txtCal.Text = "0"
        ArithemeticProcess = "/"
    End Sub

    Private Sub Btnequel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnequel.Click
        SecondNumber = Val(txtCal.Text)
        If ArithemeticProcess = "+" Then
            ResultNumber = FirstNumber + SecondNumber
        End If

        SecondNumber = Val(txtCal.Text)
        If ArithemeticProcess = "-" Then
            ResultNumber = FirstNumber - SecondNumber
        End If

        SecondNumber = Val(txtCal.Text)
        If ArithemeticProcess = "*" Then
            ResultNumber = FirstNumber * SecondNumber
        End If

        SecondNumber = Val(txtCal.Text)
        If ArithemeticProcess = "/" Then
            ResultNumber = FirstNumber / SecondNumber
        End If

        txtCal.Text = ResultNumber
    End Sub
End Class
