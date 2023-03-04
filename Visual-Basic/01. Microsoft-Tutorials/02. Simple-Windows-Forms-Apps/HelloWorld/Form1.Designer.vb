<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnClickThis = New Button()
        lblHelloWorld = New Label()
        SuspendLayout()
        ' 
        ' btnClickThis
        ' 
        btnClickThis.Location = New Point(345, 148)
        btnClickThis.Name = "btnClickThis"
        btnClickThis.Size = New Size(112, 34)
        btnClickThis.TabIndex = 0
        btnClickThis.Text = "Click this"
        btnClickThis.UseVisualStyleBackColor = True
        ' 
        ' lblHelloWorld
        ' 
        lblHelloWorld.AutoSize = True
        lblHelloWorld.Location = New Point(345, 246)
        lblHelloWorld.Name = "lblHelloWorld"
        lblHelloWorld.Size = New Size(128, 30)
        lblHelloWorld.TabIndex = 1
        lblHelloWorld.Text = "This is Label"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHelloWorld)
        Controls.Add(btnClickThis)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickThis As Button
    Friend WithEvents lblHelloWorld As Label
End Class
