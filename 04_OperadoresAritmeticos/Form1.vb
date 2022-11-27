Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preamble:
        ' Note1.- Usar "F5" para ejecutar el código.
        ' Note2.- Usar "Control + S" para guardar el archivo.

        ' Main:
        ' Main1.- Suma
        Dim num1, num2, operacion As Integer
        num1 = 2
        num2 = 5
        operacion = num1 + num2
        MsgBox(operacion.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main2.- Resta o diferencia
        Dim a, b, diferencia As Integer
        a = 12
        b = 8
        diferencia = a - b
        MsgBox(diferencia.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main3.- Multiplicación o producto
        Dim M1, M2, producto As Integer
        M1 = 10
        M2 = 20
        producto = M1 * M2
        MsgBox(producto.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main4.- Divición o cociente
        Dim D1, D2, cociente As Double
        D1 = 12
        D2 = 7
        cociente = D1 / D2
        MsgBox(cociente.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main5.- Módulo
        Dim Mod1, Mod2, Modulo As Double
        Mod1 = 2
        Mod2 = 5
        Modulo = Mod1 Mod Mod2
        MsgBox(Modulo.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main6.- Módulo con un número
        Dim ModN1, ModN2, ModuloN As Double
        ModN1 = 2
        ModN2 = 5
        ModuloN = 5 Mod ModN2
        MsgBox(ModuloN.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main7.- Incrementar o aumentar
        Dim ModNI1, ModNI2, ModuloNI As Double
        ModNI1 = 2
        ModNI2 = 5
        ModuloNI = 5 Mod ModNI2

        'ModNI1 += 1 ' Incremento en +1.
        'ModNI1 += 5 ' Incremento en +5.
        ModNI1 += 10 ' Incremento en +10.

        MsgBox(ModNI1.ToString) ' Muestra el resultado en una ventana aparte.

        ' Main8.- Decrementar o disminuir 
        Dim ModND1, ModND2, ModuloND As Double
        ModND1 = 2
        ModND2 = 5
        ModuloND = 5 Mod ModND2

        'ModND1 -= 1 ' Incremento en -1.
        'ModND1 -= 5 ' Incremento en -5.
        ModND1 -= 10 ' Incremento en -10.

        MsgBox(ModND1.ToString) ' Muestra el resultado en una ventana aparte.

    End Sub
End Class
