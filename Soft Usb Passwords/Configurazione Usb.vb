Imports System.IO
Imports MaterialSkin
Public Class Configurazione_Usb


    Dim NuovP As System.Drawing.Point
    Dim x, y As Integer
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("D:\") Then
            Directory.CreateDirectory("D:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")
        End If


    End Sub


    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub



    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("E:\") Then
            Directory.CreateDirectory("E:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")
        End If


    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("F:\") Then
            Directory.CreateDirectory("F:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")
        End If


    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Directory.CreateDirectory("H:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()

        Else
            MsgBox("Unità non disponibile")

        End If


    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("G:\") Then
            Directory.CreateDirectory("G:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")

        End If


    End Sub

    Private Sub Configurazione_Usb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer1.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer2.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer3.Start()
        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer4.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer5.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If My.Computer.FileSystem.DirectoryExists("D:\") Then
            Directory.CreateDirectory("D:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If My.Computer.FileSystem.DirectoryExists("E:\") Then
            Directory.CreateDirectory("E:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If My.Computer.FileSystem.DirectoryExists("F:\") Then
            Directory.CreateDirectory("F:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If My.Computer.FileSystem.DirectoryExists("G:\") Then
            Directory.CreateDirectory("G:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()
        Else
            MsgBox("Unità non disponibile")

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Directory.CreateDirectory("H:\Pass")
            MsgBox("Configurato con successo")
            Me.Close()

        Else
            MsgBox("Unità non disponibile")

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel1.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
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