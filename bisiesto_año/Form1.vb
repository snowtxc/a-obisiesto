Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nom As String
        nom = txtName.Text


        If nom <> "" Then
            Dim form2 As New Form2(nom)

            form2.Show()

        Else
            MsgBox("Tu nombre no puede estar vacio")


        End If






    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
