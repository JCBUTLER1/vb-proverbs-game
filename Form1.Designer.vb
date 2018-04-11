<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(220, 94)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(42, 20)
        Me.txtAnswer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "True (T) or False (F)"
        '
        'btnDisplay
        '
        Me.btnDisplay.AutoSize = True
        Me.btnDisplay.Location = New System.Drawing.Point(85, 158)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(84, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Show Proverb"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.AutoSize = True
        Me.btnAnswer.Location = New System.Drawing.Point(205, 158)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(90, 23)
        Me.btnAnswer.TabIndex = 3
        Me.btnAnswer.Text = "Record Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(44, 37)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(296, 23)
        Me.lblCorrectAnswer.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 255)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Name = "Form1"
        Me.Text = "Proverbs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAnswer As Button
    Friend WithEvents lblCorrectAnswer As Label
End Class
