Imports AForge.Video.VFW

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim writer As AVIWriter = New AVIWriter
        Dim bmp As Bitmap = New Bitmap("Frame1.bmp")
        Dim j As Integer = 0
        Dim r As Random = New Random


        writer.Open("NewVideo2.avi", bmp.Width, bmp.Height)
        For i = 0 To 60

            Dim image As Bitmap = New Bitmap("F0.bmp")

            writer.AddFrame(image)
        Next
        For i = 0 To 60

            Dim image As Bitmap = New Bitmap("Frame" + j.ToString + ".bmp")
            j = r.Next(0, 9)
            writer.AddFrame(image)
            writer.AddFrame(image)
            writer.AddFrame(image)
        Next
        writer.Close()

    End Sub
End Class
