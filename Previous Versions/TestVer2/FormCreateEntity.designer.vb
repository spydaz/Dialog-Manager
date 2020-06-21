<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCreateEntity
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
        Me.TextBoxParameterName = New System.Windows.Forms.TextBox()
        Me.TextBoxParameterTrigger = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.ButtonClearEntity = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxParameterName
        '
        Me.TextBoxParameterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxParameterName.Location = New System.Drawing.Point(13, 61)
        Me.TextBoxParameterName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxParameterName.Name = "TextBoxParameterName"
        Me.TextBoxParameterName.Size = New System.Drawing.Size(336, 26)
        Me.TextBoxParameterName.TabIndex = 1
        '
        'TextBoxParameterTrigger
        '
        Me.TextBoxParameterTrigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxParameterTrigger.Location = New System.Drawing.Point(11, 132)
        Me.TextBoxParameterTrigger.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxParameterTrigger.Name = "TextBoxParameterTrigger"
        Me.TextBoxParameterTrigger.Size = New System.Drawing.Size(257, 26)
        Me.TextBoxParameterTrigger.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Parameter Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Trigger"
        '
        'ButtonADD
        '
        Me.ButtonADD.Location = New System.Drawing.Point(272, 91)
        Me.ButtonADD.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(77, 33)
        Me.ButtonADD.TabIndex = 6
        Me.ButtonADD.Text = "ADD"
        Me.ButtonADD.UseVisualStyleBackColor = True
        '
        'ButtonClearEntity
        '
        Me.ButtonClearEntity.Location = New System.Drawing.Point(272, 128)
        Me.ButtonClearEntity.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClearEntity.Name = "ButtonClearEntity"
        Me.ButtonClearEntity.Size = New System.Drawing.Size(77, 33)
        Me.ButtonClearEntity.TabIndex = 6
        Me.ButtonClearEntity.Text = "Clear"
        Me.ButtonClearEntity.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonClearEntity)
        Me.GroupBox1.Controls.Add(Me.ButtonADD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxParameterTrigger)
        Me.GroupBox1.Controls.Add(Me.TextBoxParameterName)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(360, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entity"
        '
        'FormCreateEntity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 183)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCreateEntity"
        Me.Text = "Entity"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxParameterName As TextBox
    Friend WithEvents TextBoxParameterTrigger As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonADD As Button
    Friend WithEvents ButtonClearEntity As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
