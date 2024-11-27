<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        pnl_LoginPanel = New TableLayoutPanel()
        Panel2 = New Panel()
        tlp_LoginContainer = New TableLayoutPanel()
        Label3 = New Label()
        Panel1 = New Panel()
        txt_Password = New TextBox()
        Panel3 = New Panel()
        txt_UserCred = New TextBox()
        btn_LoginButton = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        pnl_LoginPanel.SuspendLayout()
        Panel2.SuspendLayout()
        tlp_LoginContainer.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_LoginPanel
        ' 
        pnl_LoginPanel.BackColor = Color.White
        pnl_LoginPanel.BackgroundImage = My.Resources.Resources.CMS
        pnl_LoginPanel.ColumnCount = 3
        pnl_LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.9999962F))
        pnl_LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 621F))
        pnl_LoginPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0000076F))
        pnl_LoginPanel.Controls.Add(Panel2, 1, 1)
        pnl_LoginPanel.Controls.Add(Label1, 1, 2)
        pnl_LoginPanel.Dock = DockStyle.Fill
        pnl_LoginPanel.Location = New Point(0, 0)
        pnl_LoginPanel.Name = "pnl_LoginPanel"
        pnl_LoginPanel.RowCount = 3
        pnl_LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 49.9999962F))
        pnl_LoginPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 550F))
        pnl_LoginPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0000076F))
        pnl_LoginPanel.Size = New Size(1584, 761)
        pnl_LoginPanel.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(124), CByte(208), CByte(137))
        Panel2.Controls.Add(tlp_LoginContainer)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(484, 108)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(615, 544)
        Panel2.TabIndex = 0
        ' 
        ' tlp_LoginContainer
        ' 
        tlp_LoginContainer.ColumnCount = 3
        tlp_LoginContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.9999962F))
        tlp_LoginContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 410F))
        tlp_LoginContainer.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0000076F))
        tlp_LoginContainer.Controls.Add(Label3, 1, 0)
        tlp_LoginContainer.Controls.Add(Panel1, 1, 2)
        tlp_LoginContainer.Controls.Add(Panel3, 1, 1)
        tlp_LoginContainer.Controls.Add(btn_LoginButton, 1, 3)
        tlp_LoginContainer.Dock = DockStyle.Fill
        tlp_LoginContainer.Location = New Point(0, 169)
        tlp_LoginContainer.Name = "tlp_LoginContainer"
        tlp_LoginContainer.Padding = New Padding(40)
        tlp_LoginContainer.RowCount = 4
        tlp_LoginContainer.RowStyles.Add(New RowStyle())
        tlp_LoginContainer.RowStyles.Add(New RowStyle())
        tlp_LoginContainer.RowStyles.Add(New RowStyle())
        tlp_LoginContainer.RowStyles.Add(New RowStyle())
        tlp_LoginContainer.Size = New Size(615, 375)
        tlp_LoginContainer.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(1), CByte(123), CByte(146))
        Label3.Location = New Point(206, 40)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5)
        Label3.Size = New Size(201, 40)
        Label3.TabIndex = 0
        Label3.Text = "LOGIN AS ADMIN"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txt_Password)
        Panel1.Location = New Point(105, 140)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(404, 51)
        Panel1.TabIndex = 1
        ' 
        ' txt_Password
        ' 
        txt_Password.Anchor = AnchorStyles.Left
        txt_Password.BackColor = Color.White
        txt_Password.BorderStyle = BorderStyle.None
        txt_Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_Password.Location = New Point(5, 5)
        txt_Password.Multiline = True
        txt_Password.Name = "txt_Password"
        txt_Password.PasswordChar = "*"c
        txt_Password.PlaceholderText = "Password"
        txt_Password.Size = New Size(394, 40)
        txt_Password.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(txt_UserCred)
        Panel3.Location = New Point(105, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(404, 51)
        Panel3.TabIndex = 2
        ' 
        ' txt_UserCred
        ' 
        txt_UserCred.Anchor = AnchorStyles.Left
        txt_UserCred.BackColor = Color.White
        txt_UserCred.BorderStyle = BorderStyle.None
        txt_UserCred.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_UserCred.Location = New Point(5, 5)
        txt_UserCred.Multiline = True
        txt_UserCred.Name = "txt_UserCred"
        txt_UserCred.PlaceholderText = "Phone Number, Username or Email"
        txt_UserCred.Size = New Size(394, 40)
        txt_UserCred.TabIndex = 1
        ' 
        ' btn_LoginButton
        ' 
        btn_LoginButton.Anchor = AnchorStyles.Top
        btn_LoginButton.BackColor = Color.FromArgb(CByte(1), CByte(123), CByte(146))
        btn_LoginButton.FlatAppearance.BorderSize = 0
        btn_LoginButton.FlatStyle = FlatStyle.Flat
        btn_LoginButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_LoginButton.ForeColor = Color.White
        btn_LoginButton.Location = New Point(181, 224)
        btn_LoginButton.Margin = New Padding(3, 30, 3, 3)
        btn_LoginButton.Name = "btn_LoginButton"
        btn_LoginButton.Size = New Size(252, 51)
        btn_LoginButton.TabIndex = 3
        btn_LoginButton.Text = "Log in"
        btn_LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(124), CByte(208), CByte(137))
        Label2.Location = New Point(294, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 25)
        Label2.TabIndex = 1
        Label2.Text = "MANAGEMENT"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = My.Resources.Resources.logo_flat
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(615, 169)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(124), CByte(208), CByte(137))
        Label1.Location = New Point(695, 655)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 20)
        Label1.TabIndex = 1
        Label1.Text = "ONE-RAD MEDICAL CLINIC"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1584, 761)
        Controls.Add(pnl_LoginPanel)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HealthGuard Admin Login"
        pnl_LoginPanel.ResumeLayout(False)
        pnl_LoginPanel.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        tlp_LoginContainer.ResumeLayout(False)
        tlp_LoginContainer.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnl_LoginPanel As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tlp_LoginContainer As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_UserCred As TextBox
    Friend WithEvents btn_LoginButton As Button
End Class
