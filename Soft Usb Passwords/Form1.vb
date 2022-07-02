Imports System.IO
Imports MaterialSkin
Imports System.Net
Public Class Form1


    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer


    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        Configurazione_Usb.Show()
    End Sub


    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub





    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("D:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("E:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("H:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\Pass") Then
            Sblocca_Pen_Drive.Show()
        Else
            MsgBox("Non è stata trovata la Pen Drive configurata")

        End If
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            For Each d In Directory.GetDirectories("H:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("H:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("H:\Pass")
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            For Each d In Directory.GetDirectories("D:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("D:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("D:\Pass")

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            For Each d In Directory.GetDirectories("E:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("E:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("E:\Pass")
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            For Each d In Directory.GetDirectories("F:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("F:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("F:\Pass")
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            For Each d In Directory.GetDirectories("G:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("G:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("G:\Pass")



        End If

        MsgBox("Configarazione eliminata con successo")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            download.DownloadFileAsync(New Uri("Server Ftp Url"), Application.StartupPath & "\Updater.txt")

            Timer3.Start()
            Timer4.Start()
            Timer5.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer6.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer7.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer8.Start()
        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer9.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer10.Start()
        End If



    End Sub

    Public WithEvents download As New WebClient

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
        Informazioni.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If My.Computer.FileSystem.DirectoryExists("F:\Pass") Then

            El.Visible = True

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\Pass") Then

            El.Visible = True
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\Pass") Then

            El.Visible = True
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\Pass") Then

            El.Visible = True
        ElseIf My.Computer.FileSystem.DirectoryExists("H:\Pass") Then
            El.Visible = True
        Else
            El.Visible = False

        End If
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        If My.Computer.FileSystem.DirectoryExists("F:\Pass") Then

            Panel2.Visible = False
        ElseIf My.Computer.FileSystem.DirectoryExists("E:\Pass") Then

            Panel2.Visible = False
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\Pass") Then

            Panel2.Visible = False
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\Pass") Then

            Panel2.Visible = False
        ElseIf My.Computer.FileSystem.DirectoryExists("H:\Pass") Then

            Panel2.Visible = False
        Else

            Panel2.Visible = True


        End If

    End Sub




    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        MaterialProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-sup")
        Else


        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer4.Stop()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs)
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub Timer6_Tick_1(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Configurazione_Usb.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If My.Computer.FileSystem.DirectoryExists("D:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("E:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("H:\Pass") Then
            Sblocca_Pen_Drive.Show()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\Pass") Then
            Sblocca_Pen_Drive.Show()
        Else
            MsgBox("Non è stata trovata la Pen Drive configurata")

        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click



        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            For Each d In Directory.GetDirectories("H:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("H:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("H:\Pass")
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            For Each d In Directory.GetDirectories("D:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("D:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("D:\Pass")

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            For Each d In Directory.GetDirectories("E:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("E:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("E:\Pass")
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            For Each d In Directory.GetDirectories("F:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("F:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("F:\Pass")
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            For Each d In Directory.GetDirectories("G:\Pass")
                Directory.Delete(d, True)
            Next

            ' Finish removing also the files in the root folder
            For Each f In Directory.GetFiles("G:\Pass")
                File.Delete(f)
            Next
            Directory.Delete("G:\Pass")



        End If

        MsgBox("Configarazione eliminata con successo")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Settings.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (y)
            Me.Location = NuovP
        End If
    End Sub
End Class
