<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCreateDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCreateDialog))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListBoxPreviousResponses = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBoxCurrentContext = New System.Windows.Forms.ListBox()
        Me.ButtonClearDialog = New System.Windows.Forms.Button()
        Me.TextBoxDialogName = New System.Windows.Forms.TextBox()
        Me.ButtonSaveDialog = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonClearIntents = New System.Windows.Forms.Button()
        Me.ButtonRemoveIntent = New System.Windows.Forms.Button()
        Me.ButtonEditIntent = New System.Windows.Forms.Button()
        Me.ButtonADDIntent = New System.Windows.Forms.Button()
        Me.ListBoxIntentsList = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxEntityListName = New System.Windows.Forms.TextBox()
        Me.ButtonClearEntityLists = New System.Windows.Forms.Button()
        Me.ButtonRemoveEntityList = New System.Windows.Forms.Button()
        Me.ButtonEditEntityList = New System.Windows.Forms.Button()
        Me.ListBoxEntityLists = New System.Windows.Forms.ListBox()
        Me.ButtonADDEntityList = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.BackgroundImage = Global.DialogManager.My.Resources.Resources.Console_B
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.ButtonClearDialog)
        Me.GroupBox1.Controls.Add(Me.TextBoxDialogName)
        Me.GroupBox1.Controls.Add(Me.ButtonSaveDialog)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1059, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dialog Name"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListBoxPreviousResponses)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(620, 57)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(215, 140)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Previous Response"
        '
        'ListBoxPreviousResponses
        '
        Me.ListBoxPreviousResponses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxPreviousResponses.FormattingEnabled = True
        Me.ListBoxPreviousResponses.ItemHeight = 19
        Me.ListBoxPreviousResponses.Location = New System.Drawing.Point(3, 22)
        Me.ListBoxPreviousResponses.Name = "ListBoxPreviousResponses"
        Me.ListBoxPreviousResponses.ScrollAlwaysVisible = True
        Me.ListBoxPreviousResponses.Size = New System.Drawing.Size(209, 115)
        Me.ListBoxPreviousResponses.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBoxCurrentContext)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(835, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 140)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Context"
        '
        'ListBoxCurrentContext
        '
        Me.ListBoxCurrentContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxCurrentContext.FormattingEnabled = True
        Me.ListBoxCurrentContext.ItemHeight = 19
        Me.ListBoxCurrentContext.Location = New System.Drawing.Point(3, 22)
        Me.ListBoxCurrentContext.Name = "ListBoxCurrentContext"
        Me.ListBoxCurrentContext.ScrollAlwaysVisible = True
        Me.ListBoxCurrentContext.Size = New System.Drawing.Size(215, 115)
        Me.ListBoxCurrentContext.TabIndex = 0
        '
        'ButtonClearDialog
        '
        Me.ButtonClearDialog.BackColor = System.Drawing.Color.Black
        Me.ButtonClearDialog.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearDialog.ForeColor = System.Drawing.Color.White
        Me.ButtonClearDialog.Image = CType(resources.GetObject("ButtonClearDialog.Image"), System.Drawing.Image)
        Me.ButtonClearDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearDialog.Location = New System.Drawing.Point(151, 127)
        Me.ButtonClearDialog.Name = "ButtonClearDialog"
        Me.ButtonClearDialog.Size = New System.Drawing.Size(96, 44)
        Me.ButtonClearDialog.TabIndex = 13
        Me.ButtonClearDialog.Text = "Clear"
        Me.ButtonClearDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClearDialog.UseVisualStyleBackColor = False
        '
        'TextBoxDialogName
        '
        Me.TextBoxDialogName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxDialogName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxDialogName.Enabled = False
        Me.TextBoxDialogName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDialogName.Location = New System.Drawing.Point(3, 22)
        Me.TextBoxDialogName.Name = "TextBoxDialogName"
        Me.TextBoxDialogName.Size = New System.Drawing.Size(1053, 35)
        Me.TextBoxDialogName.TabIndex = 0
        '
        'ButtonSaveDialog
        '
        Me.ButtonSaveDialog.BackColor = System.Drawing.Color.Black
        Me.ButtonSaveDialog.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveDialog.ForeColor = System.Drawing.Color.White
        Me.ButtonSaveDialog.Image = CType(resources.GetObject("ButtonSaveDialog.Image"), System.Drawing.Image)
        Me.ButtonSaveDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSaveDialog.Location = New System.Drawing.Point(151, 77)
        Me.ButtonSaveDialog.Name = "ButtonSaveDialog"
        Me.ButtonSaveDialog.Size = New System.Drawing.Size(96, 44)
        Me.ButtonSaveDialog.TabIndex = 15
        Me.ButtonSaveDialog.Text = "SAVE"
        Me.ButtonSaveDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSaveDialog.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Green
        Me.GroupBox2.BackgroundImage = Global.DialogManager.My.Resources.Resources.Console_B
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.ButtonClearIntents)
        Me.GroupBox2.Controls.Add(Me.ButtonRemoveIntent)
        Me.GroupBox2.Controls.Add(Me.ButtonEditIntent)
        Me.GroupBox2.Controls.Add(Me.ButtonADDIntent)
        Me.GroupBox2.Controls.Add(Me.ListBoxIntentsList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkViolet
        Me.GroupBox2.Location = New System.Drawing.Point(0, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 393)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manage Intents"
        '
        'ButtonClearIntents
        '
        Me.ButtonClearIntents.BackColor = System.Drawing.Color.Black
        Me.ButtonClearIntents.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearIntents.ForeColor = System.Drawing.Color.White
        Me.ButtonClearIntents.Image = CType(resources.GetObject("ButtonClearIntents.Image"), System.Drawing.Image)
        Me.ButtonClearIntents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearIntents.Location = New System.Drawing.Point(369, 50)
        Me.ButtonClearIntents.Name = "ButtonClearIntents"
        Me.ButtonClearIntents.Size = New System.Drawing.Size(93, 50)
        Me.ButtonClearIntents.TabIndex = 12
        Me.ButtonClearIntents.Text = "Clear"
        Me.ButtonClearIntents.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClearIntents.UseVisualStyleBackColor = False
        '
        'ButtonRemoveIntent
        '
        Me.ButtonRemoveIntent.BackColor = System.Drawing.Color.Black
        Me.ButtonRemoveIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveIntent.ForeColor = System.Drawing.Color.White
        Me.ButtonRemoveIntent.Image = CType(resources.GetObject("ButtonRemoveIntent.Image"), System.Drawing.Image)
        Me.ButtonRemoveIntent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRemoveIntent.Location = New System.Drawing.Point(267, 50)
        Me.ButtonRemoveIntent.Name = "ButtonRemoveIntent"
        Me.ButtonRemoveIntent.Size = New System.Drawing.Size(96, 50)
        Me.ButtonRemoveIntent.TabIndex = 13
        Me.ButtonRemoveIntent.Text = "Remove"
        Me.ButtonRemoveIntent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRemoveIntent.UseVisualStyleBackColor = False
        '
        'ButtonEditIntent
        '
        Me.ButtonEditIntent.BackColor = System.Drawing.Color.Black
        Me.ButtonEditIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditIntent.ForeColor = System.Drawing.Color.White
        Me.ButtonEditIntent.Image = CType(resources.GetObject("ButtonEditIntent.Image"), System.Drawing.Image)
        Me.ButtonEditIntent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEditIntent.Location = New System.Drawing.Point(168, 50)
        Me.ButtonEditIntent.Name = "ButtonEditIntent"
        Me.ButtonEditIntent.Size = New System.Drawing.Size(93, 50)
        Me.ButtonEditIntent.TabIndex = 14
        Me.ButtonEditIntent.Text = "Edit"
        Me.ButtonEditIntent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEditIntent.UseVisualStyleBackColor = False
        '
        'ButtonADDIntent
        '
        Me.ButtonADDIntent.BackColor = System.Drawing.Color.Black
        Me.ButtonADDIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADDIntent.ForeColor = System.Drawing.Color.White
        Me.ButtonADDIntent.Image = CType(resources.GetObject("ButtonADDIntent.Image"), System.Drawing.Image)
        Me.ButtonADDIntent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonADDIntent.Location = New System.Drawing.Point(66, 49)
        Me.ButtonADDIntent.Name = "ButtonADDIntent"
        Me.ButtonADDIntent.Size = New System.Drawing.Size(96, 51)
        Me.ButtonADDIntent.TabIndex = 15
        Me.ButtonADDIntent.Text = "ADD"
        Me.ButtonADDIntent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonADDIntent.UseVisualStyleBackColor = False
        '
        'ListBoxIntentsList
        '
        Me.ListBoxIntentsList.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxIntentsList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxIntentsList.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxIntentsList.FormattingEnabled = True
        Me.ListBoxIntentsList.ItemHeight = 20
        Me.ListBoxIntentsList.Location = New System.Drawing.Point(3, 146)
        Me.ListBoxIntentsList.Name = "ListBoxIntentsList"
        Me.ListBoxIntentsList.Size = New System.Drawing.Size(462, 244)
        Me.ListBoxIntentsList.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.BackgroundImage = Global.DialogManager.My.Resources.Resources.Console_C
        Me.GroupBox3.Controls.Add(Me.TextBoxEntityListName)
        Me.GroupBox3.Controls.Add(Me.ButtonClearEntityLists)
        Me.GroupBox3.Controls.Add(Me.ButtonRemoveEntityList)
        Me.GroupBox3.Controls.Add(Me.ButtonEditEntityList)
        Me.GroupBox3.Controls.Add(Me.ListBoxEntityLists)
        Me.GroupBox3.Controls.Add(Me.ButtonADDEntityList)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox3.Location = New System.Drawing.Point(468, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(591, 393)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manage Entity Lists"
        '
        'TextBoxEntityListName
        '
        Me.TextBoxEntityListName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxEntityListName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxEntityListName.Location = New System.Drawing.Point(3, 115)
        Me.TextBoxEntityListName.Name = "TextBoxEntityListName"
        Me.TextBoxEntityListName.Size = New System.Drawing.Size(585, 31)
        Me.TextBoxEntityListName.TabIndex = 16
        '
        'ButtonClearEntityLists
        '
        Me.ButtonClearEntityLists.BackColor = System.Drawing.Color.Black
        Me.ButtonClearEntityLists.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearEntityLists.ForeColor = System.Drawing.Color.White
        Me.ButtonClearEntityLists.Image = CType(resources.GetObject("ButtonClearEntityLists.Image"), System.Drawing.Image)
        Me.ButtonClearEntityLists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClearEntityLists.Location = New System.Drawing.Point(480, 31)
        Me.ButtonClearEntityLists.Name = "ButtonClearEntityLists"
        Me.ButtonClearEntityLists.Size = New System.Drawing.Size(93, 46)
        Me.ButtonClearEntityLists.TabIndex = 12
        Me.ButtonClearEntityLists.Text = "Clear"
        Me.ButtonClearEntityLists.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClearEntityLists.UseVisualStyleBackColor = False
        '
        'ButtonRemoveEntityList
        '
        Me.ButtonRemoveEntityList.BackColor = System.Drawing.Color.Black
        Me.ButtonRemoveEntityList.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveEntityList.ForeColor = System.Drawing.Color.White
        Me.ButtonRemoveEntityList.Image = CType(resources.GetObject("ButtonRemoveEntityList.Image"), System.Drawing.Image)
        Me.ButtonRemoveEntityList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRemoveEntityList.Location = New System.Drawing.Point(358, 31)
        Me.ButtonRemoveEntityList.Name = "ButtonRemoveEntityList"
        Me.ButtonRemoveEntityList.Size = New System.Drawing.Size(113, 46)
        Me.ButtonRemoveEntityList.TabIndex = 13
        Me.ButtonRemoveEntityList.Text = "Remove"
        Me.ButtonRemoveEntityList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRemoveEntityList.UseVisualStyleBackColor = False
        '
        'ButtonEditEntityList
        '
        Me.ButtonEditEntityList.BackColor = System.Drawing.Color.Black
        Me.ButtonEditEntityList.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditEntityList.ForeColor = System.Drawing.Color.White
        Me.ButtonEditEntityList.Image = CType(resources.GetObject("ButtonEditEntityList.Image"), System.Drawing.Image)
        Me.ButtonEditEntityList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEditEntityList.Location = New System.Drawing.Point(256, 31)
        Me.ButtonEditEntityList.Name = "ButtonEditEntityList"
        Me.ButtonEditEntityList.Size = New System.Drawing.Size(93, 46)
        Me.ButtonEditEntityList.TabIndex = 14
        Me.ButtonEditEntityList.Text = "Edit"
        Me.ButtonEditEntityList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEditEntityList.UseVisualStyleBackColor = False
        '
        'ListBoxEntityLists
        '
        Me.ListBoxEntityLists.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxEntityLists.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxEntityLists.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEntityLists.FormattingEnabled = True
        Me.ListBoxEntityLists.ItemHeight = 20
        Me.ListBoxEntityLists.Location = New System.Drawing.Point(3, 146)
        Me.ListBoxEntityLists.Name = "ListBoxEntityLists"
        Me.ListBoxEntityLists.Size = New System.Drawing.Size(585, 244)
        Me.ListBoxEntityLists.TabIndex = 0
        '
        'ButtonADDEntityList
        '
        Me.ButtonADDEntityList.BackColor = System.Drawing.Color.Black
        Me.ButtonADDEntityList.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADDEntityList.ForeColor = System.Drawing.Color.White
        Me.ButtonADDEntityList.Image = CType(resources.GetObject("ButtonADDEntityList.Image"), System.Drawing.Image)
        Me.ButtonADDEntityList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonADDEntityList.Location = New System.Drawing.Point(155, 30)
        Me.ButtonADDEntityList.Name = "ButtonADDEntityList"
        Me.ButtonADDEntityList.Size = New System.Drawing.Size(93, 47)
        Me.ButtonADDEntityList.TabIndex = 15
        Me.ButtonADDEntityList.Text = "ADD"
        Me.ButtonADDEntityList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonADDEntityList.UseVisualStyleBackColor = False
        '
        'FormCreateDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1059, 593)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCreateDialog"
        Me.Text = "Create Dialog"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBoxIntentsList As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBoxEntityLists As ListBox
    Friend WithEvents ButtonClearIntents As Button
    Friend WithEvents ButtonRemoveIntent As Button
    Friend WithEvents ButtonEditIntent As Button
    Friend WithEvents ButtonADDIntent As Button
    Friend WithEvents ButtonClearEntityLists As Button
    Friend WithEvents ButtonRemoveEntityList As Button
    Friend WithEvents ButtonEditEntityList As Button
    Friend WithEvents ButtonADDEntityList As Button
    Friend WithEvents ButtonClearDialog As Button
    Friend WithEvents TextBoxDialogName As TextBox
    Friend WithEvents ButtonSaveDialog As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ListBoxCurrentContext As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ListBoxPreviousResponses As ListBox
    Friend WithEvents TextBoxEntityListName As TextBox
End Class
