Public Class FrmPrincipal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Minimizar Apps
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(20)

        '-----------------------------------------------------------------------------------------------------
        'ESTE CODIGO COLOCA LOS NUMEROS AUTOMATICAMENTE EN LAS CELDAS IZQUIERDAS
        If DataGridView1.Rows.Count > 0 Then
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                Me.DataGridView1.Rows(r).HeaderCell.Value = (r + 1).ToString()
            Next
        End If
        DataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
        'ACA FINALIZA EL CODIGO
        '----------------------------------------------------------------------------------------------------
        Archivo.Parent = Nothing
        Archivo.BackColor = Color.MediumSpringGreen

    End Sub
   
End Class