<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreatedNamedEntitys
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
        Me.groupbox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonExportJson = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxReplacementParameterCharacter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxReplacementTriggerCharacter = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxListReplacementChar = New System.Windows.Forms.TextBox()
        Me.TextBoxListPrompt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxListName = New System.Windows.Forms.TextBox()
        Me.ListBoxEntitys = New System.Windows.Forms.ListBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.groupbox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.groupbox1.Controls.Add(Me.ButtonExportJson)
        Me.groupbox1.Controls.Add(Me.GroupBox3)
        Me.groupbox1.Controls.Add(Me.Label3)
        Me.groupbox1.Controls.Add(Me.Label2)
        Me.groupbox1.Controls.Add(Me.TextBoxListReplacementChar)
        Me.groupbox1.Controls.Add(Me.TextBoxListPrompt)
        Me.groupbox1.Controls.Add(Me.Label1)
        Me.groupbox1.Controls.Add(Me.TextBoxListName)
        Me.groupbox1.Controls.Add(Me.ListBoxEntitys)
        Me.groupbox1.Controls.Add(Me.ButtonSave)
        Me.groupbox1.Controls.Add(Me.ButtonClear)
        Me.groupbox1.Controls.Add(Me.ButtonRemove)
        Me.groupbox1.Controls.Add(Me.ButtonEdit)
        Me.groupbox1.Controls.Add(Me.ButtonADD)
        Me.groupbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupbox1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox1.Location = New System.Drawing.Point(0, 0)
        Me.groupbox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupbox1.Size = New System.Drawing.Size(451, 465)
        Me.groupbox1.TabIndex = 0
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "Parameter Lists"
        '
        'ButtonExportJson
        '
        Me.ButtonExportJson.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonExportJson.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportJson.Location = New System.Drawing.Point(373, 143)
        Me.ButtonExportJson.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExportJson.Name = "ButtonExportJson"
        Me.ButtonExportJson.Size = New System.Drawing.Size(69, 32)
        Me.ButtonExportJson.TabIndex = 16
        Me.ButtonExportJson.Text = "Export"
        Me.ButtonExportJson.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxReplacementParameterCharacter)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBoxReplacementTriggerCharacter)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(2, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(447, 104)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Replacement ParameterName Characters"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 23)
        Me.Label5.TabIndex = 14
        '
        'TextBoxReplacementParameterCharacter
        '
        Me.TextBoxReplacementParameterCharacter.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxReplacementParameterCharacter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReplacementParameterCharacter.Location = New System.Drawing.Point(3, 22)
        Me.TextBoxReplacementParameterCharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxReplacementParameterCharacter.Name = "TextBoxReplacementParameterCharacter"
        Me.TextBoxReplacementParameterCharacter.Size = New System.Drawing.Size(441, 26)
        Me.TextBoxReplacementParameterCharacter.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Replacement Trigger Character"
        '
        'TextBoxReplacementTriggerCharacter
        '
        Me.TextBoxReplacementTriggerCharacter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxReplacementTriggerCharacter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReplacementTriggerCharacter.Location = New System.Drawing.Point(3, 75)
        Me.TextBoxReplacementTriggerCharacter.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxReplacementTriggerCharacter.Name = "TextBoxReplacementTriggerCharacter"
        Me.TextBoxReplacementTriggerCharacter.Size = New System.Drawing.Size(441, 26)
        Me.TextBoxReplacementTriggerCharacter.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "List Replacement Character"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "List Item Prompt"
        '
        'TextBoxListReplacementChar
        '
        Me.TextBoxListReplacementChar.Location = New System.Drawing.Point(6, 147)
        Me.TextBoxListReplacementChar.Name = "TextBoxListReplacementChar"
        Me.TextBoxListReplacementChar.Size = New System.Drawing.Size(288, 26)
        Me.TextBoxListReplacementChar.TabIndex = 13
        '
        'TextBoxListPrompt
        '
        Me.TextBoxListPrompt.Location = New System.Drawing.Point(6, 96)
        Me.TextBoxListPrompt.Name = "TextBoxListPrompt"
        Me.TextBoxListPrompt.Size = New System.Drawing.Size(288, 26)
        Me.TextBoxListPrompt.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Entity List Name"
        '
        'TextBoxListName
        '
        Me.TextBoxListName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxListName.Enabled = False
        Me.TextBoxListName.Location = New System.Drawing.Point(5, 45)
        Me.TextBoxListName.Name = "TextBoxListName"
        Me.TextBoxListName.Size = New System.Drawing.Size(289, 26)
        Me.TextBoxListName.TabIndex = 13
        '
        'ListBoxEntitys
        '
        Me.ListBoxEntitys.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxEntitys.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxEntitys.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEntitys.FormattingEnabled = True
        Me.ListBoxEntitys.ItemHeight = 18
        Me.ListBoxEntitys.Location = New System.Drawing.Point(2, 279)
        Me.ListBoxEntitys.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxEntitys.Name = "ListBoxEntitys"
        Me.ListBoxEntitys.ScrollAlwaysVisible = True
        Me.ListBoxEntitys.Size = New System.Drawing.Size(447, 184)
        Me.ListBoxEntitys.TabIndex = 12
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(373, 45)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(69, 32)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(311, 45)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(56, 32)
        Me.ButtonClear.TabIndex = 8
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.Location = New System.Drawing.Point(299, 143)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(68, 32)
        Me.ButtonRemove.TabIndex = 9
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(373, 92)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(69, 32)
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonADD
        '
        Me.ButtonADD.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADD.Location = New System.Drawing.Point(299, 92)
        Me.ButtonADD.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(68, 33)
        Me.ButtonADD.TabIndex = 11
        Me.ButtonADD.Text = "ADD"
        Me.ButtonADD.UseVisualStyleBackColor = True
        '
        'FormCreatedNamedEntitys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 465)
        Me.Controls.Add(Me.groupbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCreatedNamedEntitys"
        Me.Text = "Create Parameter Lists"
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents ListBoxEntitys As ListBox
    Friend WithEvents TextBoxListName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxListPrompt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxListReplacementChar As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxReplacementParameterCharacter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxReplacementTriggerCharacter As TextBox
    Friend WithEvents ButtonExportJson As Button
End Class
