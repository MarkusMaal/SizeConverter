Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = 0
        ComboBox1.SelectedItem = "KB"
        Label3.Text = "0"
        Label4.Text = "0 KB"
        ComboBox2.SelectedItem = "KB"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ComboBox1.SelectedItem = ComboBox1.SelectedItem
        Form1.TextBox1.Text = TextBox1.Text
        Form1.Label3.Text = Label3.Text
        If Form1.ComboBox1.SelectedItem = "KB" Then
            Form1.ComboBox2.SelectedItem = "KB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.024 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " KB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "MB" Then
            Form1.ComboBox2.SelectedItem = "MB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.0486 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " MB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "GB" Then
            Form1.ComboBox2.SelectedItem = "GB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.0737 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " GB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "TB" Then
            Form1.ComboBox2.SelectedItem = "TB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.0995 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " TB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "PB" Then
            Form1.ComboBox2.SelectedItem = "PB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.1259 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " PB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "EB" Then
            Form1.ComboBox2.SelectedItem = "EB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.1529 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " EB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "ZB" Then
            Form1.ComboBox2.SelectedItem = "ZB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.1867 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " ZB"
            GoTo Finish
        ElseIf Form1.ComboBox1.SelectedItem = "YB" Then
            Form1.ComboBox2.SelectedItem = "YB"
            Form1.Label3.Text = Form1.TextBox1.Text - (0.2089 * Form1.TextBox1.Text)
            Form1.Label4.Text = Form1.Label3.Text & " YB"
            GoTo Finish
        End If
Finish:
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "KB" Then
            ComboBox2.SelectedItem = "KB"
            Label3.Text = (0.024 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " KB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "MB" Then
            ComboBox2.SelectedItem = "MB"
            Label3.Text = (0.0486 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " MB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "GB" Then
            ComboBox2.SelectedItem = "GB"
            Label3.Text = (0.0737 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " GB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "TB" Then
            ComboBox2.SelectedItem = "TB"
            Label3.Text = (0.0995 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " TB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "PB" Then
            ComboBox2.SelectedItem = "PB"
            Label3.Text = (0.1259 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " PB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "EB" Then
            ComboBox2.SelectedItem = "EB"
            Label3.Text = (0.1529 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " EB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "ZB" Then
            ComboBox2.SelectedItem = "ZB"
            Label3.Text = (0.1867 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " ZB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "YB" Then
            ComboBox2.SelectedItem = "YB"
            Label3.Text = (0.2089 * TextBox1.Text) + TextBox1.Text
            Label4.Text = Label3.Text & " YB"
            Exit Sub
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedItem = "KB" Then
            If ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text / 1000 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text / 1000 / 1000 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 / 1000 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 / 1000 / 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 / 1000 / 1000 / 1000 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text & " KB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "MB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text / 1000 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text / 1000 / 1000 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 / 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 / 1000 / 1000 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text & " MB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "GB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1000 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text / 1000 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1000 / 1000 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 / 1000 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text & " GB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "TB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1000 * 1000 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1000 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1000 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1000 / 1000 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 / 1000 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text & " TB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "PB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1000 * 1000 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1000 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1000 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1000 / 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 / 1000 / 1000 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text & " PB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "EB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1000 * 1000 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text * 1000 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 / 1000 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text & " EB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "ZB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text & " KB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "YB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 * 1000 * 1000 * 1000 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 * 1000 * 1000 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 * 1000 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 * 1000 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text * 1000 * 1000 * 1000 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text * 1000 * 1000 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text * 1000 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text & " YB"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        Dim asresult As String
        asresult = InputBox("Sisesta number", "Muuda teist numbrit")
        Label3.Text = asresult
        Label4.Text = Label3.Text & " " & ComboBox2.SelectedItem.ToString
        ComboBox1.SelectedItem = ComboBox2.SelectedItem
    End Sub
End Class