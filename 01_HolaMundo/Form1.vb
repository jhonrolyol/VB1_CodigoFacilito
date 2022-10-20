Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Preamble:
        ' Note1.- Usar "F5" para ejecutar el código.
        ' Note2.- Usar "Control + S" para guardar el archivo.

        ' Main:
        ' Main1.- Como opción 1 usamos el "Critical".
        MsgBox("Hola Mundo", MsgBoxStyle.Critical, "Código Facilito") ' Muestra el resultado en una ventana aparte.

        ' Main2.- Como opción 2 usamos el "Information".
        MsgBox("Hola Mundo", MsgBoxStyle.Information, "Código Facilito") ' Muestra el resultado en una ventana aparte.

    End Sub
End Class
