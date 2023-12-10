Public Class Form1
    Private Sub КунToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КунToolStripMenuItem.Click
        TextBox1.Text = DateString
    End Sub

    Private Sub СаатToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СаатToolStripMenuItem.Click
        TextBox1.Text = TimeString
    End Sub

    Private Sub КызылToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles КызылToolStripMenuItem1.Click
        Me.TextBox1.BackColor = Color.Red
    End Sub

    Private Sub СарыToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles СарыToolStripMenuItem1.Click
        Me.TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub ЖашылToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЖашылToolStripMenuItem.Click
        Me.TextBox1.BackColor = Color.Green
    End Sub

    Private Sub КызылToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles КызылToolStripMenuItem2.Click
        Me.TextBox1.ForeColor = Color.Black
    End Sub

    Private Sub СарыToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles СарыToolStripMenuItem2.Click
        Me.TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub ЖашылToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ЖашылToolStripMenuItem1.Click
        Me.TextBox1.ForeColor = Color.Yellow
    End Sub

    Private Sub КошумчаТусТандооToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КошумчаТусТандооToolStripMenuItem.Click
        Dim myDialog As New ColorDialog()
        If myDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.BackColor = myDialog.Color
        End If
    End Sub

    Private Sub СарыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СарыToolStripMenuItem.Click
        Dim myDialog As New ColorDialog()
        If myDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.BackColor = myDialog.Color
        End If
    End Sub

    Private Sub НуртилекToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НуртилекToolStripMenuItem.Click
        Dim i As Form2 = New Form2
        i.Show()
    End Sub

    Private Sub ЧыгууToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЧыгууToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Msg, Style, Title, Response, MyString
        Title = "MsgBox терезеси"
        Msg = "Сен сабакка келдиңби?"
        Style = vbQuestion + vbYesNoCancel
        Response = MsgBox(Msg, Style, Title)
        Select Case Response
            Case vbYes
                TextBox1.Text = "Азаматсың!!!"
            Case vbNo
                TextBox1.Text = "Сабакка келиш керек да!"
            Case vbCancel
                TextBox1.Text = "Сабактан качпаш керек!"
        End Select
    End Sub
End Class
