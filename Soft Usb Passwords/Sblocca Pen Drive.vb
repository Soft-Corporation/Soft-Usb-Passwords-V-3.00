Imports System.IO
Imports MaterialSkin
Public Class Sblocca_Pen_Drive

    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub








    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub Sblocca_Pen_Drive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next



        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim apri As String = My.Computer.FileSystem.ReadAllText("H:\Pass\P1")
            TextBox2.Text = apri


            Dim apr As String = My.Computer.FileSystem.ReadAllText("H:\Pass\Dp1")
            TextBox1.Text = apr


            Dim apri2 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\P2")
            TextBox3.Text = apri2

            Dim apr2 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\Dp2")
            TextBox4.Text = apr2


            Dim apri3 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\P3")
            TextBox5.Text = apri3

            Dim apr3 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\Dp3")
            TextBox6.Text = apr3

            Dim apri56 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\P4")
            y2.Text = apri56


            Dim apr67 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\Dp4")
            y.Text = apr67


            Dim apri277 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\P5")
            i2.Text = apri277

            Dim apr29 As String = My.Computer.FileSystem.ReadAllText("H:\Pass\Dp5")
            i.Text = apr29





        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim apri4 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\P1")
            TextBox2.Text = apri4


            Dim apr4 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\Dp1")
            TextBox1.Text = apr4


            Dim apri5 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\P2")
            TextBox3.Text = apri5

            Dim apr5 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\Dp2")
            TextBox4.Text = apr5


            Dim apri6 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\P3")
            TextBox5.Text = apri6

            Dim apr7 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\Dp3")
            TextBox6.Text = apr7



            Dim apri556 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\P4")
            y2.Text = apri556


            Dim apr767 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\Dp4")
            y.Text = apr767


            Dim apri207 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\P5")
            i2.Text = apri207

            Dim apr290 As String = My.Computer.FileSystem.ReadAllText("D:\Pass\Dp5")
            i.Text = apr290
        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then

            Dim apri8 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\P1")
            TextBox2.Text = apri8


            Dim apr8 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\Dp1")
            TextBox1.Text = apr8


            Dim apri9 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\P2")

            TextBox3.Text = apri9

            Dim apr9 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\Dp2")
            TextBox4.Text = apr9


            Dim apri10 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\P3")
            TextBox5.Text = apri10

            Dim apr10 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\Dp3")
            TextBox6.Text = apr10



            Dim apri562 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\P4")
            y2.Text = apri562


            Dim apr617 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\Dp4")
            y.Text = apr617


            Dim apri2227 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\P5")
            i2.Text = apri2227

            Dim apr2229 As String = My.Computer.FileSystem.ReadAllText("E:\Pass\Dp5")
            i.Text = apr2229

        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then


            Dim apri11 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\P1")
            TextBox2.Text = apri11


            Dim apr11 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\Dp1")
            TextBox1.Text = apr11


            Dim apri12 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\P2")
            TextBox3.Text = apri12

            Dim apr12 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\Dp2")
            TextBox4.Text = apr12


            Dim apri13 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\P3")
            TextBox5.Text = apri13

            Dim apr13 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\Dp3")
            TextBox6.Text = apr13



            Dim apri56 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\P4")
            y2.Text = apri56


            Dim apr6755 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\Dp4")
            y.Text = apr6755


            Dim apri2755 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\P5")
            i2.Text = apri2755

            Dim apr2559 As String = My.Computer.FileSystem.ReadAllText("F:\Pass\Dp5")
            i.Text = apr2559

        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then


            Dim apri14 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\P1")
            TextBox2.Text = apri14


            Dim apr14 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\Dp1")
            TextBox1.Text = apr14


            Dim apri15 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\P2")
            TextBox3.Text = apri15

            Dim apr15 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\Dp2")
            TextBox4.Text = apr15


            Dim apri16 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\P3")
            TextBox5.Text = apri16

            Dim apr16 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\Dp3")
            TextBox6.Text = apr16




            Dim apri5632 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\P4")
            y2.Text = apri5632


            Dim apr6722 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\Dp4")
            y.Text = apr6722


            Dim apri27334 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\P5")
            i2.Text = apri27334

            Dim apr23349 As String = My.Computer.FileSystem.ReadAllText("G:\Pass\Dp5")
            i.Text = apr23349



        End If





        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer2.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer3.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer4.Start()
        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer6.Start()
        End If










    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
























    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs)












    End Sub

    Private Sub MaterialButton2_Click_1(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P4")
            salva.Write(y2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp4")
            sal.Write(y.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P4")

            salva2.Write(y2.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp4")
            sal2.Write(y.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P4")

            salva3.Write(y2.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp4")
            sal3.Write(y.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P4")

            salva4.Write(y2.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp4")
            sal4.Write(y.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P4")

            salva5.Write(y2.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp4")
            sal5.Write(y.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")




    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P5")
            salva.Write(i2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp5")
            sal.Write(i.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P5")

            salva2.Write(i2.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp5")
            sal2.Write(i.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P5")

            salva3.Write(i2.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp5")
            sal3.Write(i.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P5")

            salva4.Write(i2.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp5")
            sal4.Write(i.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P5")

            salva5.Write(i2.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp5")
            sal5.Write(i.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P1")
            salva.Write(TextBox2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp1")
            sal.Write(TextBox1.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P1")

            salva2.Write(TextBox2.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp1")
            sal2.Write(TextBox1.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P1")

            salva3.Write(TextBox2.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp1")
            sal3.Write(TextBox1.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P1")

            salva4.Write(TextBox2.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp1")
            sal4.Write(TextBox1.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P1")

            salva5.Write(TextBox2.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp1")
            sal5.Write(TextBox1.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P2")
            salva.Write(TextBox3.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp2")
            sal.Write(TextBox4.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P2")

            salva2.Write(TextBox3.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp2")
            sal2.Write(TextBox4.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P2")

            salva3.Write(TextBox3.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp2")
            sal3.Write(TextBox4.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P2")

            salva4.Write(TextBox3.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp2")
            sal4.Write(TextBox4.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P2")

            salva5.Write(TextBox3.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp2")
            sal5.Write(TextBox4.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P3")
            salva.Write(TextBox5.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp3")
            sal.Write(TextBox6.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P3")

            salva2.Write(TextBox5.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp3")
            sal2.Write(TextBox6.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P3")

            salva3.Write(TextBox5.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp3")
            sal3.Write(TextBox6.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P3")

            salva4.Write(TextBox5.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp3")
            sal4.Write(TextBox6.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P3")

            salva5.Write(TextBox5.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp3")
            sal5.Write(TextBox6.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P4")
            salva.Write(y2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp4")
            sal.Write(y.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P4")

            salva2.Write(y2.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp4")
            sal2.Write(y.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P4")

            salva3.Write(y2.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp4")
            sal3.Write(y.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P4")

            salva4.Write(y2.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp4")
            sal4.Write(y.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P4")

            salva5.Write(y2.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp4")
            sal5.Write(y.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P5")
            salva.Write(i2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp5")
            sal.Write(i.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P5")

            salva2.Write(i2.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp5")
            sal2.Write(i.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P5")

            salva3.Write(i2.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp5")
            sal3.Write(i.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P5")

            salva4.Write(i2.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp5")
            sal4.Write(i.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P5")

            salva5.Write(i2.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp5")
            sal5.Write(i.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (p)
            Me.Location = NuovP
        End If
    End Sub
End Class