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
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.ButtonClearDialog)
        Me.GroupBox1.Controls.Add(Me.TextBoxDialogName)
        Me.GroupBox1.Controls.Add(Me.ButtonSaveDialog)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(887, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dialog Name"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListBoxPreviousResponses)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox5.Location = New System.Drawing.Point(448, 48)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(215, 161)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Previous Response"
        '
        'ListBoxPreviousResponses
        '
        Me.ListBoxPreviousResponses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxPreviousResponses.FormattingEnabled = True
        Me.ListBoxPreviousResponses.ItemHeight = 14
        Me.ListBoxPreviousResponses.Location = New System.Drawing.Point(3, 18)
        Me.ListBoxPreviousResponses.Name = "ListBoxPreviousResponses"
        Me.ListBoxPreviousResponses.ScrollAlwaysVisible = True
        Me.ListBoxPreviousResponses.Size = New System.Drawing.Size(209, 140)
        Me.ListBoxPreviousResponses.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBoxCurrentContext)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox4.Location = New System.Drawing.Point(663, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(221, 161)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Context"
        '
        'ListBoxCurrentContext
        '
        Me.ListBoxCurrentContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxCurrentContext.FormattingEnabled = True
        Me.ListBoxCurrentContext.ItemHeight = 14
        Me.ListBoxCurrentContext.Location = New System.Drawing.Point(3, 18)
        Me.ListBoxCurrentContext.Name = "ListBoxCurrentContext"
        Me.ListBoxCurrentContext.ScrollAlwaysVisible = True
        Me.ListBoxCurrentContext.Size = New System.Drawing.Size(215, 140)
        Me.ListBoxCurrentContext.TabIndex = 0
        '
        'ButtonClearDialog
        '
        Me.ButtonClearDialog.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearDialog.Location = New System.Drawing.Point(298, 54)
        Me.ButtonClearDialog.Name = "ButtonClearDialog"
        Me.ButtonClearDialog.Size = New System.Drawing.Size(68, 30)
        Me.ButtonClearDialog.TabIndex = 13
        Me.ButtonClearDialog.Text = "Clear"
        Me.ButtonClearDialog.UseVisualStyleBackColor = True
        '
        'TextBoxDialogName
        '
        Me.TextBoxDialogName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxDialogName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxDialogName.Enabled = False
        Me.TextBoxDialogName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDialogName.Location = New System.Drawing.Point(3, 18)
        Me.TextBoxDialogName.Name = "TextBoxDialogName"
        Me.TextBoxDialogName.Size = New System.Drawing.Size(881, 30)
        Me.TextBoxDialogName.TabIndex = 0
        '
        'ButtonSaveDialog
        '
        Me.ButtonSaveDialog.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveDialog.Location = New System.Drawing.Point(224, 54)
        Me.ButtonSaveDialog.Name = "ButtonSaveDialog"
        Me.ButtonSaveDialog.Size = New System.Drawing.Size(68, 30)
        Me.ButtonSaveDialog.TabIndex = 15
        Me.ButtonSaveDialog.Text = "SAVE"
        Me.ButtonSaveDialog.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Green
        Me.GroupBox2.Controls.Add(Me.ButtonClearIntents)
        Me.GroupBox2.Controls.Add(Me.ButtonRemoveIntent)
        Me.GroupBox2.Controls.Add(Me.ButtonEditIntent)
        Me.GroupBox2.Controls.Add(Me.ButtonADDIntent)
        Me.GroupBox2.Controls.Add(Me.ListBoxIntentsList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 381)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manage Intents"
        '
        'ButtonClearIntents
        '
        Me.ButtonClearIntents.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearIntents.Location = New System.Drawing.Point(335, 26)
        Me.ButtonClearIntents.Name = "ButtonClearIntents"
        Me.ButtonClearIntents.Size = New System.Drawing.Size(93, 29)
        Me.ButtonClearIntents.TabIndex = 12
        Me.ButtonClearIntents.Text = "Clear"
        Me.ButtonClearIntents.UseVisualStyleBackColor = True
        '
        'ButtonRemoveIntent
        '
        Me.ButtonRemoveIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveIntent.Location = New System.Drawing.Point(214, 26)
        Me.ButtonRemoveIntent.Name = "ButtonRemoveIntent"
        Me.ButtonRemoveIntent.Size = New System.Drawing.Size(113, 29)
        Me.ButtonRemoveIntent.TabIndex = 13
        Me.ButtonRemoveIntent.Text = "Remove"
        Me.ButtonRemoveIntent.UseVisualStyleBackColor = True
        '
        'ButtonEditIntent
        '
        Me.ButtonEditIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditIntent.Location = New System.Drawing.Point(114, 26)
        Me.ButtonEditIntent.Name = "ButtonEditIntent"
        Me.ButtonEditIntent.Size = New System.Drawing.Size(93, 29)
        Me.ButtonEditIntent.TabIndex = 14
        Me.ButtonEditIntent.Text = "Edit"
        Me.ButtonEditIntent.UseVisualStyleBackColor = True
        '
        'ButtonADDIntent
        '
        Me.ButtonADDIntent.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADDIntent.Location = New System.Drawing.Point(12, 25)
        Me.ButtonADDIntent.Name = "ButtonADDIntent"
        Me.ButtonADDIntent.Size = New System.Drawing.Size(93, 30)
        Me.ButtonADDIntent.TabIndex = 15
        Me.ButtonADDIntent.Text = "ADD"
        Me.ButtonADDIntent.UseVisualStyleBackColor = True
        '
        'ListBoxIntentsList
        '
        Me.ListBoxIntentsList.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxIntentsList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxIntentsList.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxIntentsList.FormattingEnabled = True
        Me.ListBoxIntentsList.ItemHeight = 16
        Me.ListBoxIntentsList.Location = New System.Drawing.Point(3, 86)
        Me.ListBoxIntentsList.Name = "ListBoxIntentsList"
        Me.ListBoxIntentsList.Size = New System.Drawing.Size(439, 292)
        Me.ListBoxIntentsList.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxEntityListName)
        Me.GroupBox3.Controls.Add(Me.ButtonClearEntityLists)
        Me.GroupBox3.Controls.Add(Me.ButtonRemoveEntityList)
        Me.GroupBox3.Controls.Add(Me.ButtonEditEntityList)
        Me.GroupBox3.Controls.Add(Me.ListBoxEntityLists)
        Me.GroupBox3.Controls.Add(Me.ButtonADDEntityList)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(445, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(445, 381)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manage Entity Lists"
        '
        'TextBoxEntityListName
        '
        Me.TextBoxEntityListName.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxEntityListName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxEntityListName.Location = New System.Drawing.Point(3, 92)
        Me.TextBoxEntityListName.Name = "TextBoxEntityListName"
        Me.TextBoxEntityListName.Size = New System.Drawing.Size(439, 26)
        Me.TextBoxEntityListName.TabIndex = 16
        '
        'ButtonClearEntityLists
        '
        Me.ButtonClearEntityLists.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearEntityLists.Location = New System.Drawing.Point(331, 27)
        Me.ButtonClearEntityLists.Name = "ButtonClearEntityLists"
        Me.ButtonClearEntityLists.Size = New System.Drawing.Size(93, 29)
        Me.ButtonClearEntityLists.TabIndex = 12
        Me.ButtonClearEntityLists.Text = "Clear"
        Me.ButtonClearEntityLists.UseVisualStyleBackColor = True
        '
        'ButtonRemoveEntityList
        '
        Me.ButtonRemoveEntityList.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveEntityList.Location = New System.Drawing.Point(209, 27)
        Me.ButtonRemoveEntityList.Name = "ButtonRemoveEntityList"
        Me.ButtonRemoveEntityList.Size = New System.Drawing.Size(113, 29)
        Me.ButtonRemoveEntityList.TabIndex = 13
        Me.ButtonRemoveEntityList.Text = "Remove"
        Me.ButtonRemoveEntityList.UseVisualStyleBackColor = True
        '
        'ButtonEditEntityList
        '
        Me.ButtonEditEntityList.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditEntityList.Location = New System.Drawing.Point(107, 27)
        Me.ButtonEditEntityList.Name = "ButtonEditEntityList"
        Me.ButtonEditEntityList.Size = New System.Drawing.Size(93, 29)
        Me.ButtonEditEntityList.TabIndex = 14
        Me.ButtonEditEntityList.Text = "Edit"
        Me.ButtonEditEntityList.UseVisualStyleBackColor = True
        '
        'ListBoxEntityLists
        '
        Me.ListBoxEntityLists.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxEntityLists.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxEntityLists.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEntityLists.FormattingEnabled = True
        Me.ListBoxEntityLists.ItemHeight = 16
        Me.ListBoxEntityLists.Location = New System.Drawing.Point(3, 118)
        Me.ListBoxEntityLists.Name = "ListBoxEntityLists"
        Me.ListBoxEntityLists.Size = New System.Drawing.Size(439, 260)
        Me.ListBoxEntityLists.TabIndex = 0
        '
        'ButtonADDEntityList
        '
        Me.ButtonADDEntityList.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADDEntityList.Location = New System.Drawing.Point(6, 26)
        Me.ButtonADDEntityList.Name = "ButtonADDEntityList"
        Me.ButtonADDEntityList.Size = New System.Drawing.Size(93, 30)
        Me.ButtonADDEntityList.TabIndex = 15
        Me.ButtonADDEntityList.Text = "ADD"
        Me.ButtonADDEntityList.UseVisualStyleBackColor = True
        '
        'FormCreateDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 593)
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
