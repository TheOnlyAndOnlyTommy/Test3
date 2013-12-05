<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormShowTree
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
        Me.PictureBoxTree = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxTree
        '
        Me.PictureBoxTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxTree.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxTree.Name = "PictureBoxTree"
        Me.PictureBoxTree.Size = New System.Drawing.Size(707, 404)
        Me.PictureBoxTree.TabIndex = 0
        Me.PictureBoxTree.TabStop = False
        '
        'FormShowTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 404)
        Me.Controls.Add(Me.PictureBoxTree)
        Me.Name = "FormShowTree"
        Me.Text = "Genealogy"
        CType(Me.PictureBoxTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxTree As System.Windows.Forms.PictureBox
End Class
