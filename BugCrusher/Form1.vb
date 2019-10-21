Public Class game
    'varribles being declared'
    Private IntScore As Integer = 0
    Private IntTime As Integer = 0
    Private IntXVel As Integer = 10
    Private IntYVel As Integer = 10
    Private MaxScore As Integer = 7
    Dim this = Me

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monster1.Click
        ' randomize movement using system'
        Randomize()
        Monster1.Top = Rnd() * 400
        Monster1.Left = Rnd() * 400
        Monster1.Width = Monster1.Width * 0.9
        Monster1.Height = Monster1.Height * 0.9
        'adding score points and displaying points'
        IntScore = IntScore + 1
        lbl_score.Text = IntScore
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        IntTime = IntTime - 1
        lbl_time.Text = IntTime
        If IntTime = 0 And IntScore > MaxScore Then
            Call Win()
        End If
        If IntTime = 0 Then
            Timer.Enabled = False
            MsgBox("game over")
        End If
    End Sub

    Private Sub mob_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mob.Tick
        Monster1.Top = Monster1.Top + IntYVel
        Monster1.Left = Monster1.Left + IntXVel
        ' right'
        If Monster1.Right > this.Width Then
            IntXVel = -IntXVel
        End If
        'left'

        If Monster1.Left < 0 Then
            IntXVel = -IntXVel
        End If
        'bottom'
        If Monster1.Bottom > this.Height Then
            IntYVel = -IntYVel
            'top'
        End If
        If Monster1.Top < 0 Then
            IntYVel = -IntYVel
        End If
    End Sub

    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        IntTime = 30
        IntScore = 0
        lbl_time.Text = IntTime
        lbl_score.Text = IntScore
        Timer.Enabled = True
        mob.Enabled = True
    End Sub
    Private Sub Win()
        mob.Enabled = False
        Timer.Enabled = False
        IntTime = 30
        IntScore = 0
        lbl_time.Text = IntTime
        lbl_score.Text = IntScore
        MsgBox("you won")



    End Sub


    Private Sub game_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        IntScore = IntScore + -1
        lbl_score.Text = IntScore

    End Sub
End Class
