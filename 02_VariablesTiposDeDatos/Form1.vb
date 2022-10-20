Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preamble:
        ' Note1.- Usar "F5" para compilar.
        ' Note2.- Usar "Dim" para crear variables.

        ' Main:
        ' Main1.- Crear la variable "entero" usando "Integer".
        Dim entero As Integer = 1
        MsgBox(entero) ' Muestra el resultado en una ventana aparte.
        entero = 2
        MsgBox(entero) ' Muestra el resultado en una ventana aparte.

        ' Main2.- Crear la variable "numero" usando "Double".
        Dim numero As Double = 123.456
        MsgBox(numero) ' Muestra el resultado en una ventana aparte.
        numero = 12.5
        MsgBox(numero) ' Muestra el resultado en una ventana aparte.

        ' Main3.- Crear la variable "texto" usando "String".
        Dim texto As String = "Hola Mundo"
        MsgBox(texto) ' Muestra el resultado en una ventana aparte.
        Dim texto2 As String = "Código Facilito"
        MsgBox(texto + texto2) ' Muestra el resultado en una ventana aparte.

        ' Main4.- Crear la variable "fecha" usando "Date".
        'Dim fecha As Date = "01/01/12"
        Dim fecha As Date = "01-01-12" ' Día/Mes/Año
        MsgBox(fecha) ' Muestra el resultado en una ventana aparte.
        Dim fecha2 As Date = "01-JAN-2022"
        MsgBox(fecha2) ' Muestra el resultado en una ventana aparte.


    End Sub
End Class
