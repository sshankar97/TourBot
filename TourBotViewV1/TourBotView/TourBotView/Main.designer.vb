<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ExhibitComboBox = New System.Windows.Forms.ComboBox()
        Me.EnterExhibitBTN = New System.Windows.Forms.Button()
        Me.EnterLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitBTN = New System.Windows.Forms.ToolStripButton()
        Me.InfoBTN = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExhibitComboBox
        '
        Me.ExhibitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ExhibitComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ExhibitComboBox.FormattingEnabled = True
        Me.ExhibitComboBox.Items.AddRange(New Object() {"Elephant Exhibit", "Lion Exhibit", "Giraffe Exhibit"})
        Me.ExhibitComboBox.Location = New System.Drawing.Point(27, 116)
        Me.ExhibitComboBox.Name = "ExhibitComboBox"
        Me.ExhibitComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ExhibitComboBox.TabIndex = 0
        '
        'EnterExhibitBTN
        '
        Me.EnterExhibitBTN.Location = New System.Drawing.Point(110, 159)
        Me.EnterExhibitBTN.Name = "EnterExhibitBTN"
        Me.EnterExhibitBTN.Size = New System.Drawing.Size(75, 23)
        Me.EnterExhibitBTN.TabIndex = 1
        Me.EnterExhibitBTN.Text = "Enter"
        Me.EnterExhibitBTN.UseVisualStyleBackColor = True
        '
        'EnterLabel
        '
        Me.EnterLabel.AutoSize = True
        Me.EnterLabel.Location = New System.Drawing.Point(72, 80)
        Me.EnterLabel.Name = "EnterLabel"
        Me.EnterLabel.Size = New System.Drawing.Size(133, 13)
        Me.EnterLabel.TabIndex = 2
        Me.EnterLabel.Text = "Choose an exhibit to enter:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoBTN, Me.ToolStripSeparator1, Me.ExitBTN})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.EnterLabel)
        Me.Controls.Add(Me.EnterExhibitBTN)
        Me.Controls.Add(Me.ExhibitComboBox)
        Me.Name = "Main"
        Me.Text = "TourBot "
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExhibitComboBox As ComboBox
    Friend WithEvents EnterExhibitBTN As Button
    Friend WithEvents EnterLabel As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents InfoBTN As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitBTN As ToolStripButton
End Class
