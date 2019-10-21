<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(game))
        Me.Monster1 = New System.Windows.Forms.PictureBox()
        Me.txt_score = New System.Windows.Forms.Label()
        Me.lbl_equal = New System.Windows.Forms.Label()
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.txt_time = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.txt_equal = New System.Windows.Forms.Label()
        Me.mob = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Monster1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Monster1
        '
        Me.Monster1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Monster1.Image = CType(resources.GetObject("Monster1.Image"), System.Drawing.Image)
        Me.Monster1.Location = New System.Drawing.Point(228, 210)
        Me.Monster1.Name = "Monster1"
        Me.Monster1.Size = New System.Drawing.Size(99, 102)
        Me.Monster1.TabIndex = 0
        Me.Monster1.TabStop = False
        '
        'txt_score
        '
        Me.txt_score.AutoSize = True
        Me.txt_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_score.Location = New System.Drawing.Point(23, 569)
        Me.txt_score.Name = "txt_score"
        Me.txt_score.Size = New System.Drawing.Size(85, 31)
        Me.txt_score.TabIndex = 1
        Me.txt_score.Text = "Score"
        '
        'lbl_equal
        '
        Me.lbl_equal.AutoSize = True
        Me.lbl_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_equal.Location = New System.Drawing.Point(111, 569)
        Me.lbl_equal.Name = "lbl_equal"
        Me.lbl_equal.Size = New System.Drawing.Size(37, 31)
        Me.lbl_equal.TabIndex = 1
        Me.lbl_equal.Text = "= "
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(154, 569)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(29, 31)
        Me.lbl_score.TabIndex = 1
        Me.lbl_score.Text = "0"
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(12, 614)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(201, 90)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'txt_time
        '
        Me.txt_time.AutoSize = True
        Me.txt_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_time.Location = New System.Drawing.Point(23, 526)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(74, 31)
        Me.txt_time.TabIndex = 1
        Me.txt_time.Text = "Time"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(154, 526)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(29, 31)
        Me.lbl_time.TabIndex = 1
        Me.lbl_time.Text = "0"
        '
        'txt_equal
        '
        Me.txt_equal.AutoSize = True
        Me.txt_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_equal.Location = New System.Drawing.Point(111, 526)
        Me.txt_equal.Name = "txt_equal"
        Me.txt_equal.Size = New System.Drawing.Size(37, 31)
        Me.txt_equal.TabIndex = 1
        Me.txt_equal.Text = "= "
        '
        'mob
        '
        Me.mob.Interval = 40
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(752, 706)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_equal)
        Me.Controls.Add(Me.lbl_equal)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.txt_time)
        Me.Controls.Add(Me.txt_score)
        Me.Controls.Add(Me.Monster1)
        Me.Name = "game"
        CType(Me.Monster1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Monster1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_score As System.Windows.Forms.Label
    Friend WithEvents lbl_equal As System.Windows.Forms.Label
    Friend WithEvents lbl_score As System.Windows.Forms.Label
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents txt_time As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents txt_equal As System.Windows.Forms.Label
    Friend WithEvents mob As System.Windows.Forms.Timer

End Class
