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
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        showButton = New Button()
        clearButton = New Button()
        backgroundButton = New Button()
        closeButton = New Button()
        CheckBox1 = New CheckBox()
        OpenFileDialog1 = New OpenFileDialog()
        ColorDialog1 = New ColorDialog()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 1, 1)
        TableLayoutPanel1.Controls.Add(CheckBox1, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(1074, 527)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        TableLayoutPanel1.SetColumnSpan(PictureBox1, 2)
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1068, 468)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(showButton)
        FlowLayoutPanel1.Controls.Add(clearButton)
        FlowLayoutPanel1.Controls.Add(backgroundButton)
        FlowLayoutPanel1.Controls.Add(closeButton)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New Point(164, 477)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(907, 47)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' showButton
        ' 
        showButton.AutoSize = True
        showButton.Location = New Point(712, 3)
        showButton.Name = "showButton"
        showButton.Size = New Size(192, 40)
        showButton.TabIndex = 0
        showButton.Text = "Show a picture"
        showButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.AutoSize = True
        clearButton.Location = New Point(523, 3)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(183, 40)
        clearButton.TabIndex = 1
        clearButton.Text = "Clear the picture"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' backgroundButton
        ' 
        backgroundButton.AutoSize = True
        backgroundButton.Location = New Point(225, 3)
        backgroundButton.Name = "backgroundButton"
        backgroundButton.Size = New Size(292, 40)
        backgroundButton.TabIndex = 2
        backgroundButton.Text = "Set the background color"
        backgroundButton.UseVisualStyleBackColor = True
        ' 
        ' closeButton
        ' 
        closeButton.AutoSize = True
        closeButton.Location = New Point(107, 3)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(112, 40)
        closeButton.TabIndex = 3
        closeButton.Text = "Close"
        closeButton.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(3, 477)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(106, 34)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Stretch"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
        OpenFileDialog1.Title = "Select a picture file"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1074, 527)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Picture Viewer"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents showButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backgroundButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
