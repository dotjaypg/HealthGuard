Namespace AccountTab
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class cf_AccReq
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
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Label1 = New Label()
            pnl_MainHeader = New Panel()
            btn_Reject = New Button()
            btn_Approve = New Button()
            btn_View = New Button()
            btn_Refresh = New Button()
            btn_patientAddNew = New Button()
            txt_Search = New TextBox()
            Label2 = New Label()
            Label6 = New Label()
            lbl_homeDateTime = New Label()
            dgv_AccTable = New DataGridView()
            pnl_AccountList = New Panel()
            pnl_MainHeader.SuspendLayout()
            CType(dgv_AccTable, ComponentModel.ISupportInitialize).BeginInit()
            pnl_AccountList.SuspendLayout()
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
            ' pnl_MainHeader
            ' 
            pnl_MainHeader.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            pnl_MainHeader.BorderStyle = BorderStyle.FixedSingle
            pnl_MainHeader.Controls.Add(btn_Reject)
            pnl_MainHeader.Controls.Add(btn_Approve)
            pnl_MainHeader.Controls.Add(btn_View)
            pnl_MainHeader.Controls.Add(btn_Refresh)
            pnl_MainHeader.Controls.Add(btn_patientAddNew)
            pnl_MainHeader.Controls.Add(txt_Search)
            pnl_MainHeader.Controls.Add(Label2)
            pnl_MainHeader.Controls.Add(Label6)
            pnl_MainHeader.Controls.Add(lbl_homeDateTime)
            pnl_MainHeader.Dock = DockStyle.Top
            pnl_MainHeader.Location = New Point(0, 0)
            pnl_MainHeader.Margin = New Padding(3, 2, 3, 2)
            pnl_MainHeader.Name = "pnl_MainHeader"
            pnl_MainHeader.Size = New Size(1232, 69)
            pnl_MainHeader.TabIndex = 4
            ' 
            ' btn_Reject
            ' 
            btn_Reject.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_Reject.BackColor = Color.FromArgb(CByte(255), CByte(137), CByte(140))
            btn_Reject.FlatAppearance.BorderColor = Color.White
            btn_Reject.FlatStyle = FlatStyle.Flat
            btn_Reject.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Reject.Location = New Point(1110, 16)
            btn_Reject.Name = "btn_Reject"
            btn_Reject.Size = New Size(101, 34)
            btn_Reject.TabIndex = 13
            btn_Reject.Text = "Decline"
            btn_Reject.UseVisualStyleBackColor = False
            ' 
            ' btn_Approve
            ' 
            btn_Approve.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_Approve.BackColor = Color.Silver
            btn_Approve.FlatAppearance.BorderColor = Color.White
            btn_Approve.FlatStyle = FlatStyle.Flat
            btn_Approve.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Approve.Location = New Point(995, 16)
            btn_Approve.Name = "btn_Approve"
            btn_Approve.Size = New Size(101, 34)
            btn_Approve.TabIndex = 14
            btn_Approve.Text = "Accept"
            btn_Approve.UseVisualStyleBackColor = False
            ' 
            ' btn_View
            ' 
            btn_View.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_View.BackColor = Color.Silver
            btn_View.FlatAppearance.BorderColor = Color.White
            btn_View.FlatStyle = FlatStyle.Flat
            btn_View.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_View.Location = New Point(880, 16)
            btn_View.Name = "btn_View"
            btn_View.Size = New Size(101, 34)
            btn_View.TabIndex = 8
            btn_View.Text = "View"
            btn_View.UseVisualStyleBackColor = False
            ' 
            ' btn_Refresh
            ' 
            btn_Refresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_Refresh.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
            btn_Refresh.BackgroundImage = My.Resources.Resources.icon_refresh
            btn_Refresh.BackgroundImageLayout = ImageLayout.Zoom
            btn_Refresh.FlatAppearance.BorderColor = Color.White
            btn_Refresh.FlatStyle = FlatStyle.Flat
            btn_Refresh.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            btn_Refresh.Location = New Point(830, 16)
            btn_Refresh.Name = "btn_Refresh"
            btn_Refresh.Size = New Size(34, 34)
            btn_Refresh.TabIndex = 7
            btn_Refresh.UseVisualStyleBackColor = False
            ' 
            ' btn_patientAddNew
            ' 
            btn_patientAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btn_patientAddNew.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            btn_patientAddNew.Location = New Point(2110, 17)
            btn_patientAddNew.Name = "btn_patientAddNew"
            btn_patientAddNew.Size = New Size(135, 34)
            btn_patientAddNew.TabIndex = 4
            btn_patientAddNew.Text = "Add new patient"
            btn_patientAddNew.UseVisualStyleBackColor = True
            ' 
            ' txt_Search
            ' 
            txt_Search.Anchor = AnchorStyles.Top
            txt_Search.BorderStyle = BorderStyle.None
            txt_Search.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            txt_Search.Location = New Point(247, 16)
            txt_Search.Margin = New Padding(3, 2, 3, 2)
            txt_Search.Name = "txt_Search"
            txt_Search.PlaceholderText = "Search for an account"
            txt_Search.Size = New Size(493, 29)
            txt_Search.TabIndex = 4
            ' 
            ' Label2
            ' 
            Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Label2.AutoSize = True
            Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label2.ForeColor = Color.White
            Label2.Location = New Point(3159, 14)
            Label2.Name = "Label2"
            Label2.Size = New Size(108, 44)
            Label2.TabIndex = 3
            Label2.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            Label6.ForeColor = Color.White
            Label6.Location = New Point(12, 21)
            Label6.Name = "Label6"
            Label6.Size = New Size(179, 22)
            Label6.TabIndex = 1
            Label6.Text = "Pending Accounts"
            ' 
            ' lbl_homeDateTime
            ' 
            lbl_homeDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            lbl_homeDateTime.AutoSize = True
            lbl_homeDateTime.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
            lbl_homeDateTime.ForeColor = Color.White
            lbl_homeDateTime.Location = New Point(4208, 14)
            lbl_homeDateTime.Name = "lbl_homeDateTime"
            lbl_homeDateTime.Size = New Size(108, 44)
            lbl_homeDateTime.TabIndex = 1
            lbl_homeDateTime.Text = "MM/DD/YY" & vbCrLf & "00:00 AM"
            ' 
            ' dgv_AccTable
            ' 
            dgv_AccTable.AllowUserToAddRows = False
            dgv_AccTable.AllowUserToDeleteRows = False
            DataGridViewCellStyle9.BackColor = Color.WhiteSmoke
            dgv_AccTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
            dgv_AccTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_AccTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv_AccTable.BackgroundColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            dgv_AccTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = Color.DimGray
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
            dgv_AccTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
            dgv_AccTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = SystemColors.Window
            DataGridViewCellStyle11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
            DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle11.Padding = New Padding(5)
            DataGridViewCellStyle11.SelectionBackColor = Color.Silver
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
            dgv_AccTable.DefaultCellStyle = DataGridViewCellStyle11
            dgv_AccTable.Dock = DockStyle.Fill
            dgv_AccTable.EditMode = DataGridViewEditMode.EditProgrammatically
            dgv_AccTable.EnableHeadersVisualStyles = False
            dgv_AccTable.Location = New Point(20, 20)
            dgv_AccTable.Name = "dgv_AccTable"
            dgv_AccTable.ReadOnly = True
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(19), CByte(193), CByte(142))
            DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = Color.Transparent
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
            dgv_AccTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            dgv_AccTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            dgv_AccTable.RowTemplate.ReadOnly = True
            dgv_AccTable.Size = New Size(1192, 690)
            dgv_AccTable.TabIndex = 4
            ' 
            ' pnl_AccountList
            ' 
            pnl_AccountList.Controls.Add(dgv_AccTable)
            pnl_AccountList.Dock = DockStyle.Fill
            pnl_AccountList.Location = New Point(0, 69)
            pnl_AccountList.Name = "pnl_AccountList"
            pnl_AccountList.Padding = New Padding(20)
            pnl_AccountList.Size = New Size(1232, 730)
            pnl_AccountList.TabIndex = 6
            ' 
            ' cf_AccReq
            ' 
            AutoScaleDimensions = New SizeF(7F, 15F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(219), CByte(252), CByte(224))
            ClientSize = New Size(1232, 799)
            Controls.Add(pnl_AccountList)
            Controls.Add(pnl_MainHeader)
            Controls.Add(Label1)
            Name = "cf_AccReq"
            Text = "cf_AccList"
            pnl_MainHeader.ResumeLayout(False)
            pnl_MainHeader.PerformLayout()
            CType(dgv_AccTable, ComponentModel.ISupportInitialize).EndInit()
            pnl_AccountList.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents pnl_MainHeader As Panel
        Friend WithEvents btn_patientAddNew As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents lbl_homeDateTime As Label
        Friend WithEvents txt_Search As TextBox
        Friend WithEvents dgv_AccTable As DataGridView
        Friend WithEvents pnl_AccountList As Panel
        Friend WithEvents btn_Refresh As Button
        Friend WithEvents btn_View As Button
        Friend WithEvents btn_Delete As Button
        Friend WithEvents btn_Reject As Button
        Friend WithEvents btn_Approve As Button
    End Class
End Namespace