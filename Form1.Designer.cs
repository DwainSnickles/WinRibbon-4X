namespace WinRibbon_4X
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon = new RibbonLib.Ribbon();
            this.ribbonHomeTab = new RibbonLib.RibbonTab();
            this.ribbonActionsPanel = new RibbonLib.RibbonPanel();
            this.ribbonRunButton = new RibbonLib.RibbonButton();
            this.ribbonStopButton = new RibbonLib.RibbonButton();
            this.ribbonHelpTab = new RibbonLib.RibbonTab();
            this.ribbonHelpPanel = new RibbonLib.RibbonPanel();
            this.ribbonAboutButton = new RibbonLib.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon.ItemMargin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ribbon.ItemPadding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbsPadding = new System.Windows.Forms.Padding(8, 5, 8, 3);
            this.ribbon.PanelMargin = new System.Windows.Forms.Padding(3, 2, 3, 15);
            this.ribbon.PanelPadding = new System.Windows.Forms.Padding(3);
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(800, 131);
            this.ribbon.TabIndex = 0;
            this.ribbon.Tabs.Add(this.ribbonHomeTab);
            this.ribbon.Tabs.Add(this.ribbonHelpTab);
            this.ribbon.TabsPadding = new System.Windows.Forms.Padding(8, 5, 8, 3);
            this.ribbon.TabTextMargin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ribbon.Text = "ribbon";
            // 
            // ribbonHomeTab
            // 
            this.ribbonHomeTab.Name = "ribbonHomeTab";
            this.ribbonHomeTab.Panels.Add(this.ribbonActionsPanel);
            this.ribbonHomeTab.Text = "Home";
            // 
            // ribbonActionsPanel
            // 
            this.ribbonActionsPanel.ItemMargin = null;
            this.ribbonActionsPanel.ItemPadding = null;
            this.ribbonActionsPanel.Items.Add(this.ribbonRunButton);
            this.ribbonActionsPanel.Items.Add(this.ribbonStopButton);
            this.ribbonActionsPanel.Name = "ribbonActionsPanel";
            this.ribbonActionsPanel.PanelMargin = null;
            this.ribbonActionsPanel.Text = "Actions";
            // 
            // ribbonRunButton
            // 
            this.ribbonRunButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonRunButton.Image")));
            this.ribbonRunButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonRunButton.LargeImage")));
            this.ribbonRunButton.Name = "ribbonRunButton";
            this.ribbonRunButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonRunButton.SmallImage")));
            this.ribbonRunButton.Text = "Run";
            // 
            // ribbonStopButton
            // 
            this.ribbonStopButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbonStopButton.Image")));
            this.ribbonStopButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonStopButton.LargeImage")));
            this.ribbonStopButton.Name = "ribbonStopButton";
            this.ribbonStopButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonStopButton.SmallImage")));
            this.ribbonStopButton.Text = "Stop";
            // 
            // ribbonHelpTab
            // 
            this.ribbonHelpTab.Name = "ribbonHelpTab";
            this.ribbonHelpTab.Panels.Add(this.ribbonHelpPanel);
            this.ribbonHelpTab.Text = "Help";
            // 
            // ribbonHelpPanel
            // 
            this.ribbonHelpPanel.ItemMargin = null;
            this.ribbonHelpPanel.ItemPadding = null;
            this.ribbonHelpPanel.Items.Add(this.ribbonAboutButton);
            this.ribbonHelpPanel.Name = "ribbonHelpPanel";
            this.ribbonHelpPanel.PanelMargin = null;
            this.ribbonHelpPanel.Text = "Info";
            // 
            // ribbonAboutButton
            // 
            this.ribbonAboutButton.Name = "ribbonAboutButton";
            this.ribbonAboutButton.Text = "About";
            this.ribbonAboutButton.Click += new System.EventHandler(this.ribbonAboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RibbonLib.Ribbon ribbon;
        private RibbonLib.RibbonTab ribbonHomeTab;
        private RibbonLib.RibbonPanel ribbonActionsPanel;
        private RibbonLib.RibbonButton ribbonRunButton;
        private RibbonLib.RibbonButton ribbonStopButton;
        private RibbonLib.RibbonTab ribbonHelpTab;
        private RibbonLib.RibbonPanel ribbonHelpPanel;
        private RibbonLib.RibbonButton ribbonAboutButton;
    }
}
