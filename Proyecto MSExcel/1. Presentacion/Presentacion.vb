Public Class Presentacion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Minimizar Apps
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Codigo para la barra de prgreso
        ProgressBar1.Visible = False

        Dim a, b As Decimal
        For a = 0 To 80
            b = a / 80

            Me.Opacity = b
            Me.Refresh()
        Next

        Timer1.Enabled = True
        Timer1.Interval = 5000

        Timer2.Enabled = True
        Timer2.Interval = 2000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Bienvenida.Show()
        Timer1.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Visible = True
        Timer2.Enabled = False
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 300
        ProgressBar1.Value = 299
        Me.Controls.Add(ProgressBar1)

    End Sub
End Class