<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOCR
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
        Me.components = New System.ComponentModel.Container()
        Me.tblTextBoxAndImageBox = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.txtOCR = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.ibImage = New Emgu.CV.UI.ImageBox()
        Me.tblTextBoxAndImageBox.SuspendLayout()
        CType(Me.ibImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblTextBoxAndImageBox
        '
        Me.tblTextBoxAndImageBox.ColumnCount = 1
        Me.tblTextBoxAndImageBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblTextBoxAndImageBox.Controls.Add(Me.txtOCR, 0, 0)
        Me.tblTextBoxAndImageBox.Controls.Add(Me.ibImage, 0, 1)
        Me.tblTextBoxAndImageBox.Location = New System.Drawing.Point(3, 26)
        Me.tblTextBoxAndImageBox.Name = "tblTextBoxAndImageBox"
        Me.tblTextBoxAndImageBox.RowCount = 2
        Me.tblTextBoxAndImageBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tblTextBoxAndImageBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tblTextBoxAndImageBox.Size = New System.Drawing.Size(703, 396)
        Me.tblTextBoxAndImageBox.TabIndex = 0
        '
        'txtFile
        '
        Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile.Location = New System.Drawing.Point(77, 0)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(584, 22)
        Me.txtFile.TabIndex = 1
        '
        'txtOCR
        '
        Me.txtOCR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCR.Location = New System.Drawing.Point(3, 3)
        Me.txtOCR.Multiline = True
        Me.txtOCR.Name = "txtOCR"
        Me.txtOCR.ReadOnly = True
        Me.txtOCR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOCR.Size = New System.Drawing.Size(697, 132)
        Me.txtOCR.TabIndex = 0
        '
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.Location = New System.Drawing.Point(0, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(71, 23)
        Me.lblFile.TabIndex = 2
        Me.lblFile.Text = "Pilih File"
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFile
        '
        Me.btnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Location = New System.Drawing.Point(667, 0)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(36, 23)
        Me.btnFile.TabIndex = 3
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'ibImage
        '
        Me.ibImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ibImage.Location = New System.Drawing.Point(3, 141)
        Me.ibImage.Name = "ibImage"
        Me.ibImage.Size = New System.Drawing.Size(697, 252)
        Me.ibImage.TabIndex = 2
        Me.ibImage.TabStop = False
        '
        'frmOCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 431)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.tblTextBoxAndImageBox)
        Me.Name = "frmOCR"
        Me.Text = "Simple OCR"
        Me.tblTextBoxAndImageBox.ResumeLayout(False)
        Me.tblTextBoxAndImageBox.PerformLayout()
        CType(Me.ibImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblTextBoxAndImageBox As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtOCR As System.Windows.Forms.TextBox
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ibImage As Emgu.CV.UI.ImageBox

End Class
