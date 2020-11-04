namespace JRemoval
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblBatteryPercent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPowerPlans = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.tilePlaceholder = new MetroFramework.Controls.MetroTile();
            this.tileSystemStatus = new MetroFramework.Controls.MetroTile();
            this.tileRemoveTelemetry = new MetroFramework.Controls.MetroTile();
            this.tileCleanupComputer = new MetroFramework.Controls.MetroTile();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.checkForUpdatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitJRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.divider1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblBatteryPercent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPowerPlans);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 643);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::JRemoval.Properties.Resources.Settings_Light;
            this.pictureBox2.Location = new System.Drawing.Point(7, 603);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureBox2, "Settings");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblBatteryPercent
            // 
            this.lblBatteryPercent.AutoSize = true;
            this.lblBatteryPercent.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblBatteryPercent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBatteryPercent.Location = new System.Drawing.Point(139, 494);
            this.lblBatteryPercent.Name = "lblBatteryPercent";
            this.lblBatteryPercent.Size = new System.Drawing.Size(53, 19);
            this.lblBatteryPercent.TabIndex = 6;
            this.lblBatteryPercent.Text = "%00%";
            this.lblBatteryPercent.Click += new System.EventHandler(this.lblBatteryPercent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Battery Percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Power Plans:";
            // 
            // btnPowerPlans
            // 
            this.btnPowerPlans.Location = new System.Drawing.Point(120, 546);
            this.btnPowerPlans.Name = "btnPowerPlans";
            this.btnPowerPlans.Size = new System.Drawing.Size(89, 23);
            this.btnPowerPlans.TabIndex = 2;
            this.btnPowerPlans.Text = "Go";
            this.btnPowerPlans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnPowerPlans, "Go to Power Configuration");
            this.btnPowerPlans.UseSelectable = true;
            this.btnPowerPlans.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Singed In: %username%";
            this.metroToolTip1.SetToolTip(this.label2, "\r\n");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Computer at a glance";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tilePlaceholder
            // 
            this.tilePlaceholder.ActiveControl = null;
            this.tilePlaceholder.Location = new System.Drawing.Point(595, 373);
            this.tilePlaceholder.Name = "tilePlaceholder";
            this.tilePlaceholder.Size = new System.Drawing.Size(234, 240);
            this.tilePlaceholder.Style = MetroFramework.MetroColorStyle.Silver;
            this.tilePlaceholder.TabIndex = 8;
            this.tilePlaceholder.Text = "Placeholder";
            this.tilePlaceholder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tilePlaceholder.TileImage = global::JRemoval.Properties.Resources.Placeholder_Image;
            this.tilePlaceholder.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePlaceholder.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tilePlaceholder.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.tilePlaceholder, "Placeholder");
            this.tilePlaceholder.UseSelectable = true;
            this.tilePlaceholder.UseTileImage = true;
            // 
            // tileSystemStatus
            // 
            this.tileSystemStatus.ActiveControl = null;
            this.tileSystemStatus.Location = new System.Drawing.Point(273, 373);
            this.tileSystemStatus.Name = "tileSystemStatus";
            this.tileSystemStatus.Size = new System.Drawing.Size(234, 240);
            this.tileSystemStatus.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileSystemStatus.TabIndex = 7;
            this.tileSystemStatus.Text = "System Status";
            this.tileSystemStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileSystemStatus.TileImage = global::JRemoval.Properties.Resources.System_Monitoring;
            this.tileSystemStatus.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSystemStatus.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSystemStatus.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.tileSystemStatus, "System Status");
            this.tileSystemStatus.UseSelectable = true;
            this.tileSystemStatus.UseTileImage = true;
            this.tileSystemStatus.Click += new System.EventHandler(this.tileSystemStatus_Click);
            // 
            // tileRemoveTelemetry
            // 
            this.tileRemoveTelemetry.ActiveControl = null;
            this.tileRemoveTelemetry.Location = new System.Drawing.Point(595, 29);
            this.tileRemoveTelemetry.Name = "tileRemoveTelemetry";
            this.tileRemoveTelemetry.Size = new System.Drawing.Size(234, 240);
            this.tileRemoveTelemetry.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileRemoveTelemetry.TabIndex = 6;
            this.tileRemoveTelemetry.Text = "Remove Telemetry [WIP]";
            this.tileRemoveTelemetry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileRemoveTelemetry.TileImage = global::JRemoval.Properties.Resources.Tracking;
            this.tileRemoveTelemetry.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileRemoveTelemetry.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileRemoveTelemetry.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.tileRemoveTelemetry, "Remove Telemetry");
            this.tileRemoveTelemetry.UseSelectable = true;
            this.tileRemoveTelemetry.UseTileImage = true;
            // 
            // tileCleanupComputer
            // 
            this.tileCleanupComputer.ActiveControl = null;
            this.tileCleanupComputer.Location = new System.Drawing.Point(273, 29);
            this.tileCleanupComputer.Name = "tileCleanupComputer";
            this.tileCleanupComputer.Size = new System.Drawing.Size(234, 240);
            this.tileCleanupComputer.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileCleanupComputer.TabIndex = 5;
            this.tileCleanupComputer.Text = "Cleanup Computer";
            this.tileCleanupComputer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileCleanupComputer.TileImage = global::JRemoval.Properties.Resources.Cleanup_Broom;
            this.tileCleanupComputer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCleanupComputer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCleanupComputer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroToolTip1.SetToolTip(this.tileCleanupComputer, "Cleanup Computer");
            this.tileCleanupComputer.UseSelectable = true;
            this.tileCleanupComputer.UseTileImage = true;
            this.tileCleanupComputer.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "JRemoval will still be running in the background.";
            this.notifyIcon1.BalloonTipTitle = "Running In Background";
            this.notifyIcon1.ContextMenuStrip = this.metroContextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JRemoval\r\n";
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem1,
            this.creditsToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitJRemovalToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(174, 76);
            // 
            // checkForUpdatesToolStripMenuItem1
            // 
            this.checkForUpdatesToolStripMenuItem1.Name = "checkForUpdatesToolStripMenuItem1";
            this.checkForUpdatesToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem1.Text = "Check For Updates";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // quitJRemovalToolStripMenuItem
            // 
            this.quitJRemovalToolStripMenuItem.Name = "quitJRemovalToolStripMenuItem";
            this.quitJRemovalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.quitJRemovalToolStripMenuItem.Text = "Quit JRemoval";
            this.quitJRemovalToolStripMenuItem.Click += new System.EventHandler(this.quitJRemovalToolStripMenuItem_Click);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon2.BalloonTipText = "Your computer battery is running low, it is highly recommended that you charge it" +
    ". ";
            this.notifyIcon2.BalloonTipTitle = "Battery Running Low";
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "JRemoval\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JRemoval.Properties.Resources.Close_Light;
            this.pictureBox1.Location = new System.Drawing.Point(905, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disk Size on C:\r\n";
            this.metroToolTip1.SetToolTip(this.label5, "\r\n");
            // 
            // divider1
            // 
            this.divider1.AutoSize = true;
            this.divider1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divider1.Location = new System.Drawing.Point(4, 351);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(243, 17);
            this.divider1.TabIndex = 11;
            this.divider1.Text = "-----------------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(88, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Battery";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "-----------------------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(64, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Storage && Disk";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(120, 320);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 28);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Disk Cleanup";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroButton1, "Go to Power Configuration");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(7, 320);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(110, 28);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Defrag";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.metroButton2, "Go to Power Configuration");
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tilePlaceholder);
            this.Controls.Add(this.tileSystemStatus);
            this.Controls.Add(this.tileRemoveTelemetry);
            this.Controls.Add(this.tileCleanupComputer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "JRemoval";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnPowerPlans;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTile tileCleanupComputer;
        private MetroFramework.Controls.MetroTile tileRemoveTelemetry;
        private MetroFramework.Controls.MetroTile tileSystemStatus;
        private MetroFramework.Controls.MetroTile tilePlaceholder;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Label lblBatteryPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitJRemovalToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

