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
        components = New ComponentModel.Container()
        timeLabel = New Label()
        Label1 = New Label()
        plusLeftLabel = New Label()
        plusRightLabel = New Label()
        Label3 = New Label()
        Label2 = New Label()
        sum = New NumericUpDown()
        Label4 = New Label()
        Label5 = New Label()
        minusRightLabel = New Label()
        minusLeftLabel = New Label()
        Label8 = New Label()
        Label9 = New Label()
        timesRightLabel = New Label()
        timesLeftLabel = New Label()
        Label12 = New Label()
        Label13 = New Label()
        dividedRightLabel = New Label()
        dividedLeftLabel = New Label()
        difference = New NumericUpDown()
        product = New NumericUpDown()
        quotient = New NumericUpDown()
        startButton = New Button()
        Timer1 = New Timer(components)
        CType(sum, ComponentModel.ISupportInitialize).BeginInit()
        CType(difference, ComponentModel.ISupportInitialize).BeginInit()
        CType(product, ComponentModel.ISupportInitialize).BeginInit()
        CType(quotient, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' timeLabel
        ' 
        timeLabel.BorderStyle = BorderStyle.FixedSingle
        timeLabel.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        timeLabel.Location = New Point(275, 2)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(200, 41)
        timeLabel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(129, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 41)
        Label1.TabIndex = 1
        Label1.Text = "Time Left"' 
        ' plusLeftLabel
        ' 
        plusLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        plusLeftLabel.Location = New Point(50, 51)
        plusLeftLabel.Name = "plusLeftLabel"
        plusLeftLabel.Size = New Size(60, 50)
        plusLeftLabel.TabIndex = 2
        plusLeftLabel.Text = "?"
        plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' plusRightLabel
        ' 
        plusRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        plusRightLabel.Location = New Point(182, 51)
        plusRightLabel.Name = "plusRightLabel"
        plusRightLabel.Size = New Size(60, 50)
        plusRightLabel.TabIndex = 3
        plusRightLabel.Text = "?"
        plusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(248, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 50)
        Label3.TabIndex = 4
        Label3.Text = "="
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(116, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 50)
        Label2.TabIndex = 5
        Label2.Text = "+"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' sum
        ' 
        sum.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        sum.Location = New Point(323, 46)
        sum.Name = "sum"
        sum.Size = New Size(100, 55)
        sum.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(116, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 50)
        Label4.TabIndex = 10
        Label4.Text = "-"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(248, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 50)
        Label5.TabIndex = 9
        Label5.Text = "="
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusRightLabel
        ' 
        minusRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        minusRightLabel.Location = New Point(182, 107)
        minusRightLabel.Name = "minusRightLabel"
        minusRightLabel.Size = New Size(60, 50)
        minusRightLabel.TabIndex = 8
        minusRightLabel.Text = "?"
        minusRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' minusLeftLabel
        ' 
        minusLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        minusLeftLabel.Location = New Point(50, 107)
        minusLeftLabel.Name = "minusLeftLabel"
        minusLeftLabel.Size = New Size(60, 50)
        minusLeftLabel.TabIndex = 7
        minusLeftLabel.Text = "?"
        minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(116, 169)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 50)
        Label8.TabIndex = 14
        Label8.Text = "×"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(248, 169)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 50)
        Label9.TabIndex = 13
        Label9.Text = "="
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesRightLabel
        ' 
        timesRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        timesRightLabel.Location = New Point(182, 169)
        timesRightLabel.Name = "timesRightLabel"
        timesRightLabel.Size = New Size(60, 50)
        timesRightLabel.TabIndex = 12
        timesRightLabel.Text = "?"
        timesRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timesLeftLabel
        ' 
        timesLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        timesLeftLabel.Location = New Point(50, 169)
        timesLeftLabel.Name = "timesLeftLabel"
        timesLeftLabel.Size = New Size(60, 50)
        timesLeftLabel.TabIndex = 11
        timesLeftLabel.Text = "?"
        timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(116, 231)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 50)
        Label12.TabIndex = 18
        Label12.Text = "÷"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(248, 231)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 50)
        Label13.TabIndex = 17
        Label13.Text = "="
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedRightLabel
        ' 
        dividedRightLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        dividedRightLabel.Location = New Point(182, 231)
        dividedRightLabel.Name = "dividedRightLabel"
        dividedRightLabel.Size = New Size(60, 50)
        dividedRightLabel.TabIndex = 16
        dividedRightLabel.Text = "?"
        dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dividedLeftLabel
        ' 
        dividedLeftLabel.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        dividedLeftLabel.Location = New Point(50, 231)
        dividedLeftLabel.Name = "dividedLeftLabel"
        dividedLeftLabel.Size = New Size(60, 50)
        dividedLeftLabel.TabIndex = 15
        dividedLeftLabel.Text = "?"
        dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' difference
        ' 
        difference.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        difference.Location = New Point(323, 107)
        difference.Name = "difference"
        difference.Size = New Size(100, 55)
        difference.TabIndex = 2
        ' 
        ' product
        ' 
        product.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        product.Location = New Point(323, 169)
        product.Name = "product"
        product.Size = New Size(100, 55)
        product.TabIndex = 3
        ' 
        ' quotient
        ' 
        quotient.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        quotient.Location = New Point(323, 231)
        quotient.Name = "quotient"
        quotient.Size = New Size(100, 55)
        quotient.TabIndex = 4
        ' 
        ' startButton
        ' 
        startButton.AutoSize = True
        startButton.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        startButton.Location = New Point(129, 295)
        startButton.Name = "startButton"
        startButton.Size = New Size(191, 48)
        startButton.TabIndex = 0
        startButton.Text = "Start the quiz"
        startButton.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 344)
        Controls.Add(startButton)
        Controls.Add(quotient)
        Controls.Add(product)
        Controls.Add(difference)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(dividedRightLabel)
        Controls.Add(dividedLeftLabel)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(timesRightLabel)
        Controls.Add(timesLeftLabel)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(minusRightLabel)
        Controls.Add(minusLeftLabel)
        Controls.Add(sum)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(plusRightLabel)
        Controls.Add(plusLeftLabel)
        Controls.Add(Label1)
        Controls.Add(timeLabel)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Math Quiz"
        CType(sum, ComponentModel.ISupportInitialize).EndInit()
        CType(difference, ComponentModel.ISupportInitialize).EndInit()
        CType(product, ComponentModel.ISupportInitialize).EndInit()
        CType(quotient, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusLeftLabel As Label
    Friend WithEvents plusRightLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents minusRightLabel As Label
    Friend WithEvents minusLeftLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents timesRightLabel As Label
    Friend WithEvents timesLeftLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dividedRightLabel As Label
    Friend WithEvents dividedLeftLabel As Label
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents product As NumericUpDown
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents startButton As Button
    Friend WithEvents Timer1 As Timer
End Class
