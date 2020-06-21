<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateEntity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCreateEntity))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAddPrompt = New System.Windows.Forms.TextBox()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonClearList = New System.Windows.Forms.Button()
        Me.ButtonRemoveEntity = New System.Windows.Forms.Button()
        Me.ButtonImportJson = New System.Windows.Forms.Button()
        Me.ButtonExportJson = New System.Windows.Forms.Button()
        Me.ButtonEditEntity = New System.Windows.Forms.Button()
        Me.TextBoxEntityListName = New System.Windows.Forms.TextBox()
        Me.ListBoxEntitys = New System.Windows.Forms.ListBox()
        Me.Buttonclose = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAddParameter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAddTrigger = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddEntity = New System.Windows.Forms.Button()
        Me.ButtonClearEntity = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(456, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 381)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Manager"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox2.Controls.Add(Me.ButtonClearList)
        Me.GroupBox2.Controls.Add(Me.ButtonRemoveEntity)
        Me.GroupBox2.Controls.Add(Me.ButtonImportJson)
        Me.GroupBox2.Controls.Add(Me.ButtonExportJson)
        Me.GroupBox2.Controls.Add(Me.ButtonEditEntity)
        Me.GroupBox2.Controls.Add(Me.TextBoxEntityListName)
        Me.GroupBox2.Controls.Add(Me.ListBoxEntitys)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 354)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entity List Name"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBoxAddPrompt)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(3, 174)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(292, 59)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Prompt For Parameter"
        '
        'TextBoxAddPrompt
        '
        Me.TextBoxAddPrompt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxAddPrompt.Location = New System.Drawing.Point(2, 21)
        Me.TextBoxAddPrompt.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddPrompt.Name = "TextBoxAddPrompt"
        Me.TextBoxAddPrompt.Size = New System.Drawing.Size(288, 26)
        Me.TextBoxAddPrompt.TabIndex = 0
        Me.TextBoxAddPrompt.Tag = "Add prompt for parameter to be called when the parmeter is missing from the detec" &
    "ted intent"
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.LightGray
        Me.ButtonUpdate.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.Black
        Me.ButtonUpdate.Location = New System.Drawing.Point(201, 101)
        Me.ButtonUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(94, 31)
        Me.ButtonUpdate.TabIndex = 1
        Me.ButtonUpdate.Tag = "Creates or updates the current list with the form detail. "
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonClearList
        '
        Me.ButtonClearList.BackColor = System.Drawing.Color.LightGray
        Me.ButtonClearList.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearList.ForeColor = System.Drawing.Color.Black
        Me.ButtonClearList.Location = New System.Drawing.Point(201, 66)
        Me.ButtonClearList.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClearList.Name = "ButtonClearList"
        Me.ButtonClearList.Size = New System.Drawing.Size(94, 31)
        Me.ButtonClearList.TabIndex = 1
        Me.ButtonClearList.Tag = "Clears Current list"
        Me.ButtonClearList.Text = "Clear"
        Me.ButtonClearList.UseVisualStyleBackColor = False
        '
        'ButtonRemoveEntity
        '
        Me.ButtonRemoveEntity.BackColor = System.Drawing.Color.LightGray
        Me.ButtonRemoveEntity.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveEntity.ForeColor = System.Drawing.Color.Black
        Me.ButtonRemoveEntity.Location = New System.Drawing.Point(103, 66)
        Me.ButtonRemoveEntity.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRemoveEntity.Name = "ButtonRemoveEntity"
        Me.ButtonRemoveEntity.Size = New System.Drawing.Size(94, 31)
        Me.ButtonRemoveEntity.TabIndex = 1
        Me.ButtonRemoveEntity.Tag = "Removes selected Entity"
        Me.ButtonRemoveEntity.Text = "Remove"
        Me.ButtonRemoveEntity.UseVisualStyleBackColor = False
        '
        'ButtonImportJson
        '
        Me.ButtonImportJson.BackColor = System.Drawing.Color.LightGray
        Me.ButtonImportJson.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportJson.ForeColor = System.Drawing.Color.Black
        Me.ButtonImportJson.Location = New System.Drawing.Point(103, 101)
        Me.ButtonImportJson.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonImportJson.Name = "ButtonImportJson"
        Me.ButtonImportJson.Size = New System.Drawing.Size(94, 31)
        Me.ButtonImportJson.TabIndex = 1
        Me.ButtonImportJson.Tag = "Imports entitys from Json"
        Me.ButtonImportJson.Text = "Import"
        Me.ButtonImportJson.UseVisualStyleBackColor = False
        '
        'ButtonExportJson
        '
        Me.ButtonExportJson.BackColor = System.Drawing.Color.LightGray
        Me.ButtonExportJson.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExportJson.ForeColor = System.Drawing.Color.Black
        Me.ButtonExportJson.Location = New System.Drawing.Point(5, 101)
        Me.ButtonExportJson.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExportJson.Name = "ButtonExportJson"
        Me.ButtonExportJson.Size = New System.Drawing.Size(94, 31)
        Me.ButtonExportJson.TabIndex = 1
        Me.ButtonExportJson.Tag = "Exports List of Entitys to json"
        Me.ButtonExportJson.Text = "Export"
        Me.ButtonExportJson.UseVisualStyleBackColor = False
        '
        'ButtonEditEntity
        '
        Me.ButtonEditEntity.BackColor = System.Drawing.Color.LightGray
        Me.ButtonEditEntity.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditEntity.ForeColor = System.Drawing.Color.Black
        Me.ButtonEditEntity.Location = New System.Drawing.Point(5, 66)
        Me.ButtonEditEntity.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditEntity.Name = "ButtonEditEntity"
        Me.ButtonEditEntity.Size = New System.Drawing.Size(94, 31)
        Me.ButtonEditEntity.TabIndex = 1
        Me.ButtonEditEntity.Tag = "Edits selected entity"
        Me.ButtonEditEntity.Text = "Edit"
        Me.ButtonEditEntity.UseVisualStyleBackColor = False
        '
        'TextBoxEntityListName
        '
        Me.TextBoxEntityListName.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxEntityListName.Location = New System.Drawing.Point(3, 24)
        Me.TextBoxEntityListName.Name = "TextBoxEntityListName"
        Me.TextBoxEntityListName.Size = New System.Drawing.Size(292, 28)
        Me.TextBoxEntityListName.TabIndex = 2
        Me.TextBoxEntityListName.Tag = "Name of List"
        '
        'ListBoxEntitys
        '
        Me.ListBoxEntitys.BackColor = System.Drawing.SystemColors.Info
        Me.ListBoxEntitys.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxEntitys.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEntitys.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListBoxEntitys.FormattingEnabled = True
        Me.ListBoxEntitys.ItemHeight = 19
        Me.ListBoxEntitys.Location = New System.Drawing.Point(3, 233)
        Me.ListBoxEntitys.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxEntitys.Name = "ListBoxEntitys"
        Me.ListBoxEntitys.ScrollAlwaysVisible = True
        Me.ListBoxEntitys.Size = New System.Drawing.Size(292, 118)
        Me.ListBoxEntitys.TabIndex = 1
        Me.ListBoxEntitys.Tag = "Entity List"
        '
        'Buttonclose
        '
        Me.Buttonclose.BackColor = System.Drawing.Color.LightGray
        Me.Buttonclose.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonclose.ForeColor = System.Drawing.Color.Black
        Me.Buttonclose.Location = New System.Drawing.Point(4, 90)
        Me.Buttonclose.Margin = New System.Windows.Forms.Padding(2)
        Me.Buttonclose.Name = "Buttonclose"
        Me.Buttonclose.Size = New System.Drawing.Size(94, 31)
        Me.Buttonclose.TabIndex = 1
        Me.Buttonclose.Tag = "Closes the form "
        Me.Buttonclose.Text = "Close"
        Me.Buttonclose.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Navy
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 381)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Create Entity"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(3, 173)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(450, 205)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 231)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 24)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(450, 149)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Navy
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.TextBoxAddParameter)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.TextBoxAddTrigger)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(2, 21)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(342, 114)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Entity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Parameter "
        '
        'TextBoxAddParameter
        '
        Me.TextBoxAddParameter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxAddParameter.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddParameter.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBoxAddParameter.Location = New System.Drawing.Point(2, 41)
        Me.TextBoxAddParameter.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddParameter.Name = "TextBoxAddParameter"
        Me.TextBoxAddParameter.Size = New System.Drawing.Size(338, 26)
        Me.TextBoxAddParameter.TabIndex = 2
        Me.TextBoxAddParameter.Tag = "This is the data which has been detected. ie: NEW YORK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Trigger"
        '
        'TextBoxAddTrigger
        '
        Me.TextBoxAddTrigger.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBoxAddTrigger.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddTrigger.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBoxAddTrigger.Location = New System.Drawing.Point(2, 86)
        Me.TextBoxAddTrigger.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAddTrigger.Name = "TextBoxAddTrigger"
        Me.TextBoxAddTrigger.Size = New System.Drawing.Size(338, 26)
        Me.TextBoxAddTrigger.TabIndex = 0
        Me.TextBoxAddTrigger.Tag = "This is the Word or Phrase which will trigger the recognition of the parameter"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Navy
        Me.GroupBox5.Controls.Add(Me.Buttonclose)
        Me.GroupBox5.Controls.Add(Me.ButtonAddEntity)
        Me.GroupBox5.Controls.Add(Me.ButtonClearEntity)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox5.Location = New System.Drawing.Point(344, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 126)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'ButtonAddEntity
        '
        Me.ButtonAddEntity.BackColor = System.Drawing.Color.LightGray
        Me.ButtonAddEntity.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddEntity.ForeColor = System.Drawing.Color.Black
        Me.ButtonAddEntity.Location = New System.Drawing.Point(4, 18)
        Me.ButtonAddEntity.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAddEntity.Name = "ButtonAddEntity"
        Me.ButtonAddEntity.Size = New System.Drawing.Size(94, 31)
        Me.ButtonAddEntity.TabIndex = 1
        Me.ButtonAddEntity.Tag = "Add Entity to the list"
        Me.ButtonAddEntity.Text = "Add"
        Me.ButtonAddEntity.UseVisualStyleBackColor = False
        '
        'ButtonClearEntity
        '
        Me.ButtonClearEntity.BackColor = System.Drawing.Color.LightGray
        Me.ButtonClearEntity.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearEntity.ForeColor = System.Drawing.Color.Black
        Me.ButtonClearEntity.Location = New System.Drawing.Point(4, 52)
        Me.ButtonClearEntity.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClearEntity.Name = "ButtonClearEntity"
        Me.ButtonClearEntity.Size = New System.Drawing.Size(94, 31)
        Me.ButtonClearEntity.TabIndex = 2
        Me.ButtonClearEntity.Tag = "Clears the form(entity)"
        Me.ButtonClearEntity.Text = "Clear"
        Me.ButtonClearEntity.UseVisualStyleBackColor = False
        '
        'FormCreateEntity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(760, 381)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FormCreateEntity"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Named Entity List Manager"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxEntityListName As TextBox
    Friend WithEvents ListBoxEntitys As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxAddParameter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxAddTrigger As TextBox
    Friend WithEvents ButtonClearList As Button
    Friend WithEvents ButtonRemoveEntity As Button
    Friend WithEvents ButtonImportJson As Button
    Friend WithEvents ButtonExportJson As Button
    Friend WithEvents ButtonEditEntity As Button
    Friend WithEvents ButtonAddEntity As Button
    Friend WithEvents ButtonClearEntity As Button
    Friend WithEvents Buttonclose As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBoxAddPrompt As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label1 As Label
End Class
