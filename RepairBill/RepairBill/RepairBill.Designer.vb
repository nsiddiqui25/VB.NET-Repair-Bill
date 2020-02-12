<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepairBill
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLabor = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(40, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(85, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Customer Name:"
        '
        'lblLabor
        '
        Me.lblLabor.AutoSize = True
        Me.lblLabor.Location = New System.Drawing.Point(45, 77)
        Me.lblLabor.Name = "lblLabor"
        Me.lblLabor.Size = New System.Drawing.Size(80, 13)
        Me.lblLabor.TabIndex = 1
        Me.lblLabor.Text = "Hours of Labor:"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(55, 122)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(70, 13)
        Me.lblParts.TabIndex = 2
        Me.lblParts.Text = "Cost of Parts:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(138, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 20)
        Me.txtName.TabIndex = 3
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(138, 74)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtLabor.TabIndex = 4
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(138, 119)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(288, 74)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 65)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(138, 168)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(250, 121)
        Me.lstDisplay.TabIndex = 7
        '
        'frmRepairBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 325)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblParts)
        Me.Controls.Add(Me.lblLabor)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmRepairBill"
        Me.Text = "Repair Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblLabor As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstDisplay As ListBox
End Class
