<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeParent))
        pnl_NavBar = New Panel()
        btn_Logout = New Button()
        btn_Schedules = New Button()
        btn_Accounts = New Button()
        btn_Patients = New Button()
        btn_Home = New Button()
        pnl_NavHeader = New Panel()
        pb_Logo = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        pnl_MainHeader = New Panel()
        txt_homeSearch = New TextBox()
        lbl_homeDateTime = New Label()
        pnl_MainPage = New Panel()
        Panel4 = New Panel()
        Panel6 = New Panel()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        pnl_NavBar.SuspendLayout()
        pnl_NavHeader.SuspendLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_MainHeader.SuspendLayout()
        pnl_MainPage.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_NavBar
        ' 
        pnl_NavBar.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        pnl_NavBar.BorderStyle = BorderStyle.FixedSingle
        pnl_NavBar.Controls.Add(btn_Logout)
        pnl_NavBar.Controls.Add(btn_Schedules)
        pnl_NavBar.Controls.Add(btn_Accounts)
        pnl_NavBar.Controls.Add(btn_Patients)
        pnl_NavBar.Controls.Add(btn_Home)
        pnl_NavBar.Controls.Add(pnl_NavHeader)
        pnl_NavBar.Dock = DockStyle.Left
        pnl_NavBar.Location = New Point(0, 0)
        pnl_NavBar.Margin = New Padding(3, 2, 3, 2)
        pnl_NavBar.Name = "pnl_NavBar"
        pnl_NavBar.Size = New Size(336, 861)
        pnl_NavBar.TabIndex = 0
        ' 
        ' btn_Logout
        ' 
        btn_Logout.Dock = DockStyle.Bottom
        btn_Logout.FlatStyle = FlatStyle.Flat
        btn_Logout.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Logout.Image = My.Resources.Resources.icon_logout
        btn_Logout.ImageAlign = ContentAlignment.MiddleLeft
        btn_Logout.Location = New Point(0, 809)
        btn_Logout.Margin = New Padding(3, 2, 3, 2)
        btn_Logout.Name = "btn_Logout"
        btn_Logout.Padding = New Padding(13, 0, 0, 0)
        btn_Logout.Size = New Size(334, 50)
        btn_Logout.TabIndex = 2
        btn_Logout.Text = "Logout"
        btn_Logout.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Logout.UseVisualStyleBackColor = True
        ' 
        ' btn_Schedules
        ' 
        btn_Schedules.FlatStyle = FlatStyle.Flat
        btn_Schedules.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Schedules.Image = My.Resources.Resources.icon_schedules
        btn_Schedules.ImageAlign = ContentAlignment.MiddleLeft
        btn_Schedules.Location = New Point(10, 345)
        btn_Schedules.Margin = New Padding(3, 2, 3, 2)
        btn_Schedules.Name = "btn_Schedules"
        btn_Schedules.Padding = New Padding(13, 0, 0, 0)
        btn_Schedules.Size = New Size(313, 50)
        btn_Schedules.TabIndex = 2
        btn_Schedules.Text = "Schedules"
        btn_Schedules.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Schedules.UseVisualStyleBackColor = True
        ' 
        ' btn_Accounts
        ' 
        btn_Accounts.FlatStyle = FlatStyle.Flat
        btn_Accounts.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Accounts.Image = My.Resources.Resources.icon_accounts
        btn_Accounts.ImageAlign = ContentAlignment.MiddleLeft
        btn_Accounts.Location = New Point(10, 290)
        btn_Accounts.Margin = New Padding(3, 2, 3, 2)
        btn_Accounts.Name = "btn_Accounts"
        btn_Accounts.Padding = New Padding(13, 0, 0, 0)
        btn_Accounts.Size = New Size(313, 50)
        btn_Accounts.TabIndex = 2
        btn_Accounts.Text = "Accounts"
        btn_Accounts.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Accounts.UseVisualStyleBackColor = True
        ' 
        ' btn_Patients
        ' 
        btn_Patients.FlatStyle = FlatStyle.Flat
        btn_Patients.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Patients.Image = My.Resources.Resources.icon_patientlist
        btn_Patients.ImageAlign = ContentAlignment.MiddleLeft
        btn_Patients.Location = New Point(10, 236)
        btn_Patients.Margin = New Padding(3, 2, 3, 2)
        btn_Patients.Name = "btn_Patients"
        btn_Patients.Padding = New Padding(13, 0, 0, 0)
        btn_Patients.Size = New Size(313, 50)
        btn_Patients.TabIndex = 2
        btn_Patients.Text = "Patients"
        btn_Patients.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Patients.UseVisualStyleBackColor = True
        ' 
        ' btn_Home
        ' 
        btn_Home.BackColor = Color.FromArgb(CByte(45), CByte(147), CByte(100))
        btn_Home.FlatStyle = FlatStyle.Flat
        btn_Home.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Home.Image = My.Resources.Resources.icon_home
        btn_Home.ImageAlign = ContentAlignment.MiddleLeft
        btn_Home.Location = New Point(10, 181)
        btn_Home.Margin = New Padding(3, 2, 3, 2)
        btn_Home.Name = "btn_Home"
        btn_Home.Padding = New Padding(13, 0, 0, 0)
        btn_Home.Size = New Size(313, 50)
        btn_Home.TabIndex = 2
        btn_Home.Text = "Home"
        btn_Home.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Home.UseVisualStyleBackColor = False
        ' 
        ' pnl_NavHeader
        ' 
        pnl_NavHeader.BackColor = Color.FromArgb(CByte(85), CByte(213), CByte(170))
        pnl_NavHeader.Controls.Add(pb_Logo)
        pnl_NavHeader.Controls.Add(Label2)
        pnl_NavHeader.Controls.Add(Label3)
        pnl_NavHeader.Controls.Add(Label4)
        pnl_NavHeader.Controls.Add(Label1)
        pnl_NavHeader.Dock = DockStyle.Top
        pnl_NavHeader.Location = New Point(0, 0)
        pnl_NavHeader.Margin = New Padding(3, 2, 3, 2)
        pnl_NavHeader.Name = "pnl_NavHeader"
        pnl_NavHeader.Size = New Size(334, 172)
        pnl_NavHeader.TabIndex = 0
        ' 
        ' pb_Logo
        ' 
        pb_Logo.BackColor = Color.Transparent
        pb_Logo.BackgroundImageLayout = ImageLayout.None
        pb_Logo.Image = CType(resources.GetObject("pb_Logo.Image"), Image)
        pb_Logo.Location = New Point(3, 38)
        pb_Logo.Margin = New Padding(3, 2, 3, 2)
        pb_Logo.Name = "pb_Logo"
        pb_Logo.Size = New Size(328, 88)
        pb_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pb_Logo.TabIndex = 1
        pb_Logo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Unicode MS", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(129, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 21)
        Label2.TabIndex = 1
        Label2.Text = "System Administrator"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(129, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 21)
        Label3.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(34, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 21)
        Label4.TabIndex = 1
        Label4.Text = "One-rad Medical and X-ray Clinic"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 21)
        Label1.TabIndex = 1
        Label1.Text = "Logged in as:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(13, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(285, 44)
        Label6.TabIndex = 1
        Label6.Text = "Welcome, Here’s an overview " & vbCrLf & "of your tasks for today."
        ' 
        ' pnl_MainHeader
        ' 
        pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        pnl_MainHeader.Controls.Add(Label6)
        pnl_MainHeader.Controls.Add(txt_homeSearch)
        pnl_MainHeader.Controls.Add(lbl_homeDateTime)
        pnl_MainHeader.Dock = DockStyle.Top
        pnl_MainHeader.Location = New Point(336, 0)
        pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
        pnl_MainHeader.Name = "pnl_MainHeader"
        pnl_MainHeader.Size = New Size(1248, 69)
        pnl_MainHeader.TabIndex = 1
        ' 
        ' txt_homeSearch
        ' 
        txt_homeSearch.Anchor = AnchorStyles.Top
        txt_homeSearch.BorderStyle = BorderStyle.None
        txt_homeSearch.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_homeSearch.Location = New Point(477, 21)
        txt_homeSearch.Margin = New Padding(3, 2, 3, 2)
        txt_homeSearch.Name = "txt_homeSearch"
        txt_homeSearch.PlaceholderText = "Search for a patient"
        txt_homeSearch.Size = New Size(493, 29)
        txt_homeSearch.TabIndex = 2
        ' 
        ' lbl_homeDateTime
        ' 
        lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_homeDateTime.AutoSize = True
        lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_homeDateTime.ForeColor = Color.White
        lbl_homeDateTime.Location = New Point(1114, 14)
        lbl_homeDateTime.Name = "lbl_homeDateTime"
        lbl_homeDateTime.Size = New Size(108, 44)
        lbl_homeDateTime.TabIndex = 1
        lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
        ' 
        ' pnl_MainPage
        ' 
        pnl_MainPage.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
        pnl_MainPage.Controls.Add(Panel4)
        pnl_MainPage.Controls.Add(Panel2)
        pnl_MainPage.Controls.Add(Panel1)
        pnl_MainPage.Dock = DockStyle.Fill
        pnl_MainPage.Location = New Point(336, 69)
        pnl_MainPage.Margin = New Padding(3, 2, 3, 2)
        pnl_MainPage.Name = "pnl_MainPage"
        pnl_MainPage.Size = New Size(1248, 792)
        pnl_MainPage.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Panel6)
        Panel4.Location = New Point(648, 404)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(588, 371)
        Panel4.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(586, 78)
        Panel6.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel5)
        Panel2.Location = New Point(647, 13)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(589, 373)
        Panel2.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(587, 78)
        Panel5.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(13, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(622, 762)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(620, 78)
        Panel3.TabIndex = 0
        ' 
        ' HomeParent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1584, 861)
        Controls.Add(pnl_MainPage)
        Controls.Add(pnl_MainHeader)
        Controls.Add(pnl_NavBar)
        Margin = New Padding(3, 2, 3, 2)
        Name = "HomeParent"
        StartPosition = FormStartPosition.CenterScreen
        Text = " HealthGuard Management"
        pnl_NavBar.ResumeLayout(False)
        pnl_NavHeader.ResumeLayout(False)
        pnl_NavHeader.PerformLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).EndInit()
        pnl_MainHeader.ResumeLayout(False)
        pnl_MainHeader.PerformLayout()
        pnl_MainPage.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_NavBar As Panel
    Friend WithEvents pnl_NavHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pb_Logo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnl_MainHeader As Panel
    Friend WithEvents txt_homeSearch As TextBox
    Friend WithEvents lbl_homeDateTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Home As Button
    Friend WithEvents btn_Schedules As Button
    Friend WithEvents btn_Accounts As Button
    Friend WithEvents btn_Patients As Button
    Friend WithEvents pnl_MainPage As Panel
    Friend WithEvents btn_Logout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel

End Class
