namespace BC_Nhom1
{
    partial class Form3
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
            this.pbImagePlayer = new System.Windows.Forms.PictureBox();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.nguồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lùiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnPlay = new System.Windows.Forms.Panel();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePlayer)).BeginInit();
            this.pnInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagePlayer
            // 
            this.pbImagePlayer.BackColor = System.Drawing.SystemColors.Control;
            this.pbImagePlayer.Location = new System.Drawing.Point(105, 78);
            this.pbImagePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImagePlayer.Name = "pbImagePlayer";
            this.pbImagePlayer.Size = new System.Drawing.Size(169, 153);
            this.pbImagePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagePlayer.TabIndex = 3;
            this.pbImagePlayer.TabStop = false;
            // 
            // pnInfo
            // 
            this.pnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfo.Controls.Add(this.label1);
            this.pnInfo.Controls.Add(this.pbImagePlayer);
            this.pnInfo.Controls.Add(this.txtNamePlayer);
            this.pnInfo.Location = new System.Drawing.Point(12, 409);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(390, 284);
            this.pnInfo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "GROUP 1 - CARO CHESS GAME";
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Enabled = false;
            this.txtNamePlayer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer.Location = new System.Drawing.Point(3, 16);
            this.txtNamePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.Size = new System.Drawing.Size(382, 47);
            this.txtNamePlayer.TabIndex = 3;
            this.txtNamePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nguồnToolStripMenuItem
            // 
            this.nguồnToolStripMenuItem.Name = "nguồnToolStripMenuItem";
            this.nguồnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.nguồnToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.nguồnToolStripMenuItem.Text = "Credits";
            this.nguồnToolStripMenuItem.Click += new System.EventHandler(this.nguồnToolStripMenuItem_Click_1);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.hướngDẫnToolStripMenuItem.Text = "Tutorial";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click_1);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.nguồnToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(76, 35);
            this.trợGiúpToolStripMenuItem.Text = "Help";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.thoátToolStripMenuItem.Text = "Quit game";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // lùiLạiToolStripMenuItem
            // 
            this.lùiLạiToolStripMenuItem.Name = "lùiLạiToolStripMenuItem";
            this.lùiLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.lùiLạiToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.lùiLạiToolStripMenuItem.Text = "Undo";
            this.lùiLạiToolStripMenuItem.Click += new System.EventHandler(this.lùiLạiToolStripMenuItem_Click);
            // 
            // chơiMớiToolStripMenuItem
            // 
            this.chơiMớiToolStripMenuItem.Name = "chơiMớiToolStripMenuItem";
            this.chơiMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.chơiMớiToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.chơiMớiToolStripMenuItem.Text = "New game";
            this.chơiMớiToolStripMenuItem.Click += new System.EventHandler(this.chơiMớiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::BC_Nhom1.Properties.Resources.Bg_Xo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 336);
            this.panel1.TabIndex = 8;
            // 
            // pnPlay
            // 
            this.pnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnPlay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnPlay.Location = new System.Drawing.Point(421, 71);
            this.pnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(723, 622);
            this.pnPlay.TabIndex = 5;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiMớiToolStripMenuItem,
            this.lùiLạiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(87, 35);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1175, 39);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 703);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnPlay);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1193, 750);
            this.MinimumSize = new System.Drawing.Size(1193, 750);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePlayer)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagePlayer;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.ToolStripMenuItem nguồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lùiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiMớiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnPlay;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}