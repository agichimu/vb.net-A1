Public Class Form1

    Private Property Response As Windows.Forms.DialogResult

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        MessageBox.Show(ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then
            MessageBox.Show("car type is Electric")
        End If

        If CheckBox2.Checked Then
            MessageBox.Show("car type is Petrol")
        End If

        If CheckBox3.Checked Then
            MessageBox.Show("car type is Diesel")
        End If

        

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton1.Checked Then
            MessageBox.Show("Option 1")
        End If

        If RadioButton2.Checked Then
            MessageBox.Show("Option 2")
        End If

        If RadioButton3.Checked Then
            MessageBox.Show("Option 3")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Add(TextBox2.Text)

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim a, b As Double
        HScrollBar1.Minimum = 0
        HScrollBar1.Maximum = 100

        Label1.Text = HScrollBar1.Value.ToString

        b = HScrollBar1.Value
        a = b / 10
        TextBox3.Text = a

    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim a, b As Double
        VScrollBar1.Minimum = 0
        VScrollBar1.Maximum = 100

        Label2.Text = VScrollBar1.Value.ToString

        b = VScrollBar1.Value
        a = b / 10
        TextBox4.Text = a
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim response As Integer
        Response = MessageBox.Show("Are you sure you want to close the application??", "close application", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

