<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageDialogs
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
        Me.TextBoxDialogName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxDialogs = New System.Windows.Forms.ListBox()
        Me.ButtonExportJson = New System.Windows.Forms.Button()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonImport = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.groupbox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupbox1
        '
        Me.groupbox1.BackColor = System.Drawing.Color.Teal
        Me.groupbox1.BackgroundImage = Global.DialogManager.My.Resources.Resources.BluPrint
        Me.groupbox1.Controls.Add(Me.TextBoxDialogName)
        Me.groupbox1.Controls.Add(Me.Label2)
        Me.groupbox1.Controls.Add(Me.Label1)
        Me.groupbox1.Controls.Add(Me.ListBoxDialogs)
        Me.groupbox1.Controls.Add(Me.ButtonExportJson)
        Me.groupbox1.Controls.Add(Me.ButtonTest)
        Me.groupbox1.Controls.Add(Me.ButtonSave)
        Me.groupbox1.Controls.Add(Me.ButtonImport)
        Me.groupbox1.Controls.Add(Me.ButtonClear)
        Me.groupbox1.Controls.Add(Me.ButtonRemove)
        Me.groupbox1.Controls.Add(Me.ButtonEdit)
        Me.groupbox1.Controls.Add(Me.ButtonADD)
        Me.groupbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupbox1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.groupbox1.Location = New System.Drawing.Point(0, 0)
        Me.groupbox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupbox1.Size = New System.Drawing.Size(454, 531)
        Me.groupbox1.TabIndex = 1
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "Dialogs"
        '
        'TextBoxDialogName
        '
        Me.TextBoxDialogName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBoxDialogName.Location = New System.Drawing.Point(11, 60)
        Me.TextBoxDialogName.Name = "TextBoxDialogName"
        Me.TextBoxDialogName.Size = New System.Drawing.Size(235, 26)
        Me.TextBoxDialogName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(2, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Create and Export Dialogs for use"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(2, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Individual Dialogs containing Intents and EntityLists"
        '
        'ListBoxDialogs
        '
        Me.ListBoxDialogs.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxDialogs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxDialogs.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDialogs.FormattingEnabled = True
        Me.ListBoxDialogs.ItemHeight = 18
        Me.ListBoxDialogs.Location = New System.Drawing.Point(2, 183)
        Me.ListBoxDialogs.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxDialogs.Name = "ListBoxDialogs"
        Me.ListBoxDialogs.Size = New System.Drawing.Size(450, 346)
        Me.ListBoxDialogs.TabIndex = 12
        '
        'ButtonExportJson
        '
        Me.ButtonExportJson.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonExportJson.BackColor = System.Drawing.Color.Black
        Me.ButtonExportJson.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportJson.Location = New System.Drawing.Point(376, 57)
        Me.ButtonExportJson.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExportJson.Name = "ButtonExportJson"
        Me.ButtonExportJson.Size = New System.Drawing.Size(69, 32)
        Me.ButtonExportJson.TabIndex = 7
        Me.ButtonExportJson.Text = "Export"
        Me.ButtonExportJson.UseVisualStyleBackColor = False
        '
        'ButtonTest
        '
        Me.ButtonTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonTest.BackColor = System.Drawing.Color.Black
        Me.ButtonTest.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTest.Location = New System.Drawing.Point(308, 94)
        Me.ButtonTest.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(52, 32)
        Me.ButtonTest.TabIndex = 7
        Me.ButtonTest.Text = "Test"
        Me.ButtonTest.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonSave.BackColor = System.Drawing.Color.Black
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(251, 93)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(52, 32)
        Me.ButtonSave.TabIndex = 7
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonImport
        '
        Me.ButtonImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonImport.BackColor = System.Drawing.Color.Black
        Me.ButtonImport.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImport.Location = New System.Drawing.Point(308, 56)
        Me.ButtonImport.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(64, 32)
        Me.ButtonImport.TabIndex = 8
        Me.ButtonImport.Text = "Import"
        Me.ButtonImport.UseVisualStyleBackColor = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonClear.BackColor = System.Drawing.Color.Black
        Me.ButtonClear.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(67, 94)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(56, 32)
        Me.ButtonClear.TabIndex = 8
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonRemove.BackColor = System.Drawing.Color.Black
        Me.ButtonRemove.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.Location = New System.Drawing.Point(127, 94)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(69, 32)
        Me.ButtonRemove.TabIndex = 9
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonEdit.BackColor = System.Drawing.Color.Black
        Me.ButtonEdit.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Location = New System.Drawing.Point(11, 94)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(52, 32)
        Me.ButtonEdit.TabIndex = 10
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonADD
        '
        Me.ButtonADD.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonADD.BackColor = System.Drawing.Color.Black
        Me.ButtonADD.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonADD.Location = New System.Drawing.Point(251, 56)
        Me.ButtonADD.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(52, 33)
        Me.ButtonADD.TabIndex = 11
        Me.ButtonADD.Text = "ADD"
        Me.ButtonADD.UseVisualStyleBackColor = False
        '
        'FormManageDialogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 531)
        Me.Controls.Add(Me.groupbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormManageDialogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Dialogs "
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents ListBoxDialogs As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents ButtonExportJson As Button
    Friend WithEvents ButtonImport As Button
    Friend WithEvents TextBoxDialogName As TextBox
    Friend WithEvents ButtonTest As Button
End Class
