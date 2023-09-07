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
        Me.lstGender = New System.Windows.Forms.ListBox()
        Me.btnGender = New System.Windows.Forms.Button()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBirthYear = New System.Windows.Forms.TextBox()
        Me.lblBirthYear = New System.Windows.Forms.Label()
        Me.lblHomeLanguage = New System.Windows.Forms.Label()
        Me.lslHomeLanguage = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstGender
        '
        Me.lstGender.FormattingEnabled = True
        Me.lstGender.ItemHeight = 20
        Me.lstGender.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.lstGender.Location = New System.Drawing.Point(179, 142)
        Me.lstGender.Name = "lstGender"
        Me.lstGender.Size = New System.Drawing.Size(120, 84)
        Me.lstGender.TabIndex = 0
        '
        'btnGender
        '
        Me.btnGender.Location = New System.Drawing.Point(567, 312)
        Me.btnGender.Name = "btnGender"
        Me.btnGender.Size = New System.Drawing.Size(108, 63)
        Me.btnGender.TabIndex = 1
        Me.btnGender.Text = "Gender"
        Me.btnGender.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(27, 142)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(136, 20)
        Me.lblGender.TabIndex = 3
        Me.lblGender.Text = "Enter your gender"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(37, 39)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(126, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Enter your name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(179, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 26)
        Me.txtName.TabIndex = 5
        '
        'txtBirthYear
        '
        Me.txtBirthYear.Location = New System.Drawing.Point(179, 82)
        Me.txtBirthYear.Name = "txtBirthYear"
        Me.txtBirthYear.Size = New System.Drawing.Size(100, 26)
        Me.txtBirthYear.TabIndex = 6
        '
        'lblBirthYear
        '
        Me.lblBirthYear.AutoSize = True
        Me.lblBirthYear.Location = New System.Drawing.Point(12, 88)
        Me.lblBirthYear.Name = "lblBirthYear"
        Me.lblBirthYear.Size = New System.Drawing.Size(151, 20)
        Me.lblBirthYear.TabIndex = 7
        Me.lblBirthYear.Text = "Enter your birth year"
        '
        'lblHomeLanguage
        '
        Me.lblHomeLanguage.AutoSize = True
        Me.lblHomeLanguage.Location = New System.Drawing.Point(12, 269)
        Me.lblHomeLanguage.Name = "lblHomeLanguage"
        Me.lblHomeLanguage.Size = New System.Drawing.Size(196, 20)
        Me.lblHomeLanguage.TabIndex = 8
        Me.lblHomeLanguage.Text = "Enter your home language"
        '
        'lslHomeLanguage
        '
        Me.lslHomeLanguage.FormattingEnabled = True
        Me.lslHomeLanguage.ItemHeight = 20
        Me.lslHomeLanguage.Items.AddRange(New Object() {"IsiZulu", "English", "TshiVenda"})
        Me.lslHomeLanguage.Location = New System.Drawing.Point(226, 269)
        Me.lslHomeLanguage.Name = "lslHomeLanguage"
        Me.lslHomeLanguage.Size = New System.Drawing.Size(120, 84)
        Me.lslHomeLanguage.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lslHomeLanguage)
        Me.Controls.Add(Me.lblHomeLanguage)
        Me.Controls.Add(Me.lblBirthYear)
        Me.Controls.Add(Me.txtBirthYear)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnGender)
        Me.Controls.Add(Me.lstGender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGender As ListBox
    Friend WithEvents btnGender As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBirthYear As TextBox
    Friend WithEvents lblBirthYear As Label
    Friend WithEvents lblHomeLanguage As Label
    Friend WithEvents lslHomeLanguage As ListBox
End Class
