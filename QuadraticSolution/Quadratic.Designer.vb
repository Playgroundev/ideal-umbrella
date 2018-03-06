<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuadratic
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblA = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.LblB = New System.Windows.Forms.Label()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.LblC = New System.Windows.Forms.Label()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnSolution = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblResult1 = New System.Windows.Forms.Label()
        Me.LblResult2 = New System.Windows.Forms.Label()
        Me.TxtResult1 = New System.Windows.Forms.TextBox()
        Me.TxtResult2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtResult2)
        Me.Panel1.Controls.Add(Me.TxtResult1)
        Me.Panel1.Controls.Add(Me.LblResult2)
        Me.Panel1.Controls.Add(Me.LblResult1)
        Me.Panel1.Controls.Add(Me.BtnExit)
        Me.Panel1.Controls.Add(Me.BtnSolution)
        Me.Panel1.Controls.Add(Me.PrgBar)
        Me.Panel1.Controls.Add(Me.TxtC)
        Me.Panel1.Controls.Add(Me.LblC)
        Me.Panel1.Controls.Add(Me.TxtB)
        Me.Panel1.Controls.Add(Me.LblB)
        Me.Panel1.Controls.Add(Me.TxtA)
        Me.Panel1.Controls.Add(Me.LblA)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 323)
        Me.Panel1.TabIndex = 0
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Location = New System.Drawing.Point(33, 22)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(42, 13)
        Me.LblA.TabIndex = 0
        Me.LblA.Text = "Enter A"
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(91, 19)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(207, 20)
        Me.TxtA.TabIndex = 1
        '
        'LblB
        '
        Me.LblB.AutoSize = True
        Me.LblB.Location = New System.Drawing.Point(33, 66)
        Me.LblB.Name = "LblB"
        Me.LblB.Size = New System.Drawing.Size(42, 13)
        Me.LblB.TabIndex = 2
        Me.LblB.Text = "Enter B"
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(91, 63)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(207, 20)
        Me.TxtB.TabIndex = 3
        '
        'LblC
        '
        Me.LblC.AutoSize = True
        Me.LblC.Location = New System.Drawing.Point(33, 115)
        Me.LblC.Name = "LblC"
        Me.LblC.Size = New System.Drawing.Size(42, 13)
        Me.LblC.TabIndex = 4
        Me.LblC.Text = "Enter C"
        '
        'TxtC
        '
        Me.TxtC.Location = New System.Drawing.Point(91, 112)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(207, 20)
        Me.TxtC.TabIndex = 5
        '
        'PrgBar
        '
        Me.PrgBar.Location = New System.Drawing.Point(36, 164)
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(262, 14)
        Me.PrgBar.TabIndex = 6
        Me.PrgBar.Visible = False
        '
        'BtnSolution
        '
        Me.BtnSolution.Location = New System.Drawing.Point(36, 202)
        Me.BtnSolution.Name = "BtnSolution"
        Me.BtnSolution.Size = New System.Drawing.Size(118, 23)
        Me.BtnSolution.TabIndex = 7
        Me.BtnSolution.Text = "Get Solution"
        Me.BtnSolution.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(180, 202)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(118, 23)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblResult1
        '
        Me.LblResult1.AutoSize = True
        Me.LblResult1.Location = New System.Drawing.Point(36, 255)
        Me.LblResult1.Name = "LblResult1"
        Me.LblResult1.Size = New System.Drawing.Size(23, 13)
        Me.LblResult1.TabIndex = 9
        Me.LblResult1.Text = "X 1"
        '
        'LblResult2
        '
        Me.LblResult2.AutoSize = True
        Me.LblResult2.Location = New System.Drawing.Point(36, 280)
        Me.LblResult2.Name = "LblResult2"
        Me.LblResult2.Size = New System.Drawing.Size(23, 13)
        Me.LblResult2.TabIndex = 10
        Me.LblResult2.Text = "X 2"
        '
        'TxtResult1
        '
        Me.TxtResult1.Location = New System.Drawing.Point(76, 252)
        Me.TxtResult1.Name = "TxtResult1"
        Me.TxtResult1.ReadOnly = True
        Me.TxtResult1.Size = New System.Drawing.Size(152, 20)
        Me.TxtResult1.TabIndex = 11
        '
        'TxtResult2
        '
        Me.TxtResult2.Location = New System.Drawing.Point(76, 280)
        Me.TxtResult2.Name = "TxtResult2"
        Me.TxtResult2.ReadOnly = True
        Me.TxtResult2.Size = New System.Drawing.Size(152, 20)
        Me.TxtResult2.TabIndex = 12
        '
        'FrmQuadratic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 347)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmQuadratic"
        Me.Text = "Quadratic Solution"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtA As System.Windows.Forms.TextBox
    Friend WithEvents LblA As System.Windows.Forms.Label
    Friend WithEvents TxtB As System.Windows.Forms.TextBox
    Friend WithEvents LblB As System.Windows.Forms.Label
    Friend WithEvents TxtC As System.Windows.Forms.TextBox
    Friend WithEvents LblC As System.Windows.Forms.Label
    Friend WithEvents PrgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnSolution As System.Windows.Forms.Button
    Friend WithEvents TxtResult2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtResult1 As System.Windows.Forms.TextBox
    Friend WithEvents LblResult2 As System.Windows.Forms.Label
    Friend WithEvents LblResult1 As System.Windows.Forms.Label

End Class
