<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffichageData
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView_event = New System.Windows.Forms.DataGridView()
        Me.ComboBox_evenement = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView_event, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_event
        '
        Me.DataGridView_event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_event.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView_event.Name = "DataGridView_event"
        Me.DataGridView_event.Size = New System.Drawing.Size(295, 399)
        Me.DataGridView_event.TabIndex = 0
        '
        'ComboBox_evenement
        '
        Me.ComboBox_evenement.FormattingEnabled = True
        Me.ComboBox_evenement.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox_evenement.Name = "ComboBox_evenement"
        Me.ComboBox_evenement.Size = New System.Drawing.Size(295, 21)
        Me.ComboBox_evenement.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AffichageData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 482)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox_evenement)
        Me.Controls.Add(Me.DataGridView_event)
        Me.Name = "AffichageData"
        Me.Text = "AffichageData"
        CType(Me.DataGridView_event, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_event As DataGridView
    Friend WithEvents ComboBox_evenement As ComboBox
    Friend WithEvents Button1 As Button
End Class
