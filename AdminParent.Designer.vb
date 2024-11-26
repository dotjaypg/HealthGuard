<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminParent))
        pnl_NavBar = New Panel()
        tlp_NavTable = New TableLayoutPanel()
        btn_Schedule = New Button()
        btn_Account = New Button()
        btn_Patient = New Button()
        btn_Home = New Button()
        btn_Logout = New Button()
        pnl_NavHeader = New Panel()
        pb_Logo = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        pnl_MainPage = New Panel()
        pnl_NavBar.SuspendLayout()
        tlp_NavTable.SuspendLayout()
        pnl_NavHeader.SuspendLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_NavBar
        ' 
        pnl_NavBar.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        pnl_NavBar.BorderStyle = BorderStyle.FixedSingle
        pnl_NavBar.Controls.Add(tlp_NavTable)
        pnl_NavBar.Controls.Add(btn_Logout)
        pnl_NavBar.Controls.Add(pnl_NavHeader)
        pnl_NavBar.Dock = DockStyle.Left
        pnl_NavBar.Location = New Point(0, 0)
        pnl_NavBar.Margin = New Padding(3, 2, 3, 2)
        pnl_NavBar.Name = "pnl_NavBar"
        pnl_NavBar.Size = New Size(336, 861)
        pnl_NavBar.TabIndex = 0
        ' 
        ' tlp_NavTable
        ' 
        tlp_NavTable.AutoSize = True
        tlp_NavTable.ColumnCount = 1
        tlp_NavTable.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tlp_NavTable.Controls.Add(btn_Schedule, 0, 3)
        tlp_NavTable.Controls.Add(btn_Account, 0, 2)
        tlp_NavTable.Controls.Add(btn_Patient, 0, 1)
        tlp_NavTable.Controls.Add(btn_Home, 0, 0)
        tlp_NavTable.Dock = DockStyle.Fill
        tlp_NavTable.Location = New Point(0, 172)
        tlp_NavTable.Margin = New Padding(0)
        tlp_NavTable.Name = "tlp_NavTable"
        tlp_NavTable.Padding = New Padding(10)
        tlp_NavTable.RowCount = 4
        tlp_NavTable.RowStyles.Add(New RowStyle())
        tlp_NavTable.RowStyles.Add(New RowStyle())
        tlp_NavTable.RowStyles.Add(New RowStyle())
        tlp_NavTable.RowStyles.Add(New RowStyle())
        tlp_NavTable.Size = New Size(334, 637)
        tlp_NavTable.TabIndex = 0
        ' 
        ' btn_Schedule
        ' 
        btn_Schedule.Anchor = AnchorStyles.Top
        btn_Schedule.FlatStyle = FlatStyle.Flat
        btn_Schedule.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Schedule.Image = My.Resources.Resources.icon_schedules
        btn_Schedule.ImageAlign = ContentAlignment.MiddleLeft
        btn_Schedule.Location = New Point(13, 174)
        btn_Schedule.Margin = New Padding(3, 2, 3, 2)
        btn_Schedule.Name = "btn_Schedule"
        btn_Schedule.Padding = New Padding(13, 0, 0, 0)
        btn_Schedule.Size = New Size(308, 50)
        btn_Schedule.TabIndex = 2
        btn_Schedule.Text = "Schedules"
        btn_Schedule.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Schedule.UseVisualStyleBackColor = True
        ' 
        ' btn_Account
        ' 
        btn_Account.Anchor = AnchorStyles.Top
        btn_Account.FlatStyle = FlatStyle.Flat
        btn_Account.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Account.Image = My.Resources.Resources.icon_accounts
        btn_Account.ImageAlign = ContentAlignment.MiddleLeft
        btn_Account.Location = New Point(13, 120)
        btn_Account.Margin = New Padding(3, 2, 3, 2)
        btn_Account.Name = "btn_Account"
        btn_Account.Padding = New Padding(13, 0, 0, 0)
        btn_Account.Size = New Size(308, 50)
        btn_Account.TabIndex = 2
        btn_Account.Text = "Accounts"
        btn_Account.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Account.UseVisualStyleBackColor = True
        ' 
        ' btn_Patient
        ' 
        btn_Patient.Anchor = AnchorStyles.Top
        btn_Patient.FlatStyle = FlatStyle.Flat
        btn_Patient.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Patient.Image = My.Resources.Resources.icon_patientlist
        btn_Patient.ImageAlign = ContentAlignment.MiddleLeft
        btn_Patient.Location = New Point(13, 66)
        btn_Patient.Margin = New Padding(3, 2, 3, 2)
        btn_Patient.Name = "btn_Patient"
        btn_Patient.Padding = New Padding(13, 0, 0, 0)
        btn_Patient.Size = New Size(308, 50)
        btn_Patient.TabIndex = 2
        btn_Patient.Text = "Patients"
        btn_Patient.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Patient.UseVisualStyleBackColor = True
        ' 
        ' btn_Home
        ' 
        btn_Home.Anchor = AnchorStyles.Top
        btn_Home.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        btn_Home.FlatStyle = FlatStyle.Flat
        btn_Home.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Home.Image = My.Resources.Resources.icon_home
        btn_Home.ImageAlign = ContentAlignment.MiddleLeft
        btn_Home.Location = New Point(13, 12)
        btn_Home.Margin = New Padding(3, 2, 3, 2)
        btn_Home.Name = "btn_Home"
        btn_Home.Padding = New Padding(13, 0, 0, 0)
        btn_Home.Size = New Size(308, 50)
        btn_Home.TabIndex = 2
        btn_Home.Text = "Home"
        btn_Home.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Home.UseVisualStyleBackColor = False
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
        Label2.Font = New Font("Arial Unicode MS", 12.0F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
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
        Label3.Font = New Font("Arial Unicode MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(129, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 21)
        Label3.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Unicode MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Label1.Font = New Font("Arial Unicode MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 21)
        Label1.TabIndex = 1
        Label1.Text = "Logged in as:"
        ' 
        ' pnl_MainPage
        ' 
        pnl_MainPage.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
        pnl_MainPage.Dock = DockStyle.Fill
        pnl_MainPage.Location = New Point(336, 0)
        pnl_MainPage.Margin = New Padding(3, 2, 3, 2)
        pnl_MainPage.Name = "pnl_MainPage"
        pnl_MainPage.Size = New Size(1248, 861)
        pnl_MainPage.TabIndex = 2
        ' 
        ' AdminParent
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1584, 861)
        Controls.Add(pnl_MainPage)
        Controls.Add(pnl_NavBar)
        Margin = New Padding(3, 2, 3, 2)
        Name = "AdminParent"
        StartPosition = FormStartPosition.CenterScreen
        Text = " HealthGuard Management"
        pnl_NavBar.ResumeLayout(False)
        pnl_NavBar.PerformLayout()
        tlp_NavTable.ResumeLayout(False)
        pnl_NavHeader.ResumeLayout(False)
        pnl_NavHeader.PerformLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_NavBar As Panel
    Friend WithEvents pnl_NavHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pb_Logo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Home As Button
    Friend WithEvents btn_Schedule As Button
    Friend WithEvents btn_Account As Button
    Friend WithEvents btn_Patient As Button
    Friend WithEvents pnl_MainPage As Panel
    Friend WithEvents btn_Logout As Button
    Friend WithEvents tlp_NavTable As TableLayoutPanel

End Class
