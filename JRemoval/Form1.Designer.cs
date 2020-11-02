﻿namespace JRemoval
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
            this.btnChangePCName = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPowerPlans = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblBatteryPercent = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tilePlaceholder = new MetroFramework.Controls.MetroTile();
            this.tileSystemStatus = new MetroFramework.Controls.MetroTile();
            this.tileRemoveTelemetry = new MetroFramework.Controls.MetroTile();
            this.tileCleanupComputer = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lblBatteryPercent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnChangePCName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPowerPlans);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 643);
            this.panel1.TabIndex = 0;
            // 
            // btnChangePCName
            // 
            this.btnChangePCName.Location = new System.Drawing.Point(113, 617);
            this.btnChangePCName.Name = "btnChangePCName";
            this.btnChangePCName.Size = new System.Drawing.Size(108, 23);
            this.btnChangePCName.TabIndex = 4;
            this.btnChangePCName.Text = "Change PC Name";
            this.btnChangePCName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToolTip1.SetToolTip(this.btnChangePCName, "Change PC Name");
            this.btnChangePCName.UseSelectable = true;
            this.btnChangePCName.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Power Plans";
            // 
            // btnPowerPlans
            // 
            this.btnPowerPlans.Location = new System.Drawing.Point(146, 529);
            this.btnPowerPlans.Name = "btnPowerPlans";
            this.btnPowerPlans.Size = new System.Drawing.Size(75, 23);
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
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Singed In: %username%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Computer at a glance...";
            this.metroToolTip1.SetToolTip(this.label1, "My Computer at a Glance");
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "JRemoval will still be running in the background.";
            this.notifyIcon1.BalloonTipTitle = "Still Running In Background";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "You can hide these notifications in \"Settings\".";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon2.BalloonTipText = "Your computer battery is running low, it is highly recommended that you charge it" +
    ". ";
            this.notifyIcon2.BalloonTipTitle = "Battery Running Low";
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "You can hide these notifications in \"Settings\".";
            this.notifyIcon2.Visible = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Battery Percentage:";
            // 
            // lblBatteryPercent
            // 
            this.lblBatteryPercent.AutoSize = true;
            this.lblBatteryPercent.Font = new System.Drawing.Font("Microsoft YaHei", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblBatteryPercent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBatteryPercent.Location = new System.Drawing.Point(139, 126);
            this.lblBatteryPercent.Name = "lblBatteryPercent";
            this.lblBatteryPercent.Size = new System.Drawing.Size(53, 19);
            this.lblBatteryPercent.TabIndex = 6;
            this.lblBatteryPercent.Text = "%00%";
            this.lblBatteryPercent.Click += new System.EventHandler(this.lblBatteryPercent_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JRemoval.Properties.Resources.Close_Light;
            this.pictureBox1.Location = new System.Drawing.Point(901, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.metroToolTip1.SetToolTip(this.tilePlaceholder, "System Status");
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
            // 
            // tileRemoveTelemetry
            // 
            this.tileRemoveTelemetry.ActiveControl = null;
            this.tileRemoveTelemetry.Location = new System.Drawing.Point(595, 29);
            this.tileRemoveTelemetry.Name = "tileRemoveTelemetry";
            this.tileRemoveTelemetry.Size = new System.Drawing.Size(234, 240);
            this.tileRemoveTelemetry.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileRemoveTelemetry.TabIndex = 6;
            this.tileRemoveTelemetry.Text = "Remove Telemetry";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnPowerPlans;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnChangePCName;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTile tileCleanupComputer;
        private MetroFramework.Controls.MetroTile tileRemoveTelemetry;
        private MetroFramework.Controls.MetroTile tileSystemStatus;
        private MetroFramework.Controls.MetroTile tilePlaceholder;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Label lblBatteryPercent;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

