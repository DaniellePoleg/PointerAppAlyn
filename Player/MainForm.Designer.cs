﻿using System.Drawing;

namespace UI
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localVideoCaptureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capture1stDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelTakeMeThere = new System.Windows.Forms.Label();
            this.buttonTakeMeThere = new System.Windows.Forms.Button();
            this.labelWhoIsThis = new System.Windows.Forms.Label();
            this.buttonWhoIsThis = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutTake = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutWho = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonIWantThis = new System.Windows.Forms.Button();
            this.flowLayoutWantThis = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonWantThis = new System.Windows.Forms.Button();
            this.labelWantThis = new System.Windows.Forms.Label();
            this.flowLayoutWhatsThis = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIWantThis = new System.Windows.Forms.Label();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.flowLayoutTake.SuspendLayout();
            this.flowLayoutWho.SuspendLayout();
            this.flowLayoutWantThis.SuspendLayout();
            this.flowLayoutWhatsThis.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1277, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localVideoCaptureDeviceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // localVideoCaptureDeviceToolStripMenuItem
            // 
            this.localVideoCaptureDeviceToolStripMenuItem.Name = "localVideoCaptureDeviceToolStripMenuItem";
            this.localVideoCaptureDeviceToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.localVideoCaptureDeviceToolStripMenuItem.Text = "Local &Video Capture Device";
            this.localVideoCaptureDeviceToolStripMenuItem.Click += new System.EventHandler(this.localVideoCaptureDeviceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openVideofileusingDirectShowToolStripMenuItem
            // 
            this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
            this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openJPEGURLToolStripMenuItem
            // 
            this.openJPEGURLToolStripMenuItem.Name = "openJPEGURLToolStripMenuItem";
            this.openJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openMJPEGURLToolStripMenuItem
            // 
            this.openMJPEGURLToolStripMenuItem.Name = "openMJPEGURLToolStripMenuItem";
            this.openMJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // capture1stDisplayToolStripMenuItem
            // 
            this.capture1stDisplayToolStripMenuItem.Name = "capture1stDisplayToolStripMenuItem";
            this.capture1stDisplayToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(367, 6);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 576);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1277, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(1262, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainPanel.Controls.Add(this.flowLayoutTake);
            this.mainPanel.Controls.Add(this.flowLayoutWho);
            this.mainPanel.Controls.Add(this.flowLayoutWantThis);
            this.mainPanel.Controls.Add(this.flowLayoutWhatsThis);
            this.mainPanel.Controls.Add(this.videoSourcePlayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1277, 552);
            this.mainPanel.TabIndex = 2;
            // 
            // labelTakeMeThere
            // 
            this.labelTakeMeThere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTakeMeThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTakeMeThere.Location = new System.Drawing.Point(2, 104);
            this.labelTakeMeThere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTakeMeThere.Name = "labelTakeMeThere";
            this.labelTakeMeThere.Size = new System.Drawing.Size(99, 19);
            this.labelTakeMeThere.TabIndex = 9;
            this.labelTakeMeThere.Text = "לשם";
            this.labelTakeMeThere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTakeMeThere
            // 
            this.buttonTakeMeThere.AutoSize = true;
            this.buttonTakeMeThere.BackColor = System.Drawing.Color.Transparent;
            this.buttonTakeMeThere.BackgroundImage = global::Player.Properties.Resources.takeMeThere;
            this.buttonTakeMeThere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTakeMeThere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTakeMeThere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeMeThere.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTakeMeThere.Location = new System.Drawing.Point(2, 2);
            this.buttonTakeMeThere.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeMeThere.Name = "buttonTakeMeThere";
            this.buttonTakeMeThere.Size = new System.Drawing.Size(99, 100);
            this.buttonTakeMeThere.TabIndex = 8;
            this.buttonTakeMeThere.UseVisualStyleBackColor = false;
            this.buttonTakeMeThere.Click += new System.EventHandler(this.buttonTakeMeThere_Click);
            // 
            // labelWhoIsThis
            // 
            this.labelWhoIsThis.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWhoIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWhoIsThis.Location = new System.Drawing.Point(-2, 62);
            this.labelWhoIsThis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWhoIsThis.Name = "labelWhoIsThis";
            this.labelWhoIsThis.Size = new System.Drawing.Size(100, 19);
            this.labelWhoIsThis.TabIndex = 5;
            this.labelWhoIsThis.Text = "מי זה?";
            this.labelWhoIsThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonWhoIsThis
            // 
            this.buttonWhoIsThis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWhoIsThis.BackgroundImage = global::Player.Properties.Resources.whoIsThis;
            this.buttonWhoIsThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWhoIsThis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWhoIsThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhoIsThis.ForeColor = System.Drawing.Color.Black;
            this.buttonWhoIsThis.Location = new System.Drawing.Point(-2, 2);
            this.buttonWhoIsThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWhoIsThis.Name = "buttonWhoIsThis";
            this.buttonWhoIsThis.Size = new System.Drawing.Size(100, 58);
            this.buttonWhoIsThis.TabIndex = 4;
            this.buttonWhoIsThis.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem movie";
            // 
            // flowLayoutTake
            // 
            this.flowLayoutTake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutTake.BackColor = System.Drawing.Color.White;
            this.flowLayoutTake.Controls.Add(this.buttonTakeMeThere);
            this.flowLayoutTake.Controls.Add(this.labelTakeMeThere);
            this.flowLayoutTake.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutTake.Location = new System.Drawing.Point(1177, 402);
            this.flowLayoutTake.Name = "flowLayoutTake";
            this.flowLayoutTake.Size = new System.Drawing.Size(100, 150);
            this.flowLayoutTake.TabIndex = 11;
            // 
            // flowLayoutWho
            // 
            this.flowLayoutWho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutWho.BackColor = System.Drawing.Color.White;
            this.flowLayoutWho.Controls.Add(this.buttonWhoIsThis);
            this.flowLayoutWho.Controls.Add(this.labelWhoIsThis);
            this.flowLayoutWho.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutWho.Location = new System.Drawing.Point(1174, 0);
            this.flowLayoutWho.Name = "flowLayoutWho";
            this.flowLayoutWho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutWho.Size = new System.Drawing.Size(100, 100);
            this.flowLayoutWho.TabIndex = 10;
            // 
            // buttonIWantThis
            // 
            this.buttonIWantThis.BackgroundImage = global::Player.Properties.Resources.whatIsThis;
            this.buttonIWantThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIWantThis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonIWantThis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIWantThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIWantThis.ForeColor = System.Drawing.Color.Black;
            this.buttonIWantThis.Location = new System.Drawing.Point(-1, 2);
            this.buttonIWantThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIWantThis.Name = "buttonIWantThis";
            this.buttonIWantThis.Size = new System.Drawing.Size(99, 58);
            this.buttonIWantThis.TabIndex = 6;
            this.buttonIWantThis.UseVisualStyleBackColor = true;
            // 
            // flowLayoutWantThis
            // 
            this.flowLayoutWantThis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutWantThis.BackColor = System.Drawing.Color.White;
            this.flowLayoutWantThis.Controls.Add(this.buttonWantThis);
            this.flowLayoutWantThis.Controls.Add(this.labelWantThis);
            this.flowLayoutWantThis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutWantThis.Location = new System.Drawing.Point(0, 445);
            this.flowLayoutWantThis.Name = "flowLayoutWantThis";
            this.flowLayoutWantThis.Size = new System.Drawing.Size(100, 100);
            this.flowLayoutWantThis.TabIndex = 9;
            // 
            // buttonWantThis
            // 
            this.buttonWantThis.BackgroundImage = global::Player.Properties.Resources.iWantThis;
            this.buttonWantThis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWantThis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonWantThis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWantThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWantThis.ForeColor = System.Drawing.Color.Black;
            this.buttonWantThis.Location = new System.Drawing.Point(2, 2);
            this.buttonWantThis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWantThis.Name = "buttonWantThis";
            this.buttonWantThis.Size = new System.Drawing.Size(99, 58);
            this.buttonWantThis.TabIndex = 6;
            this.buttonWantThis.UseVisualStyleBackColor = false;
            // 
            // labelWantThis
            // 
            this.labelWantThis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWantThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWantThis.Location = new System.Drawing.Point(2, 62);
            this.labelWantThis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWantThis.Name = "labelWantThis";
            this.labelWantThis.Size = new System.Drawing.Size(99, 19);
            this.labelWantThis.TabIndex = 7;
            this.labelWantThis.Text = "רוצה";
            this.labelWantThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutWhatsThis
            // 
            this.flowLayoutWhatsThis.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.flowLayoutWhatsThis.BackColor = System.Drawing.Color.White;
            this.flowLayoutWhatsThis.Controls.Add(this.buttonIWantThis);
            this.flowLayoutWhatsThis.Controls.Add(this.labelIWantThis);
            this.flowLayoutWhatsThis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutWhatsThis.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutWhatsThis.Name = "flowLayoutWhatsThis";
            this.flowLayoutWhatsThis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutWhatsThis.Size = new System.Drawing.Size(100, 100);
            this.flowLayoutWhatsThis.TabIndex = 8;
            // 
            // labelIWantThis
            // 
            this.labelIWantThis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIWantThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIWantThis.Location = new System.Drawing.Point(-1, 62);
            this.labelIWantThis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIWantThis.Name = "labelIWantThis";
            this.labelIWantThis.Size = new System.Drawing.Size(99, 19);
            this.labelIWantThis.TabIndex = 7;
            this.labelIWantThis.Text = "מה זה?";
            this.labelIWantThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.AutoSizeControl = true;
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(10);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(1277, 552);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1277, 598);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.flowLayoutTake.ResumeLayout(false);
            this.flowLayoutTake.PerformLayout();
            this.flowLayoutWho.ResumeLayout(false);
            this.flowLayoutWantThis.ResumeLayout(false);
            this.flowLayoutWhatsThis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localVideoCaptureDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMJPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capture1stDisplayToolStripMenuItem;
        private System.Windows.Forms.Label labelTakeMeThere;
        private System.Windows.Forms.Button buttonTakeMeThere;
        private System.Windows.Forms.Label labelWhoIsThis;
        private System.Windows.Forms.Button buttonWhoIsThis;
        private System.Windows.Forms.Button buttonIWantThis;
        private System.Windows.Forms.Label labelIWantThis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutWhatsThis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutWantThis;
        private System.Windows.Forms.Button buttonWantThis;
        private System.Windows.Forms.Label labelWantThis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTake;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutWho;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
    }
}