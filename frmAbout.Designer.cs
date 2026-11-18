using System.Drawing;
using System.Windows.Forms;

namespace WinRibbon_4X
{
    partial class frmAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTagline = new Label();
            lblVersion = new Label();
            lblLibraryCaption = new Label();
            lblRibbon = new Label();
            lblSnapshotCaption = new Label();
            txtSnapshot = new TextBox();
            lblSupportCaption = new Label();
            lblSupport = new Label();
            btnKoFi = new Button();
            btnPayPal = new Button();
            lblKoFiUrl = new Label();
            lblPayPalUrl = new Label();
            lblLinkStatus = new Label();
            btnCopyDetails = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15F);
            lblTitle.ForeColor = Color.FromArgb(230, 232, 237);
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(96, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WinRibbon";
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.ForeColor = Color.FromArgb(148, 154, 165);
            lblTagline.Location = new Point(22, 50);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(316, 15);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "The ribbon control for Windows Forms, on .NET Framework 4.8.";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.ForeColor = Color.FromArgb(88, 156, 255);
            lblVersion.Location = new Point(22, 74);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(72, 15);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Version 1.0.0";
            // 
            // lblLibraryCaption
            // 
            lblLibraryCaption.AutoSize = true;
            lblLibraryCaption.Font = new Font("Segoe UI Semibold", 8.25F);
            lblLibraryCaption.ForeColor = Color.FromArgb(148, 154, 165);
            lblLibraryCaption.Location = new Point(22, 106);
            lblLibraryCaption.Name = "lblLibraryCaption";
            lblLibraryCaption.Size = new Size(88, 13);
            lblLibraryCaption.TabIndex = 3;
            lblLibraryCaption.Text = "RIBBON LIBRARY";
            // 
            // lblRibbon
            // 
            lblRibbon.AutoEllipsis = true;
            lblRibbon.ForeColor = Color.FromArgb(148, 154, 165);
            lblRibbon.Location = new Point(22, 124);
            lblRibbon.Name = "lblRibbon";
            lblRibbon.Size = new Size(480, 18);
            lblRibbon.TabIndex = 4;
            lblRibbon.Text = "Ribbon.dll 1.0.0.0";
            // 
            // lblSnapshotCaption
            // 
            lblSnapshotCaption.AutoSize = true;
            lblSnapshotCaption.Font = new Font("Segoe UI Semibold", 8.25F);
            lblSnapshotCaption.ForeColor = Color.FromArgb(148, 154, 165);
            lblSnapshotCaption.Location = new Point(22, 156);
            lblSnapshotCaption.Name = "lblSnapshotCaption";
            lblSnapshotCaption.Size = new Size(70, 13);
            lblSnapshotCaption.TabIndex = 5;
            lblSnapshotCaption.Text = "THIS BUILD";
            // 
            // txtSnapshot
            // 
            txtSnapshot.BackColor = Color.FromArgb(33, 35, 40);
            txtSnapshot.BorderStyle = BorderStyle.None;
            txtSnapshot.Font = new Font("Consolas", 8.25F);
            txtSnapshot.ForeColor = Color.FromArgb(148, 154, 165);
            txtSnapshot.Location = new Point(22, 174);
            txtSnapshot.Multiline = true;
            txtSnapshot.Name = "txtSnapshot";
            txtSnapshot.ReadOnly = true;
            txtSnapshot.ScrollBars = ScrollBars.Vertical;
            txtSnapshot.Size = new Size(480, 78);
            txtSnapshot.TabIndex = 6;
            txtSnapshot.WordWrap = true;
            // 
            // lblSupportCaption
            // 
            lblSupportCaption.AutoSize = true;
            lblSupportCaption.Font = new Font("Segoe UI Semibold", 8.25F);
            lblSupportCaption.ForeColor = Color.FromArgb(148, 154, 165);
            lblSupportCaption.Location = new Point(22, 270);
            lblSupportCaption.Name = "lblSupportCaption";
            lblSupportCaption.Size = new Size(116, 13);
            lblSupportCaption.TabIndex = 7;
            lblSupportCaption.Text = "SUPPORT THE PROJECT";
            // 
            // lblSupport
            // 
            lblSupport.AutoSize = true;
            lblSupport.ForeColor = Color.FromArgb(148, 154, 165);
            lblSupport.Location = new Point(22, 288);
            lblSupport.Name = "lblSupport";
            lblSupport.Size = new Size(322, 15);
            lblSupport.TabIndex = 8;
            lblSupport.Text = "If the ribbon saved you some time, a tip is welcome:";
            // 
            // btnKoFi
            // 
            btnKoFi.BackColor = Color.FromArgb(42, 44, 50);
            btnKoFi.FlatAppearance.BorderColor = Color.FromArgb(58, 61, 68);
            btnKoFi.FlatStyle = FlatStyle.Flat;
            btnKoFi.Font = new Font("Segoe UI Semibold", 9F);
            btnKoFi.ForeColor = Color.FromArgb(230, 232, 237);
            btnKoFi.Location = new Point(22, 312);
            btnKoFi.Name = "btnKoFi";
            btnKoFi.Size = new Size(214, 34);
            btnKoFi.TabIndex = 9;
            btnKoFi.Text = "Support on Ko-fi";
            btnKoFi.UseVisualStyleBackColor = false;
            btnKoFi.Click += btnKoFi_Click;
            // 
            // btnPayPal
            // 
            btnPayPal.BackColor = Color.FromArgb(42, 44, 50);
            btnPayPal.FlatAppearance.BorderColor = Color.FromArgb(58, 61, 68);
            btnPayPal.FlatStyle = FlatStyle.Flat;
            btnPayPal.Font = new Font("Segoe UI Semibold", 9F);
            btnPayPal.ForeColor = Color.FromArgb(230, 232, 237);
            btnPayPal.Location = new Point(246, 312);
            btnPayPal.Name = "btnPayPal";
            btnPayPal.Size = new Size(214, 34);
            btnPayPal.TabIndex = 10;
            btnPayPal.Text = "Tip with PayPal";
            btnPayPal.UseVisualStyleBackColor = false;
            btnPayPal.Click += btnPayPal_Click;
            // 
            // lblKoFiUrl
            // 
            lblKoFiUrl.AutoSize = true;
            lblKoFiUrl.Font = new Font("Segoe UI", 8.25F);
            lblKoFiUrl.ForeColor = Color.FromArgb(148, 154, 165);
            lblKoFiUrl.Location = new Point(24, 352);
            lblKoFiUrl.Name = "lblKoFiUrl";
            lblKoFiUrl.Size = new Size(166, 13);
            lblKoFiUrl.TabIndex = 11;
            lblKoFiUrl.Text = "https://ko-fi.com/dwainhsnickles";
            // 
            // lblPayPalUrl
            // 
            lblPayPalUrl.AutoSize = true;
            lblPayPalUrl.Font = new Font("Segoe UI", 8.25F);
            lblPayPalUrl.ForeColor = Color.FromArgb(148, 154, 165);
            lblPayPalUrl.Location = new Point(248, 352);
            lblPayPalUrl.Name = "lblPayPalUrl";
            lblPayPalUrl.Size = new Size(170, 13);
            lblPayPalUrl.TabIndex = 12;
            lblPayPalUrl.Text = "https://paypal.me/YTDPlatinum";
            // 
            // lblLinkStatus
            // 
            lblLinkStatus.AutoEllipsis = true;
            lblLinkStatus.ForeColor = Color.FromArgb(238, 181, 92);
            lblLinkStatus.Location = new Point(22, 376);
            lblLinkStatus.Name = "lblLinkStatus";
            lblLinkStatus.Size = new Size(480, 18);
            lblLinkStatus.TabIndex = 13;
            // 
            // btnCopyDetails
            // 
            btnCopyDetails.BackColor = Color.FromArgb(42, 44, 50);
            btnCopyDetails.FlatAppearance.BorderColor = Color.FromArgb(58, 61, 68);
            btnCopyDetails.FlatStyle = FlatStyle.Flat;
            btnCopyDetails.ForeColor = Color.FromArgb(230, 232, 237);
            btnCopyDetails.Location = new Point(22, 406);
            btnCopyDetails.Name = "btnCopyDetails";
            btnCopyDetails.Size = new Size(130, 34);
            btnCopyDetails.TabIndex = 14;
            btnCopyDetails.Text = "Copy details";
            btnCopyDetails.UseVisualStyleBackColor = false;
            btnCopyDetails.Click += btnCopyDetails_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(42, 44, 50);
            btnClose.DialogResult = DialogResult.OK;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(58, 61, 68);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.FromArgb(230, 232, 237);
            btnClose.Location = new Point(402, 406);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 34);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // frmAbout
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 29);
            CancelButton = btnClose;
            ClientSize = new Size(524, 452);
            Controls.Add(lblTitle);
            Controls.Add(lblTagline);
            Controls.Add(lblVersion);
            Controls.Add(lblLibraryCaption);
            Controls.Add(lblRibbon);
            Controls.Add(lblSnapshotCaption);
            Controls.Add(txtSnapshot);
            Controls.Add(lblSupportCaption);
            Controls.Add(lblSupport);
            Controls.Add(btnKoFi);
            Controls.Add(btnPayPal);
            Controls.Add(lblKoFiUrl);
            Controls.Add(lblPayPalUrl);
            Controls.Add(lblLinkStatus);
            Controls.Add(btnCopyDetails);
            Controls.Add(btnClose);
            ForeColor = Color.FromArgb(230, 232, 237);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About WinRibbon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTagline;
        private Label lblVersion;
        private Label lblLibraryCaption;
        private Label lblRibbon;
        private Label lblSnapshotCaption;
        private TextBox txtSnapshot;
        private Label lblSupportCaption;
        private Label lblSupport;
        private Button btnKoFi;
        private Button btnPayPal;
        private Label lblKoFiUrl;
        private Label lblPayPalUrl;
        private Label lblLinkStatus;
        private Button btnCopyDetails;
        private Button btnClose;
    }
}
