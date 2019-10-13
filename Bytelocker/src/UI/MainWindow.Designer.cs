﻿namespace Bytelocker.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnNext = new System.Windows.Forms.Button();
            this.rtfInfo = new System.Windows.Forms.RichTextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbShield = new System.Windows.Forms.PictureBox();
            this.lbTitleTime = new System.Windows.Forms.Label();
            this.pbBitcoinLogo = new System.Windows.Forms.PictureBox();
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.tmTimeLeftRefresher = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitcoinLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(946, 586);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(180, 54);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // rtfInfo
            // 
            this.rtfInfo.Location = new System.Drawing.Point(351, 89);
            this.rtfInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtfInfo.Name = "rtfInfo";
            this.rtfInfo.ReadOnly = true;
            this.rtfInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtfInfo.Size = new System.Drawing.Size(774, 486);
            this.rtfInfo.TabIndex = 1;
            this.rtfInfo.Text = "";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(363, 14);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(407, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Your personal files are encrypted!";
            // 
            // pbShield
            // 
            this.pbShield.Image = ((System.Drawing.Image)(resources.GetObject("pbShield.Image")));
            this.pbShield.Location = new System.Drawing.Point(63, 89);
            this.pbShield.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbShield.Name = "pbShield";
            this.pbShield.Size = new System.Drawing.Size(226, 277);
            this.pbShield.TabIndex = 3;
            this.pbShield.TabStop = false;
            // 
            // lbTitleTime
            // 
            this.lbTitleTime.AutoSize = true;
            this.lbTitleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleTime.Location = new System.Drawing.Point(116, 420);
            this.lbTitleTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleTime.Name = "lbTitleTime";
            this.lbTitleTime.Size = new System.Drawing.Size(73, 20);
            this.lbTitleTime.TabIndex = 4;
            this.lbTitleTime.Text = "Time left:";
            // 
            // pbBitcoinLogo
            // 
            this.pbBitcoinLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbBitcoinLogo.Image")));
            this.pbBitcoinLogo.Location = new System.Drawing.Point(778, 448);
            this.pbBitcoinLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBitcoinLogo.Name = "pbBitcoinLogo";
            this.pbBitcoinLogo.Size = new System.Drawing.Size(228, 77);
            this.pbBitcoinLogo.TabIndex = 5;
            this.pbBitcoinLogo.TabStop = false;
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.AutoSize = true;
            this.lbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.Location = new System.Drawing.Point(93, 466);
            this.lbTimeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(104, 20);
            this.lbTimeLeft.TabIndex = 6;
            this.lbTimeLeft.Text = "00:00:00:00";
            // 
            // tmTimeLeftRefresher
            // 
            this.tmTimeLeftRefresher.Enabled = true;
            this.tmTimeLeftRefresher.Interval = 1000;
            this.tmTimeLeftRefresher.Tick += new System.EventHandler(this.UpdateTimeLeftEvent);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 648);
            this.Controls.Add(this.lbTimeLeft);
            this.Controls.Add(this.pbBitcoinLogo);
            this.Controls.Add(this.lbTitleTime);
            this.Controls.Add(this.pbShield);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.rtfInfo);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.ShowInTaskbar = false;
            this.Text = "Bytelocker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitcoinLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RichTextBox rtfInfo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbShield;
        private System.Windows.Forms.Label lbTitleTime;
        private System.Windows.Forms.PictureBox pbBitcoinLogo;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.Timer tmTimeLeftRefresher;
    }
}