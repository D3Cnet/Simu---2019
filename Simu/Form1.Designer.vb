<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class principale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principale))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.A6Blanc = New System.Windows.Forms.Label()
        Me.A6Noir = New System.Windows.Forms.Label()
        Me.A5Noir = New System.Windows.Forms.Label()
        Me.A4Noir = New System.Windows.Forms.Label()
        Me.A3Noir = New System.Windows.Forms.Label()
        Me.A2Noir = New System.Windows.Forms.Label()
        Me.A1Noir = New System.Windows.Forms.Label()
        Me.A2Blanc = New System.Windows.Forms.Label()
        Me.A1Blanc = New System.Windows.Forms.Label()
        Me.A3Blanc = New System.Windows.Forms.Label()
        Me.A5Blanc = New System.Windows.Forms.Label()
        Me.A4Blanc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateHeure = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button_connect = New System.Windows.Forms.Button()
        Me.Button_surveiller = New System.Windows.Forms.Button()
        Me.Timer_DB = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox_capture = New System.Windows.Forms.CheckBox()
        Me.Button_afficherBD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NumericUpDown_capture = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer_icon = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_capture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.A6Blanc, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A6Noir, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A5Noir, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A4Noir, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A3Noir, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A2Noir, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A1Noir, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A2Blanc, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A1Blanc, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A3Blanc, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A5Blanc, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A4Blanc, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 5, 0)
        Me.TableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(74, 55)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(239, 115)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'A6Blanc
        '
        Me.A6Blanc.AutoSize = True
        Me.A6Blanc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A6Blanc.Location = New System.Drawing.Point(197, 74)
        Me.A6Blanc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A6Blanc.Name = "A6Blanc"
        Me.A6Blanc.Size = New System.Drawing.Size(40, 41)
        Me.A6Blanc.TabIndex = 19
        Me.A6Blanc.Text = "-3"
        Me.A6Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A6Noir
        '
        Me.A6Noir.AutoSize = True
        Me.A6Noir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A6Noir.Location = New System.Drawing.Point(197, 37)
        Me.A6Noir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A6Noir.Name = "A6Noir"
        Me.A6Noir.Size = New System.Drawing.Size(40, 37)
        Me.A6Noir.TabIndex = 18
        Me.A6Noir.Text = "10"
        Me.A6Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A5Noir
        '
        Me.A5Noir.AutoSize = True
        Me.A5Noir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A5Noir.Location = New System.Drawing.Point(158, 37)
        Me.A5Noir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A5Noir.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A5Noir.Name = "A5Noir"
        Me.A5Noir.Size = New System.Drawing.Size(35, 37)
        Me.A5Noir.TabIndex = 16
        Me.A5Noir.Text = "4"
        Me.A5Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A4Noir
        '
        Me.A4Noir.AutoSize = True
        Me.A4Noir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A4Noir.Location = New System.Drawing.Point(119, 37)
        Me.A4Noir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A4Noir.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A4Noir.Name = "A4Noir"
        Me.A4Noir.Size = New System.Drawing.Size(35, 37)
        Me.A4Noir.TabIndex = 15
        Me.A4Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A3Noir
        '
        Me.A3Noir.AutoSize = True
        Me.A3Noir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A3Noir.Location = New System.Drawing.Point(80, 37)
        Me.A3Noir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A3Noir.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A3Noir.Name = "A3Noir"
        Me.A3Noir.Size = New System.Drawing.Size(35, 37)
        Me.A3Noir.TabIndex = 14
        Me.A3Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A2Noir
        '
        Me.A2Noir.AutoSize = True
        Me.A2Noir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A2Noir.Location = New System.Drawing.Point(41, 37)
        Me.A2Noir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A2Noir.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A2Noir.Name = "A2Noir"
        Me.A2Noir.Size = New System.Drawing.Size(35, 37)
        Me.A2Noir.TabIndex = 13
        Me.A2Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A1Noir
        '
        Me.A1Noir.AutoSize = True
        Me.A1Noir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A1Noir.Location = New System.Drawing.Point(2, 37)
        Me.A1Noir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A1Noir.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A1Noir.Name = "A1Noir"
        Me.A1Noir.Size = New System.Drawing.Size(35, 37)
        Me.A1Noir.TabIndex = 12
        Me.A1Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A2Blanc
        '
        Me.A2Blanc.AutoSize = True
        Me.A2Blanc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A2Blanc.Location = New System.Drawing.Point(41, 74)
        Me.A2Blanc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A2Blanc.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A2Blanc.Name = "A2Blanc"
        Me.A2Blanc.Size = New System.Drawing.Size(35, 41)
        Me.A2Blanc.TabIndex = 11
        Me.A2Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A1Blanc
        '
        Me.A1Blanc.AutoSize = True
        Me.A1Blanc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A1Blanc.Location = New System.Drawing.Point(2, 74)
        Me.A1Blanc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A1Blanc.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A1Blanc.Name = "A1Blanc"
        Me.A1Blanc.Size = New System.Drawing.Size(35, 41)
        Me.A1Blanc.TabIndex = 10
        Me.A1Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A3Blanc
        '
        Me.A3Blanc.AutoSize = True
        Me.A3Blanc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A3Blanc.Location = New System.Drawing.Point(80, 74)
        Me.A3Blanc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A3Blanc.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A3Blanc.Name = "A3Blanc"
        Me.A3Blanc.Size = New System.Drawing.Size(35, 41)
        Me.A3Blanc.TabIndex = 9
        Me.A3Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A5Blanc
        '
        Me.A5Blanc.AutoSize = True
        Me.A5Blanc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A5Blanc.Location = New System.Drawing.Point(158, 74)
        Me.A5Blanc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A5Blanc.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A5Blanc.Name = "A5Blanc"
        Me.A5Blanc.Size = New System.Drawing.Size(35, 41)
        Me.A5Blanc.TabIndex = 8
        Me.A5Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A4Blanc
        '
        Me.A4Blanc.AutoSize = True
        Me.A4Blanc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A4Blanc.Location = New System.Drawing.Point(119, 74)
        Me.A4Blanc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.A4Blanc.MaximumSize = New System.Drawing.Size(45, 49)
        Me.A4Blanc.Name = "A4Blanc"
        Me.A4Blanc.Size = New System.Drawing.Size(35, 41)
        Me.A4Blanc.TabIndex = 6
        Me.A4Blanc.Text = "4"
        Me.A4Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(158, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 37)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "A5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(119, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "A4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(80, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "A3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(41, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(197, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 37)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "A6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(22, 94)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(47, 76)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(2, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 38)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Blancs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(2, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.MaximumSize = New System.Drawing.Size(45, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 38)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Noirs"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateHeure
        '
        Me.dateHeure.AutoSize = True
        Me.dateHeure.Location = New System.Drawing.Point(73, 42)
        Me.dateHeure.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dateHeure.Name = "dateHeure"
        Me.dateHeure.Size = New System.Drawing.Size(95, 13)
        Me.dateHeure.TabIndex = 2
        Me.dateHeure.Text = "11/11/2011 11:11"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel_info})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 203)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(327, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel_info
        '
        Me.ToolStripStatusLabel_info.Name = "ToolStripStatusLabel_info"
        Me.ToolStripStatusLabel_info.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel_info.Text = "Lancement"
        '
        'Button_connect
        '
        Me.Button_connect.Location = New System.Drawing.Point(12, 12)
        Me.Button_connect.Name = "Button_connect"
        Me.Button_connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_connect.TabIndex = 1
        Me.Button_connect.Text = "Connect"
        Me.Button_connect.UseVisualStyleBackColor = True
        '
        'Button_surveiller
        '
        Me.Button_surveiller.Location = New System.Drawing.Point(93, 12)
        Me.Button_surveiller.Name = "Button_surveiller"
        Me.Button_surveiller.Size = New System.Drawing.Size(75, 23)
        Me.Button_surveiller.TabIndex = 2
        Me.Button_surveiller.Text = "Surveiller"
        Me.Button_surveiller.UseVisualStyleBackColor = True
        '
        'Timer_DB
        '
        Me.Timer_DB.Interval = 10000
        '
        'CheckBox_capture
        '
        Me.CheckBox_capture.AutoSize = True
        Me.CheckBox_capture.Enabled = False
        Me.CheckBox_capture.Location = New System.Drawing.Point(22, 174)
        Me.CheckBox_capture.Name = "CheckBox_capture"
        Me.CheckBox_capture.Size = New System.Drawing.Size(214, 17)
        Me.CheckBox_capture.TabIndex = 4
        Me.CheckBox_capture.Text = "Capturer en base de données toutes les"
        Me.CheckBox_capture.UseVisualStyleBackColor = True
        '
        'Button_afficherBD
        '
        Me.Button_afficherBD.Location = New System.Drawing.Point(240, 12)
        Me.Button_afficherBD.Name = "Button_afficherBD"
        Me.Button_afficherBD.Size = New System.Drawing.Size(75, 23)
        Me.Button_afficherBD.TabIndex = 3
        Me.Button_afficherBD.Text = "Contenu"
        Me.Button_afficherBD.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Simu.My.Resources.Resources.floppy
        Me.PictureBox1.Location = New System.Drawing.Point(39, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'NumericUpDown_capture
        '
        Me.NumericUpDown_capture.Enabled = False
        Me.NumericUpDown_capture.Location = New System.Drawing.Point(235, 174)
        Me.NumericUpDown_capture.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_capture.Name = "NumericUpDown_capture"
        Me.NumericUpDown_capture.Size = New System.Drawing.Size(39, 20)
        Me.NumericUpDown_capture.TabIndex = 5
        Me.NumericUpDown_capture.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(274, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "secondes"
        '
        'Timer_icon
        '
        Me.Timer_icon.Interval = 1000
        '
        'principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 225)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumericUpDown_capture)
        Me.Controls.Add(Me.Button_afficherBD)
        Me.Controls.Add(Me.CheckBox_capture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_surveiller)
        Me.Controls.Add(Me.Button_connect)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dateHeure)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "principale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Noir et blanc"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_capture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents A5Noir As Label
    Friend WithEvents A4Noir As Label
    Friend WithEvents A3Noir As Label
    Friend WithEvents A2Noir As Label
    Friend WithEvents A1Noir As Label
    Friend WithEvents dateHeure As Label
    Friend WithEvents A2Blanc As Label
    Friend WithEvents A1Blanc As Label
    Friend WithEvents A3Blanc As Label
    Friend WithEvents A5Blanc As Label
    Friend WithEvents A4Blanc As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel_info As ToolStripStatusLabel
    Friend WithEvents Button_connect As Button
    Friend WithEvents Button_surveiller As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents A6Noir As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents A6Blanc As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer_DB As Timer
    Friend WithEvents CheckBox_capture As CheckBox
    Friend WithEvents Button_afficherBD As Button
    Friend WithEvents NumericUpDown_capture As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer_icon As Timer
End Class
