Public Class frmGame
    Dim mshoRandomNumber As Short
    Public Property MinWorkingSet As IntPtr
    Private Sub btnExit1_Click(sender As Object, e As EventArgs) Handles btnExit1.Click
        If mshoRandomNumber = 1 Then
            End
        Else
            Dim strPath As String = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\Game.exe"
            System.Diagnostics.Process.Start(strPath)
        End If
    End Sub

    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        If mshoRandomNumber = 2 Then
            End
        Else
            Dim strPath As String = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\Game.exe"
            System.Diagnostics.Process.Start(strPath)
        End If
    End Sub

    Private Sub btnExit3_Click(sender As Object, e As EventArgs) Handles btnExit3.Click
        If mshoRandomNumber = 3 Then
            End
        Else
            Dim strPath As String = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\Game.exe"
            System.Diagnostics.Process.Start(strPath)
        End If
    End Sub

    Private Sub btnExit4_Click(sender As Object, e As EventArgs) Handles btnExit4.Click
        If mshoRandomNumber = 4 Then
            End
        Else
            Dim strPath As String = System.IO.Path.GetDirectoryName(
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\Game.exe"
            System.Diagnostics.Process.Start(strPath)
        End If
    End Sub

    Private Sub btnWTF_Click(sender As Object, e As EventArgs) Handles btnWTF.Click
        MessageBox.Show("One of these exit buttons work, the rest do not. If you choose wrong, the buttons change. Good luck!")
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        mshoRandomNumber = CInt(Int((4 * Rnd()) + 1))
    End Sub
End Class
