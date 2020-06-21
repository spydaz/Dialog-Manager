<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCreateAction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCreateAction))
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonActionScriptClear = New System.Windows.Forms.Button()
        Me.ButtonSaveGeneratedOutputParamter = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxResponse = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxActionScript = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxActionDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxActionName = New System.Windows.Forms.TextBox()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.Gray
        Me.GroupBox14.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.GroupBox14.Controls.Add(Me.ButtonClose)
        Me.GroupBox14.Controls.Add(Me.ButtonActionScriptClear)
        Me.GroupBox14.Controls.Add(Me.ButtonSaveGeneratedOutputParamter)
        Me.GroupBox14.Controls.Add(Me.GroupBox3)
        Me.GroupBox14.Controls.Add(Me.GroupBox1)
        Me.GroupBox14.Controls.Add(Me.GroupBox11)
        Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.Color.White
        Me.GroupBox14.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(435, 553)
        Me.GroupBox14.TabIndex = 12
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Fulfilment / Action Script"
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Black
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.Black
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.Location = New System.Drawing.Point(283, 233)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(140, 46)
        Me.ButtonClose.TabIndex = 32
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ButtonActionScriptClear
        '
        Me.ButtonActionScriptClear.BackColor = System.Drawing.Color.Black
        Me.ButtonActionScriptClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActionScriptClear.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActionScriptClear.ForeColor = System.Drawing.Color.Black
        Me.ButtonActionScriptClear.Image = CType(resources.GetObject("ButtonActionScriptClear.Image"), System.Drawing.Image)
        Me.ButtonActionScriptClear.Location = New System.Drawing.Point(139, 233)
        Me.ButtonActionScriptClear.Name = "ButtonActionScriptClear"
        Me.ButtonActionScriptClear.Size = New System.Drawing.Size(140, 46)
        Me.ButtonActionScriptClear.TabIndex = 32
        Me.ButtonActionScriptClear.Text = "Clear"
        Me.ButtonActionScriptClear.UseVisualStyleBackColor = False
        '
        'ButtonSaveGeneratedOutputParamter
        '
        Me.ButtonSaveGeneratedOutputParamter.BackColor = System.Drawing.Color.Black
        Me.ButtonSaveGeneratedOutputParamter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveGeneratedOutputParamter.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveGeneratedOutputParamter.ForeColor = System.Drawing.Color.Black
        Me.ButtonSaveGeneratedOutputParamter.Image = Global.DialogManager.My.Resources.Resources.vector_look
        Me.ButtonSaveGeneratedOutputParamter.Location = New System.Drawing.Point(6, 233)
        Me.ButtonSaveGeneratedOutputParamter.Name = "ButtonSaveGeneratedOutputParamter"
        Me.ButtonSaveGeneratedOutputParamter.Size = New System.Drawing.Size(140, 46)
        Me.ButtonSaveGeneratedOutputParamter.TabIndex = 32
        Me.ButtonSaveGeneratedOutputParamter.Text = "Save"
        Me.ButtonSaveGeneratedOutputParamter.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.GroupBox3.Controls.Add(Me.TextBoxResponse)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(3, 163)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 63)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Response"
        '
        'TextBoxResponse
        '
        Me.TextBoxResponse.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxResponse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxResponse.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResponse.ForeColor = System.Drawing.Color.Black
        Me.TextBoxResponse.Location = New System.Drawing.Point(3, 34)
        Me.TextBoxResponse.Name = "TextBoxResponse"
        Me.TextBoxResponse.Size = New System.Drawing.Size(423, 26)
        Me.TextBoxResponse.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.GroupBox1.Controls.Add(Me.TextBoxActionScript)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 274)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Script"
        '
        'TextBoxActionScript
        '
        Me.TextBoxActionScript.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxActionScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxActionScript.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActionScript.ForeColor = System.Drawing.Color.Black
        Me.TextBoxActionScript.Location = New System.Drawing.Point(3, 22)
        Me.TextBoxActionScript.Multiline = True
        Me.TextBoxActionScript.Name = "TextBoxActionScript"
        Me.TextBoxActionScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxActionScript.Size = New System.Drawing.Size(423, 249)
        Me.TextBoxActionScript.TabIndex = 1
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Gray
        Me.GroupBox11.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.GroupBox11.Controls.Add(Me.Label1)
        Me.GroupBox11.Controls.Add(Me.TextBoxActionDescription)
        Me.GroupBox11.Controls.Add(Me.TextBoxActionName)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(429, 141)
        Me.GroupBox11.TabIndex = 23
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Description"
        '
        'TextBoxActionDescription
        '
        Me.TextBoxActionDescription.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxActionDescription.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxActionDescription.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActionDescription.ForeColor = System.Drawing.Color.Black
        Me.TextBoxActionDescription.Location = New System.Drawing.Point(3, 68)
        Me.TextBoxActionDescription.Multiline = True
        Me.TextBoxActionDescription.Name = "TextBoxActionDescription"
        Me.TextBoxActionDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxActionDescription.Size = New System.Drawing.Size(423, 70)
        Me.TextBoxActionDescription.TabIndex = 25
        '
        'TextBoxActionName
        '
        Me.TextBoxActionName.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxActionName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxActionName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActionName.ForeColor = System.Drawing.Color.Black
        Me.TextBoxActionName.Location = New System.Drawing.Point(3, 22)
        Me.TextBoxActionName.Name = "TextBoxActionName"
        Me.TextBoxActionName.Size = New System.Drawing.Size(423, 26)
        Me.TextBoxActionName.TabIndex = 19
        '
        'FormCreateAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 553)
        Me.Controls.Add(Me.GroupBox14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCreateAction"
        Me.Text = "CreateAction"
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxResponse As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxActionScript As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxActionDescription As TextBox
    Friend WithEvents TextBoxActionName As TextBox
    Friend WithEvents ButtonSaveGeneratedOutputParamter As Button
    Friend WithEvents ButtonActionScriptClear As Button
    Friend WithEvents ButtonClose As Button
End Class
