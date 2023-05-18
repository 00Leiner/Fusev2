Imports AForge.Video
Imports AForge.Video.DirectShow


Public Class TCamera
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles TakeBttn.Click
        'shows the generated image
        PictureBox6.Image = PictureBox5.Image
    End Sub
    Private Sub captured(sender As Object, eventargs As NewFrameEventArgs)
        bmp = DirectCast(eventargs.Frame.Clone(), Bitmap)
        PictureBox5.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub TCamera_Load(sender As Object, e As EventArgs) Handles Me.Load
        'to show directly the permission to open camera
        Me.Show()
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf captured)
            camera.Start()
        End If

    End Sub

    Private Sub closeBttn_Click(sender As Object, e As EventArgs) Handles closeBttn.Click
        'çlose
        Me.Close()
        If registry.PictureBox5.Image IsNot Nothing Then
            registry.PictureBox5.Image.Dispose()
        End If

        registry.PictureBox5.Image = PictureBox6.Image


    End Sub


End Class