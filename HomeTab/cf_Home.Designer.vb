Namespace HomeTab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_Home
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
            Label1 = New Label()
            txt_homeSearch = New TextBox()
            pnl_MainHeader = New Panel()
            lbl_DateTimeDisplay = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            Panel1 = New Panel()
            Panel3 = New Panel()
            lbl_UpAp = New Label()
            Panel2 = New Panel()
            Panel5 = New Panel()
            lbl_PenReq = New Label()
            Panel4 = New Panel()
            Panel6 = New Panel()
            Label4 = New Label()
            pnl_MainContent = New TableLayoutPanel()
            pnl_MainHeader.SuspendLayout()
            Panel1.SuspendLayout()
            Panel3.SuspendLayout()
            Panel2.SuspendLayout()
            Panel5.SuspendLayout()
            Panel4.SuspendLayout()
            Panel6.SuspendLayout()
            pnl_MainContent.SuspendLayout()
            SuspendLayout()
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            Label1.Location = New Point(156, 322)
            Label1.Name = "Label1"
            Label1.Size = New Size(0, 86)
            Label1.TabIndex = 0
            ' 
            ' txt_homeSearch
            ' 
            txt_homeSearch.Anchor = AnchorStyles.Top
            txt_homeSearch.BorderStyle = BorderStyle.None
            txt_homeSearch.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_homeSearch.Location = New Point(396, 20)
            txt_homeSearch.Margin = New Padding(3, 2, 3, 2)
            txt_homeSearch.Name = "txt_homeSearch"
            txt_homeSearch.PlaceholderText = "Search for a patient"
            txt_homeSearch.Size = New Size(493, 29)
            txt_homeSearch.TabIndex = 2
            ' 
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            pnl_MainHeader.BorderStyle = BorderStyle.FixedSingle
            pnl_MainHeader.Controls.Add(lbl_DateTimeDisplay)
            pnl_MainHeader.Controls.Add(Label6)
            pnl_MainHeader.Controls.Add(txt_homeSearch)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(1232, 60)
            pnl_MainHeader.TabIndex = 2
            ' 
            ' lbl_DateTimeDisplay
            ' 
            lbl_DateTimeDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_DateTimeDisplay.AutoSize = True
            lbl_DateTimeDisplay.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_DateTimeDisplay.ForeColor = Color.White
            lbl_DateTimeDisplay.Location = New Point(1115, 11)
            lbl_DateTimeDisplay.Name = "lbl_DateTimeDisplay"
            lbl_DateTimeDisplay.Size = New Size(86, 44)
            lbl_DateTimeDisplay.TabIndex = 3
            lbl_DateTimeDisplay.Text = "Loading" & vbCrLf & "."
            lbl_DateTimeDisplay.TextAlign = ContentAlignment.MiddleRight
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
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(2144, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' Panel1
            ' 
            Panel1.AutoSize = True
            Panel1.BackColor = Color.White
            Panel1.BorderStyle = BorderStyle.FixedSingle
            Panel1.Controls.Add(Panel3)
            Panel1.Dock = DockStyle.Fill
            Panel1.Location = New Point(10, 10)
            Panel1.Margin = New Padding(10)
            Panel1.Name = "Panel1"
            pnl_MainContent.SetRowSpan(Panel1, 2)
            Panel1.Size = New Size(596, 719)
            Panel1.TabIndex = 3
            ' 
            ' Panel3
            ' 
            Panel3.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            Panel3.BorderStyle = BorderStyle.FixedSingle
            Panel3.Controls.Add(lbl_UpAp)
            Panel3.Dock = DockStyle.Top
            Panel3.Location = New Point(0, 0)
            Panel3.Name = "Panel3"
            Panel3.Size = New Size(594, 67)
            Panel3.TabIndex = 0
            ' 
            ' lbl_UpAp
            ' 
            lbl_UpAp.Dock = DockStyle.Fill
            lbl_UpAp.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_UpAp.ForeColor = Color.White
            lbl_UpAp.Location = New Point(0, 0)
            lbl_UpAp.Name = "lbl_UpAp"
            lbl_UpAp.Size = New Size(592, 65)
            lbl_UpAp.TabIndex = 1
            lbl_UpAp.Text = "Upcoming Appointments"
            lbl_UpAp.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' Panel2
            ' 
            Panel2.AutoSize = True
            Panel2.BackColor = Color.White
            Panel2.BorderStyle = BorderStyle.FixedSingle
            Panel2.Controls.Add(Panel5)
            Panel2.Dock = DockStyle.Fill
            Panel2.Location = New Point(616, 10)
            Panel2.Margin = New Padding(0, 10, 10, 5)
            Panel2.Name = "Panel2"
            Panel2.Size = New Size(606, 354)
            Panel2.TabIndex = 3
            ' 
            ' Panel5
            ' 
            Panel5.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            Panel5.BorderStyle = BorderStyle.FixedSingle
            Panel5.Controls.Add(lbl_PenReq)
            Panel5.Dock = DockStyle.Top
            Panel5.Location = New Point(0, 0)
            Panel5.Name = "Panel5"
            Panel5.Size = New Size(604, 67)
            Panel5.TabIndex = 1
            ' 
            ' lbl_PenReq
            ' 
            lbl_PenReq.Dock = DockStyle.Fill
            lbl_PenReq.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_PenReq.ForeColor = Color.White
            lbl_PenReq.Location = New Point(0, 0)
            lbl_PenReq.Name = "lbl_PenReq"
            lbl_PenReq.Size = New Size(602, 65)
            lbl_PenReq.TabIndex = 1
            lbl_PenReq.Text = "Pending Requests"
            lbl_PenReq.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' Panel4
            ' 
            Panel4.AutoSize = True
            Panel4.BackColor = Color.White
            Panel4.BorderStyle = BorderStyle.FixedSingle
            Panel4.Controls.Add(Panel6)
            Panel4.Dock = DockStyle.Fill
            Panel4.Location = New Point(616, 374)
            Panel4.Margin = New Padding(0, 5, 10, 10)
            Panel4.Name = "Panel4"
            Panel4.Size = New Size(606, 355)
            Panel4.TabIndex = 3
            ' 
            ' Panel6
            ' 
            Panel6.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            Panel6.BorderStyle = BorderStyle.FixedSingle
            Panel6.Controls.Add(Label4)
            Panel6.Dock = DockStyle.Top
            Panel6.Location = New Point(0, 0)
            Panel6.Name = "Panel6"
            Panel6.Size = New Size(604, 67)
            Panel6.TabIndex = 1
            ' 
            ' Label4
            ' 
            Label4.Dock = DockStyle.Fill
            Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label4.ForeColor = Color.White
            Label4.Location = New Point(0, 0)
            Label4.Name = "Label4"
            Label4.Size = New Size(602, 65)
            Label4.TabIndex = 1
            Label4.Text = "Notifications"
            Label4.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' pnl_MainContent
            ' 
            pnl_MainContent.BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            pnl_MainContent.ColumnCount = 2
            pnl_MainContent.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            pnl_MainContent.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            pnl_MainContent.Controls.Add(Panel1, 0, 0)
            pnl_MainContent.Controls.Add(Panel4, 1, 1)
            pnl_MainContent.Controls.Add(Panel2, 1, 0)
            pnl_MainContent.Dock = DockStyle.Fill
            pnl_MainContent.Location = New Point(0, 60)
            pnl_MainContent.Name = "pnl_MainContent"
            pnl_MainContent.RowCount = 2
            pnl_MainContent.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            pnl_MainContent.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            pnl_MainContent.Size = New Size(1232, 739)
            pnl_MainContent.TabIndex = 4
            ' 
            ' cf_Home
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_MainContent)
            Controls.Add(pnl_MainHeader)
            Controls.Add(Label1)
            Name = "cf_Home"
            Text = "cf_Home"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            Panel1.ResumeLayout(False)
            Panel3.ResumeLayout(False)
            Panel2.ResumeLayout(False)
            Panel5.ResumeLayout(False)
            Panel4.ResumeLayout(False)
            Panel6.ResumeLayout(False)
            pnl_MainContent.ResumeLayout(False)
            pnl_MainContent.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents txt_homeSearch As TextBox
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents Label6 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents lbl_DateTimeDisplay As Label
        Friend WithEvents Panel1 As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Panel4 As Panel
        Friend WithEvents pnl_MainContent As TableLayoutPanel
        Friend WithEvents lbl_UpAp As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents Label4 As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents lbl_PenReq As Label
    End Class
End Namespace
