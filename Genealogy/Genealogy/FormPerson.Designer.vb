<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerson
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxGivenName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonDoAction = New System.Windows.Forms.Button()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.ButtonFather = New System.Windows.Forms.Button()
        Me.ButtonMother = New System.Windows.Forms.Button()
        Me.DateTimePickerDeathdate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxDeathdateEnabled = New System.Windows.Forms.CheckBox()
        Me.TextBoxFamilyName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonShowTree = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Given name:"
        '
        'TextBoxGivenName
        '
        Me.TextBoxGivenName.Location = New System.Drawing.Point(85, 6)
        Me.TextBoxGivenName.Name = "TextBoxGivenName"
        Me.TextBoxGivenName.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxGivenName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Birthdate:"
        '
        'DateTimePickerBirthdate
        '
        Me.DateTimePickerBirthdate.Location = New System.Drawing.Point(85, 69)
        Me.DateTimePickerBirthdate.Name = "DateTimePickerBirthdate"
        Me.DateTimePickerBirthdate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerBirthdate.TabIndex = 3
        '
        'ButtonDoAction
        '
        Me.ButtonDoAction.Location = New System.Drawing.Point(201, 205)
        Me.ButtonDoAction.Name = "ButtonDoAction"
        Me.ButtonDoAction.Size = New System.Drawing.Size(97, 23)
        Me.ButtonDoAction.TabIndex = 4
        Me.ButtonDoAction.UseVisualStyleBackColor = True
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Checked = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(84, 132)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonMale.TabIndex = 5
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Location = New System.Drawing.Point(138, 132)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonFemale.TabIndex = 6
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'ButtonFather
        '
        Me.ButtonFather.Location = New System.Drawing.Point(84, 166)
        Me.ButtonFather.Name = "ButtonFather"
        Me.ButtonFather.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFather.TabIndex = 7
        Me.ButtonFather.Text = "Father"
        Me.ButtonFather.UseVisualStyleBackColor = True
        '
        'ButtonMother
        '
        Me.ButtonMother.Location = New System.Drawing.Point(165, 166)
        Me.ButtonMother.Name = "ButtonMother"
        Me.ButtonMother.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMother.TabIndex = 8
        Me.ButtonMother.Text = "Mother"
        Me.ButtonMother.UseVisualStyleBackColor = True
        '
        'DateTimePickerDeathdate
        '
        Me.DateTimePickerDeathdate.Enabled = False
        Me.DateTimePickerDeathdate.Location = New System.Drawing.Point(85, 95)
        Me.DateTimePickerDeathdate.Name = "DateTimePickerDeathdate"
        Me.DateTimePickerDeathdate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDeathdate.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Deathdate:"
        '
        'CheckBoxDeathdateEnabled
        '
        Me.CheckBoxDeathdateEnabled.AutoSize = True
        Me.CheckBoxDeathdateEnabled.Location = New System.Drawing.Point(292, 97)
        Me.CheckBoxDeathdateEnabled.Name = "CheckBoxDeathdateEnabled"
        Me.CheckBoxDeathdateEnabled.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxDeathdateEnabled.TabIndex = 11
        Me.CheckBoxDeathdateEnabled.UseVisualStyleBackColor = True
        '
        'TextBoxFamilyName
        '
        Me.TextBoxFamilyName.Location = New System.Drawing.Point(85, 32)
        Me.TextBoxFamilyName.Name = "TextBoxFamilyName"
        Me.TextBoxFamilyName.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxFamilyName.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Family name:"
        '
        'ButtonShowTree
        '
        Me.ButtonShowTree.Location = New System.Drawing.Point(12, 168)
        Me.ButtonShowTree.Name = "ButtonShowTree"
        Me.ButtonShowTree.Size = New System.Drawing.Size(60, 60)
        Me.ButtonShowTree.TabIndex = 14
        Me.ButtonShowTree.Text = "Show Tree"
        Me.ButtonShowTree.UseVisualStyleBackColor = True
        Me.ButtonShowTree.Visible = False
        '
        'FormPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 240)
        Me.Controls.Add(Me.ButtonShowTree)
        Me.Controls.Add(Me.TextBoxFamilyName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBoxDeathdateEnabled)
        Me.Controls.Add(Me.DateTimePickerDeathdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonMother)
        Me.Controls.Add(Me.ButtonFather)
        Me.Controls.Add(Me.RadioButtonFemale)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.ButtonDoAction)
        Me.Controls.Add(Me.DateTimePickerBirthdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxGivenName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPerson"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGivenName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonDoAction As System.Windows.Forms.Button
    Friend WithEvents RadioButtonMale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFemale As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonFather As System.Windows.Forms.Button
    Friend WithEvents ButtonMother As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerDeathdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDeathdateEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxFamilyName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonShowTree As System.Windows.Forms.Button
End Class
