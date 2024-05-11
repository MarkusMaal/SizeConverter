Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = 0
        ComboBox1.SelectedItem = "KB"
        Label3.Text = "0"
        ComboBox2.SelectedItem = "KB"
        Label4.Text = "0 KB"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox2.SelectedItem = ComboBox1.SelectedItem
        If ComboBox1.SelectedItem = "KB" Then
            Label3.Text = TextBox1.Text - (0.024 * TextBox1.Text)
            Label4.Text = Label3.Text & " KB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "MB" Then
            Label3.Text = TextBox1.Text - (0.0486 * TextBox1.Text)
            Label4.Text = Label3.Text & " MB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "GB" Then
            Label3.Text = TextBox1.Text - (0.0737 * TextBox1.Text)
            Label4.Text = Label3.Text & " GB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "TB" Then
            Label3.Text = TextBox1.Text - (0.0995 * TextBox1.Text)
            Label4.Text = Label3.Text & " TB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "PB" Then
            Label3.Text = TextBox1.Text - (0.1259 * TextBox1.Text)
            Label4.Text = Label3.Text & " PB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "EB" Then
            Label3.Text = TextBox1.Text - (0.1529 * TextBox1.Text)
            Label4.Text = Label3.Text & " EB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "ZB" Then
            Label3.Text = TextBox1.Text - (0.1867 * TextBox1.Text)
            Label4.Text = Label3.Text & " ZB"
            Exit Sub
        ElseIf ComboBox1.SelectedItem = "YB" Then
            Label3.Text = TextBox1.Text - (0.2089 * TextBox1.Text)
            Label4.Text = Label3.Text & " YB"
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ComboBox1.SelectedItem = ComboBox1.SelectedItem
        Form2.TextBox1.Text = TextBox1.Text
        Form2.Label3.Text = Label3.Text
        If Form2.ComboBox1.SelectedItem = "KB" Then
            Form2.Label3.Text = (0.024 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.ComboBox2.SelectedItem = "KB"
            Form2.Label4.Text = Form2.Label3.Text & " KB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "MB" Then
            Form2.Label3.Text = (0.0486 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.ComboBox2.SelectedItem = "MB"
            Form2.Label4.Text = Form2.Label3.Text & " MB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "GB" Then
            Form2.Label3.Text = (0.0737 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.ComboBox2.SelectedItem = "GB"
            Form2.Label4.Text = Form2.Label3.Text & " GB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "TB" Then
            Form2.Label3.Text = (0.0995 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.ComboBox2.SelectedItem = "TB"
            Form2.Label4.Text = Form2.Label3.Text & " TB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "PB" Then
            Form2.Label3.Text = (0.1259 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.ComboBox2.SelectedItem = "PB"
            Form2.Label4.Text = Form2.Label3.Text & " PB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "EB" Then
            Form2.Label3.Text = (0.1529 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.ComboBox2.SelectedItem = "EB"
            Form2.Label4.Text = Form2.Label3.Text & " EB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "ZB" Then
            Form2.Label3.Text = (0.1867 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.Label4.Text = Form2.Label3.Text & " ZB"
            Form2.ComboBox2.SelectedItem = "ZB"
            GoTo Finish
        ElseIf Form2.ComboBox1.SelectedItem = "YB" Then
            Form2.Label3.Text = (0.2089 * Form2.TextBox1.Text) + Form2.TextBox1.Text
            Form2.Label4.Text = Form2.Label3.Text & " YB"
            Form2.ComboBox2.SelectedItem = "YB"
            GoTo Finish
        End If
Finish:
        Form2.Show()
        Hide()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Form2.Close()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedItem = "KB" Then
            If ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text / 1024 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text / 1024 / 1024 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 / 1024 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text & " KB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "MB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text / 1024 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text / 1024 / 1024 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 / 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text & " MB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "GB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1024 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text / 1024 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1024 / 1024 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 / 1024 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text & " GB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "TB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1024 * 1024 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1024 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text / 1024 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1024 / 1024 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 / 1024 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text & " TB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "PB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1024 * 1024 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1024 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text / 1024 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1024 / 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 / 1024 / 1024 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text & " PB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "EB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1024 * 1024 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text * 1024 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text / 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 / 1024 & " YB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text & " EB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "ZB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text / 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text & " KB"
                Exit Sub
            End If
        ElseIf ComboBox1.SelectedItem = "YB" Then
            If ComboBox2.SelectedItem = "KB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 & " KB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "MB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 & " MB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "GB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 * 1024 & " GB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "TB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 * 1024 & " TB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "PB" Then
                Label4.Text = Label3.Text * 1024 * 1024 * 1024 & " PB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "EB" Then
                Label4.Text = Label3.Text * 1024 * 1024 & " EB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "ZB" Then
                Label4.Text = Label3.Text * 1024 & " ZB"
                Exit Sub
            ElseIf ComboBox2.SelectedItem = "YB" Then
                Label4.Text = Label3.Text & " YB"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub


    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        Dim asresult As String
        asresult = InputBox("Sisesta number", "Muuda teist numbrit")
        Label3.Text = asresult
        Label4.Text = Label3.Text & " " & ComboBox2.SelectedItem.ToString
        ComboBox1.SelectedItem = ComboBox2.SelectedItem
    End Sub
End Class
