Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Form1
    Dim ary1(10, 10) As Integer
    Dim k, h As Integer
    Dim ar1 As Integer(,) = {{2, -2}, {-3, 3}, {-4, 4}, {1, -1}, {2, -2}, {0, 0}, {3, -3}, {4, -4}, {5, -5}}
    ''  Dim ar1 As Integer(,) = {{2, -2}, {1, -1}, {4, -4}, {0, 0}, {2, -2}, {1, -1}, {4, -4}, {3, -3}, {2, -2}}
    ' Dim ar1 As Integer(,) = {{13, 3}, {4, 1}, {-1, 9}, {1, 4}, {3, 3}, {2, 8}, {7, 3}, {6, 2}, {8, -1}}

    ' Dim pr1 As Integer(,) = {{7, 2}, {5, 4}, {4, 4}, {3, 3}, {2, 8}, {2, 2}, {0, 5}}
    'Dim pr1 As Integer(,) = {{4, 4}, {4, 0}, {0, 4}, {3, 3}}
    'Dim pr1 As Integer(,) = {{0, 0}, {3, 1}, {1, 3}, {2, 1}, {2, 0}, {5, 2}}
    'Dim pr1 As Integer(,) = {{7, 2}, {5, 4}, {4, 4}, {3, 3}, {2, 8}, {0, 5}}
    ' Dim pr1 As Integer(,) = {{2, 2}, {2, 3}, {5, 0}, {9, -1}}
    Dim pr1 As Integer(,) = {{1, 1}, {-4, 2}, {-8, 3}, {2, -4}, {4, 4}, {-2, 6}, {3, -8}, {6, -2}, {3, 3}}
    Dim ar As Integer(,)
    Dim arf(10, 10) As Integer
    Dim arc(10, 10), arr(10, 10), prf(10, 10) As Integer

    Dim pen1 As New System.Drawing.Pen(Color.Red, 4)
    Dim pen2 As New System.Drawing.Pen(Color.Black, 4)
    Dim pen3 As New System.Drawing.Pen(Color.Green, 4)
    Dim g As System.Drawing.Graphics
    Dim font1 As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
    Dim p, q As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox3.Items.Clear()
        'ListBox4.Items.Clear()

        Dim h, a As Integer
        Dim f, aa, i, g As Integer
        'Dim ar As Integer(,) = {{-5, -5}, {0, 1}, {1, 0}, {-1, -1}}
        ' Dim ar As Integer(,) = {{2, 1}, {0, 0}, {0, 0}, {1, 1}}
        'Dim ar As Integer(,) = {{-1, -1}, {0, -12}, {-12, 0}, {-8, -8}}
        Dim ar(10, 1) As Integer
        For i = 0 To 7 'from
            a = InputBox("enter array values ")
            ListBox4.Items.Add(a)
            If h = 0 Then
                ar(i, 0) = ListBox4.Items(i)
                h = h + 1
            Else
                ar(i, 1) = ListBox4.Items(i)
                h = 0
            End If
        Next  'here

        aa = Math.Sqrt(ar.Length - 1)

        For i = 0 To aa
            ' ListBox4.Items.Add(ar(i, 0) & "," & ar(i, 1))
        Next


        f = ar(0, 0)


        For i = 1 To aa
            If f < ar(i, 0) Then
                f = ar(i, 0)
                g = i
            End If
        Next
        ListBox3.Items.Add(ar(g, 0) & "," & ar(g, 1))
        f = ar(0, 1)
        For i = 1 To aa
            If f < ar(i, 1) Then
                f = ar(i, 1)
                g = i
            End If
        Next

        ListBox3.Items.Add(ar(g, 0) & "," & ar(g, 1))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim l As Label
        Dim fr, aa, g, fc, g1, aa1, bb As Integer
        Dim i, j, k As Integer
        ListBox1.Items.Clear

       
        i = 0


        l = Label2
        ' aa1 = ListBox4.Items.Count * 2 / 2

        aa = ar1.Length / 2

        If aa = 4 Then
            '  ComboBox1.Items.Add("No reduise array")
            End
        Else

            j = Math.Sqrt(aa)
            fr = ar1(0, 0)
            fc = ar1(0, 1)
        End If

        For i = 0 To aa - 1
            ListBox5.Items.Add(ar1(i, 0) & "," & ar1(i, 1))
        Next


        For i = 0 To aa - 1



            If fr > ar1(i, 0) Then
                fr = ar1(i, 0)
                g = i
            End If





        Next
        For i = 0 To aa - 1
            If fc >= ar1(i, 1) Then
                fc = ar1(i, 1)
                g1 = i
            End If
        Next
        '//////////////////////
        k = 0
        '  v = g1 - j
        '  For i = 0 To aa - 1
        'If i <> g And i <> g + j And i <> g + j + j And i <> g - j And i <> g1 And i <> g1 + 1 And i <> g1 + 2 Then

        'arf(k, 0) = ar1(i, 0)
        ' arf(k, 1) = ar1(i, 1)

        '  ListBox1.Items.Add(arf(k, 0) & "," & arf(k, 1))
        '  k = k + 1

        '  End If

        ' Next
        '//////////
        bb = g - j
        If bb < 0 Then
            For i = 0 To aa - 1
                If i <> g And i <> g + j And i <> g + j + j Then

                    arr(k, 0) = ar1(i, 0)
                    arr(k, 1) = ar1(i, 1)
                    ' ListBox1.Items.Add(arr(k, 0) & "," & arr(k, 1))
                    k = k + 1

                End If

            Next
        End If
        If bb = 0 And bb < 3 Then
            For i = 0 To aa - 1
                If i <> g And i <> g - j And i <> g + j Then

                    ' printera(v, g1, aa)
                    arr(k, 0) = ar1(i, 0)
                    arr(k, 1) = ar1(i, 1)
                    ' ListBox1.Items.Add(arr(k, 0) & "," & arr(k, 1))
                    k = k + 1

                End If
            Next
        End If
        If bb > 3 And bb < 6 Then
            For i = 0 To aa - 1
                If i <> g And i <> g + j And i <> g - j - j Then
                    ' printera(v, g1, aa)
                    arr(k, 0) = ar1(i, 0)
                    arr(k, 1) = ar1(i, 1)
                    ' ListBox1.Items.Add(arr(k, 0) & "," & arr(k, 1))
                    k = k + 1

                End If
            Next
        End If
        k = 0

        bb = g1 - j
        If bb < 0 Then
            For i = 0 To aa - 1
                If i > j Then

                    arc(k, 0) = arr(i, 0)
                    arc(k, 1) = arr(i, 1)

                    k = k + 1

                End If

            Next
        End If

        If bb = 0 And bb < 3 Then
            For i = 0 To aa - 1
                If i <> j And i <> j + 1 And i <> j + 2 Then

                    
                    arc(k, 0) = arr(i, 0)
                    arc(k, 1) = arr(i, 1)
                    ' ListBox1.Items.Add(arr(k, 0) & "," & arr(k, 1))
                    k = k + 1

                End If
            Next
        End If
        If bb >= 3 And bb < 6 Then
            For i = 0 To aa - 1
                If i <> 4 And i <> 5 And i <> 6 Then
                    arc(k, 0) = arr(i, 0)
                    arc(k, 1) = arr(i, 1)
                    ' ListBox1.Items.Add(arr(k, 0) & "," & arr(k, 1))
                    k = k + 1

                End If
            Next
        End If
        For i = 0 To 3
            arf(i, 0) = arc(i, 0)
            arf(i, 1) = arc(i, 1)
            ListBox1.Items.Add(arf(i, 0) & "," & arf(i, 1))
        Next
        GroupBox1.Visible = True
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To ar1.Length / 2 - 1
            ' ListBox4.Items.Add(ar1(i, 0) & "," & ar1(i, 1))
        Next
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c1, c2, c3, c4, c5, s1, s2, s3, s4, s5 As Double
        'calculet value of P
        c4 = arf(0, 1) + (arf(1, 1) * -1)
        c1 = arf(2, 1) + (arf(3, 1) * -1)

        If c4 < 0 Then
            c4 = Math.Abs(c4)

        Else
            c4 = c4 * -1
        End If
        If arf(0, 1) < 0 Then
            c2 = Math.Abs(arf(1, 1))
        End If
        c5 = c4 + c1
        If c5 < 0 Then
            c5 = Math.Abs(c5)
        ElseIf c5 > 0 Then
            c5 = c5 * -1

        End If
        c3 = c2 + arf(3, 1)

        p = c3 / c5


        TextBox2.Text = p
        'calculet value of Q
        s4 = arf(0, 0) + (arf(2, 0) * -1)
        s1 = arf(1, 0) + (arf(3, 0) * -1)

        If s4 < 0 Then
            s4 = Math.Abs(s4)

        Else
            s4 = s4 * -1
        End If
        If arf(0, 0) < 0 Then
            s2 = Math.Abs(arf(0, 0))
        End If
        s5 = c4 + c1
        If s5 < 0 Then
            s5 = Math.Abs(s5)
        ElseIf s5 > 0 Then
            s5 = c5 * -1
        Else
            MsgBox("error value")
            Exit Sub

        End If
        s3 = s2 + arf(3, 0)

        q = s3 / s5
        TextBox3.Text = q
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x1, y1 As Integer
        x1 = (100 * p) + 120
        y1 = (100 * q) + 120
        PictureBox1.Refresh()
        g = PictureBox1.CreateGraphics
        g.DrawLine(pen1, 10, PictureBox1.Height - 10, PictureBox1.Width, PictureBox1.Height - 10)
        g.DrawLine(pen1, 10, 10, 10, PictureBox1.Height - 10)
        g.DrawString("q", font1, Brushes.Red, 10, 10)
        g.DrawString("p", font1, Brushes.Red, 280, PictureBox1.Height - 30)
        g.DrawLine(pen2, x1, PictureBox1.Height - 10, x1, 10)
        g.DrawLine(pen3, 10, y1, PictureBox1.Width, y1)
        g.DrawLine(pen2, x1, 10, 500, 10)
        g.DrawLine(pen3, PictureBox1.Width, y1, PictureBox1.Width, PictureBox1.Height)
    End Sub
    Sub printera(ByVal v As Integer, g1 As Integer, aa As Integer, i As Integer)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim i, f, g, aa As Integer
        Dim k As Integer
        k = 0
        f = pr1(0, 0)
        aa = pr1.Length / 2

        For j = 0 To 3

            For i = 0 To aa - 1
                If g <> i Then

                    If f < pr1(i, 0) Then
                        f = pr1(i, 0)
                        g = i
                        k = 1
                    Else
                        k = 1
                    End If


                End If

            Next
            If pr1(g, 1) > 0 And k = 1 Then
                ' ListBox2.Items.Add(pr1(g, 0) & "," & pr1(g, 1))
                prf(j, 0) = pr1(g, 0)
                prf(j, 1) = pr1(g, 1)


            End If

            f = pr1(j, 0)
            k = 0
        Next
        f = pr1(0, 1)
        k = 0
        For j = 0 To aa - 2

            For i = 0 To aa - 1
                If g <> i Then

                    If f < pr1(i, 1) Then
                        f = pr1(i, 1)
                        g = i
                        k = 1
                    End If
                End If

            Next
            If k = 1 And pr1(g, 0) > 0 Then
                ' ListBox2.Items.Add(pr1(g, 0) & "," & pr1(g, 1))
                prf(g, 1) = pr1(g, 1)
                prf(g, 0) = pr1(g, 0)

            End If

            f = pr1(j, 1)
            k = 0
        Next
        f = prf(0, 0)
        ListBox2.Items.Add(prf(0, 0) & "," & prf(0, 1))
        For i = 1 To aa - 1
            If f <> prf(i, 0) And prf(i, 0) > 0 Then
                ListBox2.Items.Add(prf(i, 0) & "," & prf(i, 1))
            End If
        Next
        Debug.Write("aaaa")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim i, j, t, aa, t1 As Integer
        aa = pr1.Length / 2
        For i = 0 To aa - 1
            ListBox6.Items.Add(pr1(i, 0) & "," & pr1(i, 1))
        Next

        For j = 0 To aa - 2
            For i = 0 To aa - 2
                If pr1(i, 0) < pr1(i + 1, 0) Then
                    t = pr1(i, 0)
                    t1 = pr1(i, 1)
                    pr1(i, 0) = pr1(i + 1, 0)
                    pr1(i, 1) = pr1(i + 1, 1)
                    pr1(i + 1, 0) = t
                    pr1(i + 1, 1) = t1
                End If
            Next
        Next
        ListBox2.Items.Add("pareto opt player a")
        For i = 0 To 1
            If pr1(i, 1) <> 0 Then
                ListBox2.Items.Add(pr1(i, 0) & "," & pr1(i, 1))
            End If
        Next
        For j = 0 To aa - 2
            For i = 0 To aa - 2
                If pr1(i, 1) < pr1(i + 1, 1) Then
                    t = pr1(i, 0)
                    t1 = pr1(i, 1)
                    pr1(i, 0) = pr1(i + 1, 0)
                    pr1(i, 1) = pr1(i + 1, 1)
                    pr1(i + 1, 0) = t
                    pr1(i + 1, 1) = t1
                End If
            Next
        Next
        ListBox2.Items.Add("pareto opt player b")
        For i = 0 To 1
            If pr1(i, 0) <> 0 Then

                ListBox2.Items.Add(pr1(i, 0) & "," & pr1(i, 1))
            End If

        Next
    End Sub
End Class
