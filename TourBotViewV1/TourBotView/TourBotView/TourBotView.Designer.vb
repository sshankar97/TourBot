<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TourBotView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.TiltUpButton = New System.Windows.Forms.Button()
        Me.TiltDownButton = New System.Windows.Forms.Button()
        Me.TourBotScreen = New System.Windows.Forms.PictureBox()
        Me.QueueInfoLabel = New System.Windows.Forms.Label()
        Me.TimeInfoLabel = New System.Windows.Forms.Label()
        Me.QueueTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ControlTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.ActualLocationLabel = New System.Windows.Forms.Label()
        Me.PictureButton = New System.Windows.Forms.Button()
        Me.VideoButton = New System.Windows.Forms.Button()
        Me.RecordingLabel = New System.Windows.Forms.Label()
        CType(Me.TourBotScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftButton
        '
        Me.LeftButton.BackgroundImage = Global.TourBotView.My.Resources.res.LeftArrow
        Me.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LeftButton.Location = New System.Drawing.Point(12, 393)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(75, 23)
        Me.LeftButton.TabIndex = 0
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.BackgroundImage = Global.TourBotView.My.Resources.res.RightArrow
        Me.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RightButton.Location = New System.Drawing.Point(139, 393)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(75, 23)
        Me.RightButton.TabIndex = 1
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.BackgroundImage = Global.TourBotView.My.Resources.res.UpArrow
        Me.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UpButton.Location = New System.Drawing.Point(73, 364)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(75, 23)
        Me.UpButton.TabIndex = 2
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.BackgroundImage = Global.TourBotView.My.Resources.res.DownArrow
        Me.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DownButton.Location = New System.Drawing.Point(73, 422)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(75, 23)
        Me.DownButton.TabIndex = 3
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'TiltUpButton
        '
        Me.TiltUpButton.BackgroundImage = Global.TourBotView.My.Resources.res.TiltUpArrow
        Me.TiltUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TiltUpButton.Location = New System.Drawing.Point(236, 363)
        Me.TiltUpButton.Name = "TiltUpButton"
        Me.TiltUpButton.Size = New System.Drawing.Size(75, 23)
        Me.TiltUpButton.TabIndex = 4
        Me.TiltUpButton.UseVisualStyleBackColor = True
        '
        'TiltDownButton
        '
        Me.TiltDownButton.BackgroundImage = Global.TourBotView.My.Resources.res.TiltDownArrow
        Me.TiltDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TiltDownButton.Location = New System.Drawing.Point(236, 415)
        Me.TiltDownButton.Name = "TiltDownButton"
        Me.TiltDownButton.Size = New System.Drawing.Size(75, 23)
        Me.TiltDownButton.TabIndex = 5
        Me.TiltDownButton.UseVisualStyleBackColor = True
        '
        'TourBotScreen
        '
        Me.TourBotScreen.BackgroundImage = Global.TourBotView.My.Resources.res.GiraffeCentreOut
        Me.TourBotScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TourBotScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TourBotScreen.Location = New System.Drawing.Point(236, 13)
        Me.TourBotScreen.Name = "TourBotScreen"
        Me.TourBotScreen.Size = New System.Drawing.Size(401, 344)
        Me.TourBotScreen.TabIndex = 6
        Me.TourBotScreen.TabStop = False
        '
        'QueueInfoLabel
        '
        Me.QueueInfoLabel.AutoSize = True
        Me.QueueInfoLabel.Location = New System.Drawing.Point(12, 13)
        Me.QueueInfoLabel.Name = "QueueInfoLabel"
        Me.QueueInfoLabel.Size = New System.Drawing.Size(195, 13)
        Me.QueueInfoLabel.TabIndex = 7
        Me.QueueInfoLabel.Text = "You are currently in control of TourBot 1"
        '
        'TimeInfoLabel
        '
        Me.TimeInfoLabel.AutoSize = True
        Me.TimeInfoLabel.Location = New System.Drawing.Point(12, 42)
        Me.TimeInfoLabel.Name = "TimeInfoLabel"
        Me.TimeInfoLabel.Size = New System.Drawing.Size(184, 13)
        Me.TimeInfoLabel.TabIndex = 8
        Me.TimeInfoLabel.Text = "Time Left in Control of TourBot: 10:00"
        '
        'QueueTimer
        '
        Me.QueueTimer.Interval = 3000
        '
        'ControlTimer
        '
        Me.ControlTimer.Interval = 1000
        '
        'LeaveButton
        '
        Me.LeaveButton.Location = New System.Drawing.Point(73, 88)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(75, 23)
        Me.LeaveButton.TabIndex = 9
        Me.LeaveButton.Text = "Exit Queue"
        Me.LeaveButton.UseVisualStyleBackColor = True
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(376, 372)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(122, 13)
        Me.LocationLabel.TabIndex = 10
        Me.LocationLabel.Text = "Current Exhibit Location:"
        '
        'ActualLocationLabel
        '
        Me.ActualLocationLabel.AutoSize = True
        Me.ActualLocationLabel.Location = New System.Drawing.Point(379, 389)
        Me.ActualLocationLabel.Name = "ActualLocationLabel"
        Me.ActualLocationLabel.Size = New System.Drawing.Size(94, 13)
        Me.ActualLocationLabel.TabIndex = 11
        Me.ActualLocationLabel.Text = "In Front of Giraffes"
        '
        'PictureButton
        '
        Me.PictureButton.Location = New System.Drawing.Point(15, 164)
        Me.PictureButton.Name = "PictureButton"
        Me.PictureButton.Size = New System.Drawing.Size(89, 28)
        Me.PictureButton.TabIndex = 12
        Me.PictureButton.Text = "Take A Picture"
        Me.PictureButton.UseVisualStyleBackColor = True
        '
        'VideoButton
        '
        Me.VideoButton.Location = New System.Drawing.Point(15, 198)
        Me.VideoButton.Name = "VideoButton"
        Me.VideoButton.Size = New System.Drawing.Size(89, 28)
        Me.VideoButton.TabIndex = 13
        Me.VideoButton.Text = "Take A Video"
        Me.VideoButton.UseVisualStyleBackColor = True
        '
        'RecordingLabel
        '
        Me.RecordingLabel.AutoSize = True
        Me.RecordingLabel.Location = New System.Drawing.Point(15, 233)
        Me.RecordingLabel.Name = "RecordingLabel"
        Me.RecordingLabel.Size = New System.Drawing.Size(85, 13)
        Me.RecordingLabel.TabIndex = 14
        Me.RecordingLabel.Text = "Recording Label"
        '
        'TourBotView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 450)
        Me.Controls.Add(Me.RecordingLabel)
        Me.Controls.Add(Me.VideoButton)
        Me.Controls.Add(Me.PictureButton)
        Me.Controls.Add(Me.ActualLocationLabel)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.TimeInfoLabel)
        Me.Controls.Add(Me.QueueInfoLabel)
        Me.Controls.Add(Me.TourBotScreen)
        Me.Controls.Add(Me.TiltDownButton)
        Me.Controls.Add(Me.TiltUpButton)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.RightButton)
        Me.Controls.Add(Me.LeftButton)
        Me.Name = "TourBotView"
        Me.Text = "TourBot"
        CType(Me.TourBotScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LeftButton As Button
    Friend WithEvents RightButton As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents TiltUpButton As Button
    Friend WithEvents TiltDownButton As Button
    Friend WithEvents TourBotScreen As PictureBox
    Friend WithEvents QueueInfoLabel As Label
    Friend WithEvents TimeInfoLabel As Label
    Friend WithEvents QueueTimer As Timer
    Friend WithEvents ControlTimer As Timer
    Friend WithEvents LeaveButton As Button
    Friend WithEvents LocationLabel As Label
    Friend WithEvents ActualLocationLabel As Label
    Friend WithEvents PictureButton As Button
    Friend WithEvents VideoButton As Button
    Friend WithEvents RecordingLabel As Label
End Class
