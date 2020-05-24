Public Class Form2

    Private nombre As String

    Public Sub New(ByVal nombre As String)
        Me.nombre = nombre









        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Label1.Text = "Bienvenido" & " " & nombre & "!"



        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Function bisiesto(añobisiesto As Integer)

        If añobisiesto Mod 4 = 0 Or añobisiesto Mod 100 = 0 Or añobisiesto Mod 400 = 0 Then

            Return True

        Else

            Return False


        End If


    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim año As String
        año = txtAño.Text

        If año <> "" Then
            If (IsNumeric(año)) Then
                If bisiesto(año) Then
                    Label4.Text = año & " Es bisiesto"

                Else
                    Label4.Text = año & " No es bisiesto "







                End If
                Label5.Text = "Gracias por usar mi programa!"
                Label6.Text = "Mi nombre es Rodrigo Castro"
                Label7.Text = "Soy alumno de 3ero EMT Informatica de la Escuela Tecnica Maria Espinola Espinola"





            Else
                MsgBox("Solo se permite valores numericos")
            End If
        Else
            MsgBox("El campo no puede estar vacio")

        End If
    End Sub
End Class