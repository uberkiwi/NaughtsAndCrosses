<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameWindow
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
    Public Class GlobalV
        Public Shared PlayerTurn As Integer = 0
        Public Shared Used1 As Boolean = False
        Public Shared Used2 As Boolean = False
        Public Shared Used3 As Boolean = False
        Public Shared Used4 As Boolean = False
        Public Shared Used5 As Boolean = False
        Public Shared Used6 As Boolean = False
        Public Shared Used7 As Boolean = False
        Public Shared Used8 As Boolean = False
        Public Shared Used9 As Boolean = False
        Public Shared Grid(2, 2) As Integer


    End Class

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameWindow))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.TurnDisplay = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(392, 586)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(180, 20)
        Me.ResetBtn.TabIndex = 10
        Me.ResetBtn.Text = "Reset Game"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Location = New System.Drawing.Point(200, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Location = New System.Drawing.Point(395, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox6.Location = New System.Drawing.Point(395, 200)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Location = New System.Drawing.Point(198, 200)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Location = New System.Drawing.Point(4, 200)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox9.Location = New System.Drawing.Point(395, 397)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 26
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox8.Location = New System.Drawing.Point(200, 397)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 25
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox7.Location = New System.Drawing.Point(3, 397)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'TurnDisplay
        '
        Me.TurnDisplay.Location = New System.Drawing.Point(8, 586)
        Me.TurnDisplay.Name = "TurnDisplay"
        Me.TurnDisplay.ReadOnly = True
        Me.TurnDisplay.Size = New System.Drawing.Size(180, 20)
        Me.TurnDisplay.TabIndex = 27
        Me.TurnDisplay.Text = "Naught's Turn"
        '
        'GameWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(584, 611)
        Me.Controls.Add(Me.TurnDisplay)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(600, 650)
        Me.MinimumSize = New System.Drawing.Size(600, 650)
        Me.Name = "GameWindow"
        Me.Text = "Naughts and Crosses"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ResetBtn As Button

    Private Sub GameWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 2
            For j = 0 To 2
                GlobalV.Grid(i, j) = Nothing
            Next
        Next

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used1 = False Then
            PictureBox1.Image = My.Resources.Naught
            GlobalV.Used1 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(0, 0) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used1 = False Then
            PictureBox1.Image = My.Resources.Cross
            GlobalV.Used1 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(0, 0) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used2 = False Then
            PictureBox2.Image = My.Resources.Naught
            GlobalV.Used2 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(1, 0) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used2 = False Then
            PictureBox2.Image = My.Resources.Cross
            GlobalV.Used2 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(1, 0) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used3 = False Then
            PictureBox3.Image = My.Resources.Naught
            GlobalV.Used3 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(2, 0) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used3 = False Then
            PictureBox3.Image = My.Resources.Cross
            GlobalV.Used3 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(2, 0) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used4 = False Then
            PictureBox4.Image = My.Resources.Naught
            GlobalV.Used4 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(0, 1) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used4 = False Then
            PictureBox4.Image = My.Resources.Cross
            GlobalV.Used4 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(0, 1) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used5 = False Then
            PictureBox5.Image = My.Resources.Naught
            GlobalV.Used5 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(1, 1) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used5 = False Then
            PictureBox5.Image = My.Resources.Cross
            GlobalV.Used5 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(1, 1) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used6 = False Then
            PictureBox6.Image = My.Resources.Naught
            GlobalV.Used6 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(2, 1) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used6 = False Then
            PictureBox6.Image = My.Resources.Cross
            GlobalV.Used6 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(2, 1) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used7 = False Then
            PictureBox7.Image = My.Resources.Naught
            GlobalV.Used7 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(0, 2) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used7 = False Then
            PictureBox7.Image = My.Resources.Cross
            GlobalV.Used7 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(0, 2) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used8 = False Then
            PictureBox8.Image = My.Resources.Naught
            GlobalV.Used8 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(1, 2) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used8 = False Then
            PictureBox8.Image = My.Resources.Cross
            GlobalV.Used8 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(1, 2) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If GlobalV.PlayerTurn = 0 And GlobalV.Used9 = False Then
            PictureBox9.Image = My.Resources.Naught
            GlobalV.Used9 = True
            GlobalV.PlayerTurn = 1
            GlobalV.Grid(2, 2) = 1
            TurnDisplay.Text = "Cross's Turn"
        ElseIf GlobalV.PlayerTurn = 1 And GlobalV.Used9 = False Then
            PictureBox9.Image = My.Resources.Cross
            GlobalV.Used9 = True
            GlobalV.PlayerTurn = 0
            GlobalV.Grid(2, 2) = 2
            TurnDisplay.Text = "Naught's Turn"
        End If
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox

    Private Sub TurnDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalV.PlayerTurn = 0 Then
            TurnDisplay.Text = "Naught's Turn"
        ElseIf GlobalV.PlayerTurn = 1 Then
            Me.Text = "Cross's Turn"
        End If
    End Sub

    Friend WithEvents TurnDisplay As MaskedTextBox

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        TurnDisplay.Text = "Naught's Turn"
        GlobalV.Used1 = False
        GlobalV.Used2 = False
        GlobalV.Used3 = False
        GlobalV.Used4 = False
        GlobalV.Used5 = False
        GlobalV.Used6 = False
        GlobalV.Used7 = False
        GlobalV.Used8 = False
        GlobalV.Used9 = False
        GlobalV.PlayerTurn = 0
        For i = 0 To 2
            For j = 0 To 2
                GlobalV.Grid(i, j) = Nothing
            Next
        Next
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        PictureBox6.Image = Nothing
        PictureBox7.Image = Nothing
        PictureBox8.Image = Nothing
        PictureBox9.Image = Nothing
    End Sub

    Private Sub GameWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If (((GlobalV.Grid(0, 0) And GlobalV.Grid(1, 0) And GlobalV.Grid(2, 0)) Or
            (GlobalV.Grid(0, 1) And GlobalV.Grid(1, 1) And GlobalV.Grid(2, 1)) Or
            (GlobalV.Grid(0, 2) And GlobalV.Grid(1, 2) And GlobalV.Grid(2, 2)) Or
            (GlobalV.Grid(0, 0) And GlobalV.Grid(0, 1) And GlobalV.Grid(0, 2)) Or
            (GlobalV.Grid(1, 0) And GlobalV.Grid(1, 1) And GlobalV.Grid(1, 2)) Or
            (GlobalV.Grid(2, 0) And GlobalV.Grid(2, 1) And GlobalV.Grid(2, 2)) Or
            (GlobalV.Grid(0, 0) And GlobalV.Grid(1, 1) And GlobalV.Grid(2, 2)) Or
            (GlobalV.Grid(2, 0) And GlobalV.Grid(1, 1) And GlobalV.Grid(0, 2))) = 1) Then
            TurnDisplay.Text = "Naught Wins"
            MsgBox("Naught Wins")
            TurnDisplay.Text = "Naught's Turn"
            GlobalV.Used1 = False
            GlobalV.Used2 = False
            GlobalV.Used3 = False
            GlobalV.Used4 = False
            GlobalV.Used5 = False
            GlobalV.Used6 = False
            GlobalV.Used7 = False
            GlobalV.Used8 = False
            GlobalV.Used9 = False
            GlobalV.PlayerTurn = 0
            For i = 0 To 2
                For j = 0 To 2
                    GlobalV.Grid(i, j) = Nothing
                Next
            Next
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing
        End If
        If (((GlobalV.Grid(0, 0) And GlobalV.Grid(1, 0) And GlobalV.Grid(2, 0)) Or
            (GlobalV.Grid(0, 1) And GlobalV.Grid(1, 1) And GlobalV.Grid(2, 1)) Or
            (GlobalV.Grid(0, 2) And GlobalV.Grid(1, 2) And GlobalV.Grid(2, 2)) Or
            (GlobalV.Grid(0, 0) And GlobalV.Grid(0, 1) And GlobalV.Grid(0, 2)) Or
            (GlobalV.Grid(1, 0) And GlobalV.Grid(1, 1) And GlobalV.Grid(1, 2)) Or
            (GlobalV.Grid(2, 0) And GlobalV.Grid(2, 1) And GlobalV.Grid(2, 2)) Or
            (GlobalV.Grid(0, 0) And GlobalV.Grid(1, 1) And GlobalV.Grid(2, 2)) Or
            (GlobalV.Grid(2, 0) And GlobalV.Grid(1, 1) And GlobalV.Grid(0, 2))) = 2) Then
            TurnDisplay.Text = "Cross Wins"
            MsgBox("Cross Wins")
            TurnDisplay.Text = "Naught's Turn"
            GlobalV.Used1 = False
            GlobalV.Used2 = False
            GlobalV.Used3 = False
            GlobalV.Used4 = False
            GlobalV.Used5 = False
            GlobalV.Used6 = False
            GlobalV.Used7 = False
            GlobalV.Used8 = False
            GlobalV.Used9 = False
            GlobalV.PlayerTurn = 0
            For i = 0 To 2
                For j = 0 To 2
                    GlobalV.Grid(i, j) = Nothing
                Next
            Next
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing
        End If
        If (GlobalV.Used1 And
           GlobalV.Used2 And
           GlobalV.Used3 And
           GlobalV.Used4 And
           GlobalV.Used5 And
           GlobalV.Used6 And
           GlobalV.Used7 And
           GlobalV.Used8 And
           GlobalV.Used9) = True Then
            TurnDisplay.Text = "Draw"
            MsgBox("Draw")
            TurnDisplay.Text = "Naught's Turn"
            GlobalV.Used1 = False
            GlobalV.Used2 = False
            GlobalV.Used3 = False
            GlobalV.Used4 = False
            GlobalV.Used5 = False
            GlobalV.Used6 = False
            GlobalV.Used7 = False
            GlobalV.Used8 = False
            GlobalV.Used9 = False
            GlobalV.PlayerTurn = 0
            For i = 0 To 2
                For j = 0 To 2
                    GlobalV.Grid(i, j) = Nothing
                Next
            Next
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing

        End If
    End Sub
End Class
