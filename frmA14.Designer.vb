<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmA14
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
        Me.grpConversion = New System.Windows.Forms.GroupBox()
        Me.btnToggleDictionary = New System.Windows.Forms.Button()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.txtTextese = New System.Windows.Forms.TextBox()
        Me.lblTextese = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.lblEnglish = New System.Windows.Forms.Label()
        Me.grpDictionary = New System.Windows.Forms.GroupBox()
        Me.dgvDictionary = New System.Windows.Forms.DataGridView()
        Me.grpConversion.SuspendLayout()
        Me.grpDictionary.SuspendLayout()
        CType(Me.dgvDictionary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpConversion
        '
        Me.grpConversion.Controls.Add(Me.btnToggleDictionary)
        Me.grpConversion.Controls.Add(Me.btnTranslate)
        Me.grpConversion.Controls.Add(Me.txtTextese)
        Me.grpConversion.Controls.Add(Me.lblTextese)
        Me.grpConversion.Controls.Add(Me.txtEnglish)
        Me.grpConversion.Controls.Add(Me.lblEnglish)
        Me.grpConversion.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversion.Location = New System.Drawing.Point(12, 12)
        Me.grpConversion.Name = "grpConversion"
        Me.grpConversion.Size = New System.Drawing.Size(582, 244)
        Me.grpConversion.TabIndex = 0
        Me.grpConversion.TabStop = False
        Me.grpConversion.Text = "Conversion Station"
        '
        'btnToggleDictionary
        '
        Me.btnToggleDictionary.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleDictionary.Location = New System.Drawing.Point(10, 191)
        Me.btnToggleDictionary.Name = "btnToggleDictionary"
        Me.btnToggleDictionary.Size = New System.Drawing.Size(250, 31)
        Me.btnToggleDictionary.TabIndex = 4
        Me.btnToggleDictionary.Text = "Toggle Dictionary" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnToggleDictionary.UseVisualStyleBackColor = True
        '
        'btnTranslate
        '
        Me.btnTranslate.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTranslate.Location = New System.Drawing.Point(10, 94)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(250, 31)
        Me.btnTranslate.TabIndex = 1
        Me.btnTranslate.Text = "Translate to Textese"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'txtTextese
        '
        Me.txtTextese.Enabled = False
        Me.txtTextese.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextese.Location = New System.Drawing.Point(10, 154)
        Me.txtTextese.Name = "txtTextese"
        Me.txtTextese.Size = New System.Drawing.Size(544, 31)
        Me.txtTextese.TabIndex = 3
        '
        'lblTextese
        '
        Me.lblTextese.AutoSize = True
        Me.lblTextese.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextese.Location = New System.Drawing.Point(6, 128)
        Me.lblTextese.Name = "lblTextese"
        Me.lblTextese.Size = New System.Drawing.Size(71, 23)
        Me.lblTextese.TabIndex = 2
        Me.lblTextese.Text = "Textese:"
        '
        'txtEnglish
        '
        Me.txtEnglish.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnglish.Location = New System.Drawing.Point(10, 57)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(544, 31)
        Me.txtEnglish.TabIndex = 1
        '
        'lblEnglish
        '
        Me.lblEnglish.AutoSize = True
        Me.lblEnglish.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnglish.Location = New System.Drawing.Point(6, 31)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(68, 23)
        Me.lblEnglish.TabIndex = 0
        Me.lblEnglish.Text = "English:"
        '
        'grpDictionary
        '
        Me.grpDictionary.Controls.Add(Me.dgvDictionary)
        Me.grpDictionary.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDictionary.Location = New System.Drawing.Point(600, 12)
        Me.grpDictionary.Name = "grpDictionary"
        Me.grpDictionary.Size = New System.Drawing.Size(363, 366)
        Me.grpDictionary.TabIndex = 1
        Me.grpDictionary.TabStop = False
        Me.grpDictionary.Text = "English to Textese Dictionary"
        '
        'dgvDictionary
        '
        Me.dgvDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDictionary.Location = New System.Drawing.Point(6, 34)
        Me.dgvDictionary.Name = "dgvDictionary"
        Me.dgvDictionary.RowHeadersWidth = 51
        Me.dgvDictionary.RowTemplate.Height = 24
        Me.dgvDictionary.Size = New System.Drawing.Size(345, 318)
        Me.dgvDictionary.TabIndex = 0
        '
        'frmA14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 385)
        Me.Controls.Add(Me.grpDictionary)
        Me.Controls.Add(Me.grpConversion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment 14 - Textese"
        Me.grpConversion.ResumeLayout(False)
        Me.grpConversion.PerformLayout()
        Me.grpDictionary.ResumeLayout(False)
        CType(Me.dgvDictionary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpConversion As GroupBox
    Friend WithEvents btnTranslate As Button
    Friend WithEvents txtTextese As TextBox
    Friend WithEvents lblTextese As Label
    Friend WithEvents txtEnglish As TextBox
    Friend WithEvents lblEnglish As Label
    Friend WithEvents btnToggleDictionary As Button
    Friend WithEvents grpDictionary As GroupBox
    Friend WithEvents dgvDictionary As DataGridView
End Class
