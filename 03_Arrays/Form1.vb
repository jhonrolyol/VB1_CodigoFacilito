Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preamble:
        ' Note1.- Usar "F5" para compilar.
        ' Note2.- Usar "Control + S" para guardar el archivo.

        ' Main:
        ' Main1.- Crear un arreglo con 3 posiciones
        Dim arreglo(3) As String
        arreglo(0) = "Hola" 'Posición 1
        arreglo(1) = "Código" ' Posición 2
        arreglo(2) = "Facilito" ' Posición 3
        MsgBox(arreglo(0) + " " + arreglo(1) + " " + arreglo(3)) ' Usar " " para espaciado.

        ' Main2.- Crear un arreglo con ...... posiciones
        Dim arreglo() As Integer
        arreglo = New Integer() {1, 2, 3}
        MsgBox(arreglo(0).ToString + " " + arreglo(1).ToString + " " + arreglo(2).ToString)

        ReDim Preserve arreglo(2) ' Usar "Preserve" para mantener los datos de arreglo.
        MsgBox(arreglo(0).ToString + " " + arreglo(1).ToString)

        ReDim arreglo(3)
        MsgBox(arreglo(0).ToString + " " + arreglo(1).ToString + " " + arreglo(2).ToString)

        ' Main3.- Matriz
        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matriz(1, 1).ToString)


    End Sub
End Class
