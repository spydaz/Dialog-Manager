<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChatWIndow
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TextBoxViewIntent = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ListBoxParameters = New System.Windows.Forms.ListBox()
        Me.GroupBoxUserinput = New System.Windows.Forms.GroupBox()
        Me.ButtonSendQuery = New System.Windows.Forms.Button()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TextBoxPreviousIntent = New System.Windows.Forms.TextBox()
        Me.TextBoxDetectedIntent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxCurrentIntents = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBoxIntentHistory = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBoxUserinput.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.GroupBox12)
        Me.GroupBox5.Controls.Add(Me.GroupBox11)
        Me.GroupBox5.Controls.Add(Me.GroupBoxUserinput)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(1272, 644)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Test Dialog interface"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TextBoxViewIntent)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox12.ForeColor = System.Drawing.Color.White
        Me.GroupBox12.Location = New System.Drawing.Point(200, 374)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox12.Size = New System.Drawing.Size(712, 268)
        Me.GroupBox12.TabIndex = 7
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "ViewIntent"
        '
        'TextBoxViewIntent
        '
        Me.TextBoxViewIntent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxViewIntent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxViewIntent.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxViewIntent.Location = New System.Drawing.Point(3, 26)
        Me.TextBoxViewIntent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxViewIntent.Multiline = True
        Me.TextBoxViewIntent.Name = "TextBoxViewIntent"
        Me.TextBoxViewIntent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxViewIntent.Size = New System.Drawing.Size(706, 240)
        Me.TextBoxViewIntent.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox11.Controls.Add(Me.ListBoxParameters)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(3, 374)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox11.Size = New System.Drawing.Size(197, 268)
        Me.GroupBox11.TabIndex = 6
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Found Parameters"
        '
        'ListBoxParameters
        '
        Me.ListBoxParameters.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxParameters.FormattingEnabled = True
        Me.ListBoxParameters.ItemHeight = 25
        Me.ListBoxParameters.Location = New System.Drawing.Point(3, 26)
        Me.ListBoxParameters.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxParameters.Name = "ListBoxParameters"
        Me.ListBoxParameters.Size = New System.Drawing.Size(191, 240)
        Me.ListBoxParameters.TabIndex = 5
        '
        'GroupBoxUserinput
        '
        Me.GroupBoxUserinput.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBoxUserinput.Controls.Add(Me.ButtonSendQuery)
        Me.GroupBoxUserinput.Controls.Add(Me.TextBoxInput)
        Me.GroupBoxUserinput.Controls.Add(Me.Label3)
        Me.GroupBoxUserinput.Controls.Add(Me.TextBoxOutput)
        Me.GroupBoxUserinput.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxUserinput.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxUserinput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxUserinput.Location = New System.Drawing.Point(3, 26)
        Me.GroupBoxUserinput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxUserinput.Name = "GroupBoxUserinput"
        Me.GroupBoxUserinput.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxUserinput.Size = New System.Drawing.Size(909, 348)
        Me.GroupBoxUserinput.TabIndex = 5
        Me.GroupBoxUserinput.TabStop = False
        Me.GroupBoxUserinput.Text = "Responses"
        '
        'ButtonSendQuery
        '
        Me.ButtonSendQuery.BackColor = System.Drawing.Color.Silver
        Me.ButtonSendQuery.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSendQuery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonSendQuery.Location = New System.Drawing.Point(797, 293)
        Me.ButtonSendQuery.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSendQuery.Name = "ButtonSendQuery"
        Me.ButtonSendQuery.Size = New System.Drawing.Size(109, 53)
        Me.ButtonSendQuery.TabIndex = 6
        Me.ButtonSendQuery.Text = "Ask"
        Me.ButtonSendQuery.UseVisualStyleBackColor = False
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxInput.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxInput.Location = New System.Drawing.Point(3, 293)
        Me.TextBoxInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(788, 31)
        Me.TextBoxInput.TabIndex = 5
        Me.TextBoxInput.Tag = "Enter User Querys here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Input Text here"
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxOutput.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxOutput.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOutput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxOutput.Location = New System.Drawing.Point(3, 26)
        Me.TextBoxOutput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxOutput.Multiline = True
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOutput.Size = New System.Drawing.Size(903, 242)
        Me.TextBoxOutput.TabIndex = 0
        Me.TextBoxOutput.Tag = "Displays Test Output"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox6.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(912, 26)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(357, 616)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Diagnose"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.ListBoxCurrentIntents)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.ListBoxIntentHistory)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox7.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(351, 586)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.TextBoxDetectedIntent)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox8.Location = New System.Drawing.Point(3, 105)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(345, 225)
        Me.GroupBox8.TabIndex = 10
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Detected Intent"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TextBoxPreviousIntent)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox9.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(339, 73)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Previous Intent"
        '
        'TextBoxPreviousIntent
        '
        Me.TextBoxPreviousIntent.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxPreviousIntent.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxPreviousIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPreviousIntent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxPreviousIntent.Location = New System.Drawing.Point(3, 26)
        Me.TextBoxPreviousIntent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxPreviousIntent.Name = "TextBoxPreviousIntent"
        Me.TextBoxPreviousIntent.Size = New System.Drawing.Size(333, 31)
        Me.TextBoxPreviousIntent.TabIndex = 3
        Me.TextBoxPreviousIntent.Tag = "Previous Detcted Intent"
        '
        'TextBoxDetectedIntent
        '
        Me.TextBoxDetectedIntent.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxDetectedIntent.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxDetectedIntent.Location = New System.Drawing.Point(3, 26)
        Me.TextBoxDetectedIntent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxDetectedIntent.Name = "TextBoxDetectedIntent"
        Me.TextBoxDetectedIntent.Size = New System.Drawing.Size(339, 31)
        Me.TextBoxDetectedIntent.TabIndex = 0
        Me.TextBoxDetectedIntent.Tag = "Current Detected intent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(3, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "History"
        '
        'ListBoxCurrentIntents
        '
        Me.ListBoxCurrentIntents.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxCurrentIntents.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListBoxCurrentIntents.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCurrentIntents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListBoxCurrentIntents.FormattingEnabled = True
        Me.ListBoxCurrentIntents.ItemHeight = 25
        Me.ListBoxCurrentIntents.Location = New System.Drawing.Point(3, 51)
        Me.ListBoxCurrentIntents.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxCurrentIntents.Name = "ListBoxCurrentIntents"
        Me.ListBoxCurrentIntents.ScrollAlwaysVisible = True
        Me.ListBoxCurrentIntents.Size = New System.Drawing.Size(345, 54)
        Me.ListBoxCurrentIntents.TabIndex = 6
        Me.ListBoxCurrentIntents.Tag = "Current Topics / Intents (PreRequisites Collected)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Current Topic / Context"
        '
        'ListBoxIntentHistory
        '
        Me.ListBoxIntentHistory.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxIntentHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxIntentHistory.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxIntentHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListBoxIntentHistory.FormattingEnabled = True
        Me.ListBoxIntentHistory.ItemHeight = 25
        Me.ListBoxIntentHistory.Location = New System.Drawing.Point(3, 355)
        Me.ListBoxIntentHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxIntentHistory.Name = "ListBoxIntentHistory"
        Me.ListBoxIntentHistory.ScrollAlwaysVisible = True
        Me.ListBoxIntentHistory.Size = New System.Drawing.Size(345, 229)
        Me.ListBoxIntentHistory.TabIndex = 0
        Me.ListBoxIntentHistory.Tag = "History of  Intents PAst"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Previous Intent"
        '
        'FormChatWIndow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 644)
        Me.Controls.Add(Me.GroupBox5)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormChatWIndow"
        Me.Text = "Dialog Test Interface"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBoxUserinput.ResumeLayout(False)
        Me.GroupBoxUserinput.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents TextBoxViewIntent As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents ListBoxParameters As ListBox
    Friend WithEvents GroupBoxUserinput As GroupBox
    Friend WithEvents ButtonSendQuery As Button
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TextBoxPreviousIntent As TextBox
    Friend WithEvents TextBoxDetectedIntent As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxCurrentIntents As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBoxIntentHistory As ListBox
    Friend WithEvents Label7 As Label
End Class
