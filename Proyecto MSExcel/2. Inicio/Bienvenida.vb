Public Class Bienvenida

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-Inicio Contador
        Timer1.Start()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Minimizar Apps
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'CambiarImagen Cada 5 Seg
        '-Iniciamos contador
        Label10.Text += 1

        '-Al Llegar a 50 nos muestra la siguente imagen
        If Label10.Text = "50" Then
            PictureBox2.Image = My.Resources.PlantillaBasica2
        End If

        '-Al Llegar a 00 nos muestra la siguente imagen
        If Label10.Text = "100" Then
            Timer1.Stop() 'Detemos el contador para que no siga avanzando
            PictureBox2.Image = My.Resources.PlantillaBasica 'Imagen que cambiara
            Label10.Text = "0" 'Reiniciamos el label en 0
            Timer1.Start() 'E iniciamos nuevamente el contador para que este cambiando la imagen
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '-Abrimos el formulario pricipal y cerramos este
        FrmPrincipal.Show()
        Me.Close()

    End Sub
End Class
