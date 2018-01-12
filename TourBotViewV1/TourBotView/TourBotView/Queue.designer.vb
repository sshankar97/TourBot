<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Queue
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.InfoBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitBTN = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.changeExhibit = New System.Windows.Forms.Button()
        Me.appointment = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoBTN, Me.ToolStripSeparator1, Me.ExitBTN})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(395, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'InfoBTN
        '
        Me.InfoBTN.BackgroundImage = Global.TourBotView.My.Resources.res.about
        Me.InfoBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfoBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InfoBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InfoBTN.Name = "InfoBTN"
        Me.InfoBTN.Size = New System.Drawing.Size(23, 22)
        Me.InfoBTN.Text = "InfoBTN"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ExitBTN
        '
        Me.ExitBTN.BackgroundImage = Global.TourBotView.My.Resources.res.exit_button_hi1
        Me.ExitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExitBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(23, 22)
        Me.ExitBTN.Text = "ExitBTN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Enter Queue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Enter Queue"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(226, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Enter Queue"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tourbot 1 (3 in queue)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tourbot 2 (2 in queue)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tourbot 3 (4 in queue)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Choose a tourbot to enter the queue for."
        '
        'changeExhibit
        '
        Me.changeExhibit.Location = New System.Drawing.Point(226, 229)
        Me.changeExhibit.Name = "changeExhibit"
        Me.changeExhibit.Size = New System.Drawing.Size(98, 23)
        Me.changeExhibit.TabIndex = 8
        Me.changeExhibit.Text = "Change Exhibit"
        Me.changeExhibit.UseVisualStyleBackColor = True
        '
        'appointment
        '
        Me.appointment.Location = New System.Drawing.Point(70, 229)
        Me.appointment.Name = "appointment"
        Me.appointment.Size = New System.Drawing.Size(109, 23)
        Me.appointment.TabIndex = 9
        Me.appointment.Text = "Book Appointment"
        Me.appointment.UseVisualStyleBackColor = True
        '
        'Queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 265)
        Me.Controls.Add(Me.appointment)
        Me.Controls.Add(Me.changeExhibit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Queue"
        Me.Text = "Queue"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents InfoBTN As ToolStripButton
    Friend WithEvents ExitBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents changeExhibit As Button
    Friend WithEvents appointment As Button
End Class
