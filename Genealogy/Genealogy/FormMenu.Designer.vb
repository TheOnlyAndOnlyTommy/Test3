<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.ButtonCreatePerson = New System.Windows.Forms.Button()
        Me.ButtonSearchPerson = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonCreatePerson
        '
        Me.ButtonCreatePerson.Location = New System.Drawing.Point(12, 12)
        Me.ButtonCreatePerson.Name = "ButtonCreatePerson"
        Me.ButtonCreatePerson.Size = New System.Drawing.Size(165, 23)
        Me.ButtonCreatePerson.TabIndex = 0
        Me.ButtonCreatePerson.Text = "Create person"
        Me.ButtonCreatePerson.UseVisualStyleBackColor = True
        '
        'ButtonSearchPerson
        '
        Me.ButtonSearchPerson.Location = New System.Drawing.Point(12, 41)
        Me.ButtonSearchPerson.Name = "ButtonSearchPerson"
        Me.ButtonSearchPerson.Size = New System.Drawing.Size(165, 23)
        Me.ButtonSearchPerson.TabIndex = 1
        Me.ButtonSearchPerson.Text = "Search person"
        Me.ButtonSearchPerson.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 77)
        Me.Controls.Add(Me.ButtonSearchPerson)
        Me.Controls.Add(Me.ButtonCreatePerson)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genealogy"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCreatePerson As System.Windows.Forms.Button
    Friend WithEvents ButtonSearchPerson As System.Windows.Forms.Button

End Class
