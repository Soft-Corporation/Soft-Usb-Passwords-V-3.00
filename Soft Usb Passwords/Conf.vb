Imports System.IO
Imports MaterialSkin
Public Class Conf
    Private Sub Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Directory.CreateDirectory(Application.StartupPath & "\Dark")
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.CreateDirectory(Application.StartupPath & "\Conf")
        Directory.CreateDirectory(Application.StartupPath & "\Up")

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance








        SkinManager.Theme = MaterialSkinManager.Themes.DARK

        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE)


        Me.Close()

        Form1.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Form1.Hide()

    End Sub
End Class