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
        Me.ButtonImport = New System.Windows.Forms.Button()
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
        Me.groupbox1.BackColor = System.Drawing.Color.Black
        Me.groupbox1.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.groupbox1.Controls.Add(Me.ButtonImport)
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
        Me.groupbox1.ForeColor = System.Drawing.Color.White
        Me.groupbox1.Location = New System.Drawing.Point(0, 0)
        Me.groupbox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupbox1.Size = New System.Drawing.Size(700, 572)
        Me.groupbox1.TabIndex = 0
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "Parameter Lists"
        '
        'ButtonImport
        '
        Me.ButtonImport.BackColor = System.Drawing.Color.Black
        Me.ButtonImport.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImport.ForeColor = System.Drawing.Color.White
        Me.ButtonImport.Location = New System.Drawing.Point(497, 113)
        Me.ButtonImport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(188, 39)
        Me.ButtonImport.TabIndex = 17
        Me.ButtonImport.Text = "Import List"
        Me.ButtonImport.UseVisualStyleBackColor = False
        '
        'ButtonExportJson
        '
        Me.ButtonExportJson.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonExportJson.BackColor = System.Drawing.Color.Black
        Me.ButtonExportJson.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportJson.ForeColor = System.Drawing.Color.White
        Me.ButtonExportJson.Location = New System.Drawing.Point(497, 177)
        Me.ButtonExportJson.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonExportJson.Name = "ButtonExportJson"
        Me.ButtonExportJson.Size = New System.Drawing.Size(188, 39)
        Me.ButtonExportJson.TabIndex = 16
        Me.ButtonExportJson.Text = "Export List"
        Me.ButtonExportJson.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxReplacementParameterCharacter)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBoxReplacementTriggerCharacter)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(3, 231)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(694, 128)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Replacement ParameterName Characters"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 29)
        Me.Label5.TabIndex = 14
        '
        'TextBoxReplacementParameterCharacter
        '
        Me.TextBoxReplacementParameterCharacter.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxReplacementParameterCharacter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReplacementParameterCharacter.ForeColor = System.Drawing.Color.Black
        Me.TextBoxReplacementParameterCharacter.Location = New System.Drawing.Point(4, 28)
        Me.TextBoxReplacementParameterCharacter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxReplacementParameterCharacter.Name = "TextBoxReplacementParameterCharacter"
        Me.TextBoxReplacementParameterCharacter.Size = New System.Drawing.Size(686, 30)
        Me.TextBoxReplacementParameterCharacter.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Replacement Trigger Character"
        '
        'TextBoxReplacementTriggerCharacter
        '
        Me.TextBoxReplacementTriggerCharacter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxReplacementTriggerCharacter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReplacementTriggerCharacter.ForeColor = System.Drawing.Color.Black
        Me.TextBoxReplacementTriggerCharacter.Location = New System.Drawing.Point(4, 94)
        Me.TextBoxReplacementTriggerCharacter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxReplacementTriggerCharacter.Name = "TextBoxReplacementTriggerCharacter"
        Me.TextBoxReplacementTriggerCharacter.Size = New System.Drawing.Size(686, 30)
        Me.TextBoxReplacementTriggerCharacter.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "List Replacement Character"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "List Item Prompt"
        '
        'TextBoxListReplacementChar
        '
        Me.TextBoxListReplacementChar.ForeColor = System.Drawing.Color.Black
        Me.TextBoxListReplacementChar.Location = New System.Drawing.Point(8, 181)
        Me.TextBoxListReplacementChar.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxListReplacementChar.Name = "TextBoxListReplacementChar"
        Me.TextBoxListReplacementChar.Size = New System.Drawing.Size(383, 31)
        Me.TextBoxListReplacementChar.TabIndex = 13
        '
        'TextBoxListPrompt
        '
        Me.TextBoxListPrompt.ForeColor = System.Drawing.Color.Black
        Me.TextBoxListPrompt.Location = New System.Drawing.Point(8, 118)
        Me.TextBoxListPrompt.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxListPrompt.Name = "TextBoxListPrompt"
        Me.TextBoxListPrompt.Size = New System.Drawing.Size(383, 31)
        Me.TextBoxListPrompt.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Entity List Name"
        '
        'TextBoxListName
        '
        Me.TextBoxListName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxListName.Enabled = False
        Me.TextBoxListName.ForeColor = System.Drawing.Color.White
        Me.TextBoxListName.Location = New System.Drawing.Point(7, 55)
        Me.TextBoxListName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxListName.Name = "TextBoxListName"
        Me.TextBoxListName.Size = New System.Drawing.Size(384, 31)
        Me.TextBoxListName.TabIndex = 13
        '
        'ListBoxEntitys
        '
        Me.ListBoxEntitys.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxEntitys.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxEntitys.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEntitys.ForeColor = System.Drawing.Color.Black
        Me.ListBoxEntitys.FormattingEnabled = True
        Me.ListBoxEntitys.ItemHeight = 23
        Me.ListBoxEntitys.Location = New System.Drawing.Point(3, 359)
        Me.ListBoxEntitys.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxEntitys.Name = "ListBoxEntitys"
        Me.ListBoxEntitys.ScrollAlwaysVisible = True
        Me.ListBoxEntitys.Size = New System.Drawing.Size(694, 211)
        Me.ListBoxEntitys.TabIndex = 12
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Black
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(593, 55)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(92, 39)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.Black
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(399, 55)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(91, 39)
        Me.ButtonClear.TabIndex = 8
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.Black
        Me.ButtonRemove.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.White
        Me.ButtonRemove.Location = New System.Drawing.Point(401, 178)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(91, 39)
        Me.ButtonRemove.TabIndex = 9
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Black
        Me.ButtonEdit.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(399, 113)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(92, 39)
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonADD
        '
        Me.ButtonADD.BackColor = System.Drawing.Color.Black
        Me.ButtonADD.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADD.ForeColor = System.Drawing.Color.White
        Me.ButtonADD.Location = New System.Drawing.Point(497, 55)
        Me.ButtonADD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(91, 41)
        Me.ButtonADD.TabIndex = 11
        Me.ButtonADD.Text = "ADD"
        Me.ButtonADD.UseVisualStyleBackColor = False
        '
        'FormCreatedNamedEntitys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 572)
        Me.Controls.Add(Me.groupbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents ButtonImport As Button
End Class
