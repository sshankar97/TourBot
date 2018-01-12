Public Class TourBotView

    Dim currentPos As Integer   'The current position is represented by a int.
    'i.e. 0 is start, 1 is zoom in, 2 is left, 3 is right, 4 is up, 5 is down

    Dim currentTourBot As Integer   'The number of the TourBot that the user is controlling

    Dim currentTime As Integer      'The current elapsed time since the user took control of the TourBot

    Dim shownConfirm As Boolean

    Dim recording As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LeftButton.Enabled = True
        'RightButton.Enabled = True
        'UpButton.Enabled = True
        'DownButton.Enabled = True
        'TiltUpButton.Enabled = True
        'TiltDownButton.Enabled = True

        'LeftButton.Show()
        'RightButton.Show()
        'UpButton.Show()
        'DownButton.Show()
        'TiltUpButton.Show()
        'TiltDownButton.Show()
        'MsgBox("You are first in the queue and have control of the TourBot")

        LeftButton.Enabled = False
        RightButton.Enabled = False
        UpButton.Enabled = False
        DownButton.Enabled = False
        TiltUpButton.Enabled = False
        TiltDownButton.Enabled = False
        PictureButton.Enabled = False
        VideoButton.Enabled = False

        PictureButton.Hide()
        VideoButton.Hide()
        LeftButton.Hide()
        RightButton.Hide()
        UpButton.Hide()
        DownButton.Hide()
        TiltUpButton.Hide()
        TiltDownButton.Hide()

        currentPos = 5

        If (currentPos = 1) Then
            LeftButton.Enabled = True
            RightButton.Enabled = True
            UpButton.Enabled = True
            DownButton.Enabled = True
            TiltUpButton.Enabled = True
            TiltDownButton.Enabled = True

            LeftButton.Show()
            RightButton.Show()
            UpButton.Show()
            DownButton.Show()
            TiltUpButton.Show()
            TiltDownButton.Show()

            ControlTimer.Start()
        Else
            QueueInfoLabel.Text = "Position in queue: " + currentPos.ToString()
            TimeInfoLabel.Hide()
            QueueTimer.Start()
        End If

        currentTime = 0

        shownConfirm = False
        recording = False
        RecordingLabel.Hide()
        RecordingLabel.Text = ""

    End Sub

    Public Sub New(QueueNum As Integer, TourBotNum As Integer)

        'Stuff to do:
        'Do stuff with the specific TourBot that the user selects
        'Taking pictures and/or videos

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If (QueueNum = 1) Then
            LeftButton.Enabled = True
            RightButton.Enabled = True
            UpButton.Enabled = True
            DownButton.Enabled = True
            TiltUpButton.Enabled = True
            TiltDownButton.Enabled = True
            PictureButton.Enabled = True
            VideoButton.Enabled = True

            PictureButton.Show()
            VideoButton.Show()
            LeftButton.Show()
            RightButton.Show()
            UpButton.Show()
            DownButton.Show()
            TiltUpButton.Show()
            TiltDownButton.Show()

            ControlTimer.Start()
            'MsgBox("You are first in the queue and have control of the TourBot")
        Else
            LeftButton.Enabled = False
            RightButton.Enabled = False
            UpButton.Enabled = False
            DownButton.Enabled = False
            TiltUpButton.Enabled = False
            TiltDownButton.Enabled = False
            PictureButton.Enabled = False
            VideoButton.Enabled = False

            PictureButton.Hide()
            VideoButton.Hide()
            LeftButton.Hide()
            RightButton.Hide()
            UpButton.Hide()
            DownButton.Hide()
            TiltUpButton.Hide()
            TiltDownButton.Hide()

            QueueInfoLabel.Text = "Position in queue: " + QueueNum.ToString()
            TimeInfoLabel.Hide()
            QueueTimer.Start()
            'MsgBox("You are currently in the queue with the position of " + QueueNum.ToString())
        End If

        currentPos = QueueNum

        currentTime = 0

        shownConfirm = False
        recording = False
        RecordingLabel.Hide()
        RecordingLabel.Text = ""
    End Sub

    'Updates current position in queue
    Private Sub QueueTimerHandler() Handles QueueTimer.Tick
        If (currentPos > 1) Then
            If (currentPos = 4) Then
                TourBotScreen.BackgroundImage = My.Resources.res.GiraffeDown
            ElseIf (currentPos = 3) Then
                TourBotScreen.BackgroundImage = My.Resources.res.GiraffeLeft
            ElseIf (currentPos = 2) Then
                TourBotScreen.BackgroundImage = My.Resources.res.GiraffeRight
            Else
                TourBotScreen.BackgroundImage = My.Resources.res.GiraffeDown
            End If
            currentPos = currentPos - 1
        End If

        If (currentPos = 1 And shownConfirm = False) Then

            shownConfirm = True

            Dim takeControl As DialogResult
            takeControl = MessageBox.Show("Do you want to take control of the TourBot?", "Take Control of TourBot", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (takeControl = vbYes) Then
                QueueInfoLabel.Text = "You are currently in control of TourBot 1"
                TimeInfoLabel.Show()
                ControlTimer.Start()
                QueueTimer.Stop()

                LeftButton.Enabled = True
                RightButton.Enabled = True
                UpButton.Enabled = True
                DownButton.Enabled = True
                TiltUpButton.Enabled = True
                TiltDownButton.Enabled = True
                PictureButton.Enabled = True
                VideoButton.Enabled = True

                PictureButton.Show()
                VideoButton.Show()
                LeftButton.Show()
                RightButton.Show()
                UpButton.Show()
                DownButton.Show()
                TiltUpButton.Show()
                TiltDownButton.Show()

            Else
                Me.Close()
            End If


        Else
            QueueInfoLabel.Text = "Position in queue: " + currentPos.ToString()
        End If
    End Sub

    'Updates time left for controlling TourBot
    Private Sub ControlTimerHandler() Handles ControlTimer.Tick
        currentTime = currentTime + 1
        If (currentTime = 600) Then
            ControlTimer.Stop()
            Dim kickedOut As DialogResult
            kickedOut = MessageBox.Show("You ran out of time", "Kicking user from TourBot", MessageBoxButtons.OK, MessageBoxIcon.Question)
            If (kickedOut = vbOK) Then
                Me.Close()
            End If

        Else
            Dim min As Integer
            Dim sec As Integer
            min = (600 - currentTime) / 60
            sec = (600 - currentTime) Mod 60



            TimeInfoLabel.Text = "Time left in control of the TourBot: " + min.ToString() + ":" + sec.ToString()
            LeaveButton.Text = "Exit TourBot"
        End If
    End Sub

    'Handles all the movement and camera control button clicks
    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        TourBotScreen.BackgroundImage = My.Resources.res.GiraffeCentreIn
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        TourBotScreen.BackgroundImage = My.Resources.res.GiraffeLeft
    End Sub

    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        TourBotScreen.BackgroundImage = My.Resources.res.GiraffeCentreOut
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        TourBotScreen.BackgroundImage = My.Resources.res.GiraffeRight
    End Sub

    Private Sub TiltUpButton_Click(sender As Object, e As EventArgs) Handles TiltUpButton.Click
        TourBotScreen.BackgroundImage = My.Resources.res.GiraffeCentreIn
    End Sub

    Private Sub TiltDownButton_Click(sender As Object, e As EventArgs) Handles TiltDownButton.Click
        TourBotScreen.BackgroundImage = My.Resources.res.GiraffeDown
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Dim answer As DialogResult
        If (LeaveButton.Text.Equals("Exit TourBot")) Then
            answer = MessageBox.Show("Are you sure you want to exit the TourBot?", "Exiting TourBot", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Else
            answer = MessageBox.Show("Are you sure you want to leave the queue?", "Exiting Queue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If

        If (answer = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureButton_Click(sender As Object, e As EventArgs) Handles PictureButton.Click
        MsgBox("Picture Taken")
    End Sub

    Private Sub VideoButton_Click(sender As Object, e As EventArgs) Handles VideoButton.Click
        If (recording = True) Then
            PictureButton.Enabled = True
            VideoButton.Text = "Take A Video"
            MsgBox("Video Taken")
            recording = False
        Else
            PictureButton.Enabled = False
            VideoButton.Text = "Stop Recording"
            recording = True
        End If
    End Sub
End Class
