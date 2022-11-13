Public Class Form1
    Dim FirstNum = ""
    Dim Oper = ""
    Dim CanAdd = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
    End Sub

    Private Sub addChar(chr)
        TextBox1.Text = TextBox1.Text + chr
    End Sub

    Private Sub ChangeOps(bool)
        If bool Then
            Button12.Enabled = True
            Button13.Enabled = True
            Button14.Enabled = True
            Button15.Enabled = True
        Else
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button15.Enabled = False
        End If
    End Sub

    Private Sub ChangeNums(bool)
        If bool Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button6.Enabled = True
            Button5.Enabled = True
            Button4.Enabled = True
            Button9.Enabled = True
            Button8.Enabled = True
            Button7.Enabled = True
            Button11.Enabled = True
            Button16.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button6.Enabled = False
            Button5.Enabled = False
            Button4.Enabled = False
            Button9.Enabled = False
            Button8.Enabled = False
            Button7.Enabled = False
            Button11.Enabled = False
            Button16.Enabled = False
        End If
    End Sub

    Private Sub AddOp(op)
        If Oper = "" And FirstNum = "" And TextBox1.Text.Length > 0 Then
            FirstNum = TextBox1.Text
            Oper = op
            TextBox1.Text = ""
            ChangeOps(False)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addChar("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addChar("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addChar("3")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        addChar("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        addChar("5")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        addChar("6")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        addChar("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        addChar("8")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        addChar("9")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        addChar("0")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If FirstNum <> "" And Oper <> "" Then
            Try
                Dim FirstNumber = Convert.ToInt64(FirstNum)
                Dim SecondNumber = Convert.ToInt64(TextBox1.Text)
                TextBox1.Text = ""
                If Oper = "+" Then
                    TextBox1.Text = (FirstNumber + SecondNumber).ToString
                ElseIf Oper = "-" Then
                    TextBox1.Text = (FirstNumber - SecondNumber).ToString
                ElseIf Oper = "*" Then
                    TextBox1.Text = (FirstNumber * SecondNumber).ToString
                ElseIf Oper = "/" Then
                    TextBox1.Text = (FirstNumber / SecondNumber).ToString
                End If
                ChangeNums(False)
            Catch ex As Exception
                FirstNum = ""
                Oper = ""
                TextBox1.Text = ""
                ChangeOps(True)
                ChangeNums(True)
                MsgBox("Error")
            End Try
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FirstNum = ""
        Oper = ""
        TextBox1.Text = ""
        ChangeOps(True)
        ChangeNums(True)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AddOp("+")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AddOp("-")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AddOp("*")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AddOp("/")
    End Sub
End Class
