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
        btn_ApmntList = New Button()
        btn_AccList = New Button()
        btn_ApmntReq = New Button()
        btn_ApmntDay = New Button()
        btn_ApmntWeek = New Button()
        btn_AccReq = New Button()
        btn_OutList = New Button()
        btn_AdmitList = New Button()
        btn_PatientList = New Button()
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
        pnl_NavHeader.SuspendLayout()
        CType(pb_Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_NavBar
        ' 
        pnl_NavBar.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        pnl_NavBar.BorderStyle = BorderStyle.FixedSingle
        pnl_NavBar.Controls.Add(btn_ApmntList)
        pnl_NavBar.Controls.Add(btn_AccList)
        pnl_NavBar.Controls.Add(btn_ApmntReq)
        pnl_NavBar.Controls.Add(btn_ApmntDay)
        pnl_NavBar.Controls.Add(btn_ApmntWeek)
        pnl_NavBar.Controls.Add(btn_AccReq)
        pnl_NavBar.Controls.Add(btn_OutList)
        pnl_NavBar.Controls.Add(btn_AdmitList)
        pnl_NavBar.Controls.Add(btn_PatientList)
        pnl_NavBar.Controls.Add(btn_Home)
        pnl_NavBar.Controls.Add(btn_Logout)
        pnl_NavBar.Controls.Add(pnl_NavHeader)
        pnl_NavBar.Dock = DockStyle.Left
        pnl_NavBar.Location = New Point(0, 0)
        pnl_NavBar.Name = "pnl_NavBar"
        pnl_NavBar.Size = New Size(384, 1055)
        pnl_NavBar.TabIndex = 0
        ' 
        ' btn_ApmntList
        ' 
        btn_ApmntList.Anchor = AnchorStyles.Top
        btn_ApmntList.FlatStyle = FlatStyle.Flat
        btn_ApmntList.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ApmntList.Image = My.Resources.Resources.icon_schedules
        btn_ApmntList.ImageAlign = ContentAlignment.MiddleLeft
        btn_ApmntList.Location = New Point(11, 573)
        btn_ApmntList.Name = "btn_ApmntList"
        btn_ApmntList.Padding = New Padding(15, 0, 0, 0)
        btn_ApmntList.Size = New Size(352, 67)
        btn_ApmntList.TabIndex = 2
        btn_ApmntList.Text = "Schedules"
        btn_ApmntList.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_ApmntList.UseVisualStyleBackColor = True
        ' 
        ' btn_AccList
        ' 
        btn_AccList.Anchor = AnchorStyles.Top
        btn_AccList.FlatStyle = FlatStyle.Flat
        btn_AccList.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_AccList.Image = My.Resources.Resources.icon_accounts
        btn_AccList.ImageAlign = ContentAlignment.MiddleLeft
        btn_AccList.Location = New Point(11, 461)
        btn_AccList.Name = "btn_AccList"
        btn_AccList.Padding = New Padding(15, 0, 0, 0)
        btn_AccList.Size = New Size(352, 67)
        btn_AccList.TabIndex = 2
        btn_AccList.Text = "Accounts"
        btn_AccList.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_AccList.UseVisualStyleBackColor = True
        ' 
        ' btn_ApmntReq
        ' 
        btn_ApmntReq.Anchor = AnchorStyles.Top
        btn_ApmntReq.FlatStyle = FlatStyle.Flat
        btn_ApmntReq.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ApmntReq.Location = New Point(11, 724)
        btn_ApmntReq.Name = "btn_ApmntReq"
        btn_ApmntReq.Padding = New Padding(75, 0, 0, 0)
        btn_ApmntReq.Size = New Size(352, 33)
        btn_ApmntReq.TabIndex = 2
        btn_ApmntReq.Text = "Appointment Requests"
        btn_ApmntReq.TextAlign = ContentAlignment.MiddleLeft
        btn_ApmntReq.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_ApmntReq.UseVisualStyleBackColor = True
        ' 
        ' btn_ApmntDay
        ' 
        btn_ApmntDay.Anchor = AnchorStyles.Top
        btn_ApmntDay.FlatStyle = FlatStyle.Flat
        btn_ApmntDay.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ApmntDay.Location = New Point(11, 685)
        btn_ApmntDay.Name = "btn_ApmntDay"
        btn_ApmntDay.Padding = New Padding(75, 0, 0, 0)
        btn_ApmntDay.Size = New Size(352, 33)
        btn_ApmntDay.TabIndex = 2
        btn_ApmntDay.Text = "Today's Appointments"
        btn_ApmntDay.TextAlign = ContentAlignment.MiddleLeft
        btn_ApmntDay.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_ApmntDay.UseVisualStyleBackColor = True
        ' 
        ' btn_ApmntWeek
        ' 
        btn_ApmntWeek.Anchor = AnchorStyles.Top
        btn_ApmntWeek.FlatStyle = FlatStyle.Flat
        btn_ApmntWeek.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_ApmntWeek.Location = New Point(11, 646)
        btn_ApmntWeek.Name = "btn_ApmntWeek"
        btn_ApmntWeek.Padding = New Padding(75, 0, 0, 0)
        btn_ApmntWeek.Size = New Size(352, 33)
        btn_ApmntWeek.TabIndex = 2
        btn_ApmntWeek.Text = "Appointments This Week"
        btn_ApmntWeek.TextAlign = ContentAlignment.MiddleLeft
        btn_ApmntWeek.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_ApmntWeek.UseVisualStyleBackColor = True
        ' 
        ' btn_AccReq
        ' 
        btn_AccReq.Anchor = AnchorStyles.Top
        btn_AccReq.FlatStyle = FlatStyle.Flat
        btn_AccReq.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_AccReq.Location = New Point(11, 534)
        btn_AccReq.Name = "btn_AccReq"
        btn_AccReq.Padding = New Padding(75, 0, 0, 0)
        btn_AccReq.Size = New Size(352, 33)
        btn_AccReq.TabIndex = 2
        btn_AccReq.Text = "Account Requests"
        btn_AccReq.TextAlign = ContentAlignment.MiddleLeft
        btn_AccReq.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_AccReq.UseVisualStyleBackColor = True
        ' 
        ' btn_OutList
        ' 
        btn_OutList.Anchor = AnchorStyles.Top
        btn_OutList.FlatStyle = FlatStyle.Flat
        btn_OutList.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_OutList.Location = New Point(11, 422)
        btn_OutList.Name = "btn_OutList"
        btn_OutList.Padding = New Padding(75, 0, 0, 0)
        btn_OutList.Size = New Size(352, 33)
        btn_OutList.TabIndex = 2
        btn_OutList.Text = "Outpatients"
        btn_OutList.TextAlign = ContentAlignment.MiddleLeft
        btn_OutList.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_OutList.UseVisualStyleBackColor = True
        ' 
        ' btn_AdmitList
        ' 
        btn_AdmitList.Anchor = AnchorStyles.Top
        btn_AdmitList.FlatStyle = FlatStyle.Flat
        btn_AdmitList.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_AdmitList.Location = New Point(11, 383)
        btn_AdmitList.Name = "btn_AdmitList"
        btn_AdmitList.Padding = New Padding(75, 0, 0, 0)
        btn_AdmitList.Size = New Size(352, 33)
        btn_AdmitList.TabIndex = 2
        btn_AdmitList.Text = "Admitted Patients"
        btn_AdmitList.TextAlign = ContentAlignment.MiddleLeft
        btn_AdmitList.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_AdmitList.UseVisualStyleBackColor = True
        ' 
        ' btn_PatientList
        ' 
        btn_PatientList.Anchor = AnchorStyles.Top
        btn_PatientList.FlatStyle = FlatStyle.Flat
        btn_PatientList.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_PatientList.Image = My.Resources.Resources.icon_patientlist
        btn_PatientList.ImageAlign = ContentAlignment.MiddleLeft
        btn_PatientList.Location = New Point(11, 310)
        btn_PatientList.Name = "btn_PatientList"
        btn_PatientList.Padding = New Padding(15, 0, 0, 0)
        btn_PatientList.Size = New Size(352, 67)
        btn_PatientList.TabIndex = 2
        btn_PatientList.Text = "Patients"
        btn_PatientList.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_PatientList.UseVisualStyleBackColor = True
        ' 
        ' btn_Home
        ' 
        btn_Home.Anchor = AnchorStyles.Top
        btn_Home.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
        btn_Home.FlatStyle = FlatStyle.Flat
        btn_Home.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_Home.Image = My.Resources.Resources.icon_home
        btn_Home.ImageAlign = ContentAlignment.MiddleLeft
        btn_Home.Location = New Point(11, 237)
        btn_Home.Name = "btn_Home"
        btn_Home.Padding = New Padding(15, 0, 0, 0)
        btn_Home.Size = New Size(352, 67)
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
        btn_Logout.Location = New Point(0, 986)
        btn_Logout.Name = "btn_Logout"
        btn_Logout.Padding = New Padding(15, 0, 0, 0)
        btn_Logout.Size = New Size(382, 67)
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
        pnl_NavHeader.Name = "pnl_NavHeader"
        pnl_NavHeader.Size = New Size(382, 229)
        pnl_NavHeader.TabIndex = 0
        ' 
        ' pb_Logo
        ' 
        pb_Logo.BackColor = Color.Transparent
        pb_Logo.BackgroundImageLayout = ImageLayout.None
        pb_Logo.Image = CType(resources.GetObject("pb_Logo.Image"), Image)
        pb_Logo.Location = New Point(3, 51)
        pb_Logo.Name = "pb_Logo"
        pb_Logo.Size = New Size(375, 117)
        pb_Logo.SizeMode = PictureBoxSizeMode.Zoom
        pb_Logo.TabIndex = 1
        pb_Logo.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Unicode MS", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(147, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 26)
        Label2.TabIndex = 1
        Label2.Text = "System Administrator"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(147, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 26)
        Label3.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(306, 26)
        Label4.TabIndex = 1
        Label4.Text = "One-rad Medical and X-ray Clinic"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Unicode MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 26)
        Label1.TabIndex = 1
        Label1.Text = "Logged in as:"
        ' 
        ' pnl_MainPage
        ' 
        pnl_MainPage.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
        pnl_MainPage.Dock = DockStyle.Fill
        pnl_MainPage.Location = New Point(384, 0)
        pnl_MainPage.Name = "pnl_MainPage"
        pnl_MainPage.Size = New Size(1426, 1055)
        pnl_MainPage.TabIndex = 2
        ' 
        ' AdminParent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1810, 1055)
        Controls.Add(pnl_MainPage)
        Controls.Add(pnl_NavBar)
        Name = "AdminParent"
        StartPosition = FormStartPosition.CenterScreen
        Text = " HealthGuard Management"
        pnl_NavBar.ResumeLayout(False)
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
    Friend WithEvents pnl_MainPage As Panel
    Friend WithEvents btn_Logout As Button
    Friend WithEvents btn_ApmntList As Button
    Friend WithEvents btn_AccList As Button
    Friend WithEvents btn_AdmitList As Button
    Friend WithEvents btn_PatientList As Button
    Friend WithEvents btn_Home As Button
    Friend WithEvents btn_OutList As Button
    Friend WithEvents btn_AccReq As Button
    Friend WithEvents btn_ApmntReq As Button
    Friend WithEvents btn_ApmntDay As Button
    Friend WithEvents btn_ApmntWeek As Button

End Class
