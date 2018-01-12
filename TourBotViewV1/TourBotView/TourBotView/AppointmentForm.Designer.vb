<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentForm
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Book = New System.Windows.Forms.Button()
        Me.bookAppLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(42, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Book
        '
        Me.Book.Location = New System.Drawing.Point(84, 153)
        Me.Book.Name = "Book"
        Me.Book.Size = New System.Drawing.Size(116, 23)
        Me.Book.TabIndex = 1
        Me.Book.Text = "Book Appointment"
        Me.Book.UseVisualStyleBackColor = True
        '
        'bookAppLabel
        '
        Me.bookAppLabel.AutoSize = True
        Me.bookAppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookAppLabel.Location = New System.Drawing.Point(81, 62)
        Me.bookAppLabel.Name = "bookAppLabel"
        Me.bookAppLabel.Size = New System.Drawing.Size(109, 16)
        Me.bookAppLabel.TabIndex = 2
        Me.bookAppLabel.Text = "Choose the date:"
        Me.bookAppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bookAppLabel)
        Me.Controls.Add(Me.Book)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "AppointmentForm"
        Me.Text = "Appointment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Book As Button
    Friend WithEvents bookAppLabel As Label
End Class
