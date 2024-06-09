namespace BC_Nhom1
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
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagePlayer = new System.Windows.Forms.PictureBox();
            this.btnLan = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.pgbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lùiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChessBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlChessBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlChessBoard.Location = new System.Drawing.Point(421, 61);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(723, 622);
            this.pnlChessBoard.TabIndex = 0;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPlay_Paint);
            // 
            // pnInfo
            // 
            this.pnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfo.Controls.Add(this.label1);
            this.pnInfo.Controls.Add(this.pbImagePlayer);
            this.pnInfo.Controls.Add(this.btnLan);
            this.pnInfo.Controls.Add(this.txbID);
            this.pnInfo.Controls.Add(this.pgbCoolDown);
            this.pnInfo.Controls.Add(this.txtPlayerName);
            this.pnInfo.Location = new System.Drawing.Point(12, 399);
            this.pnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(390, 284);
            this.pnInfo.TabIndex = 2;
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
            // pbImagePlayer
            // 
            this.pbImagePlayer.BackColor = System.Drawing.SystemColors.Control;
            this.pbImagePlayer.Location = new System.Drawing.Point(0, 12);
            this.pbImagePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImagePlayer.Name = "pbImagePlayer";
            this.pbImagePlayer.Size = new System.Drawing.Size(212, 203);
            this.pbImagePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagePlayer.TabIndex = 3;
            this.pbImagePlayer.TabStop = false;
            // 
            // btnLan
            // 
            this.btnLan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLan.Location = new System.Drawing.Point(230, 173);
            this.btnLan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(159, 37);
            this.btnLan.TabIndex = 6;
            this.btnLan.Text = "CONNECT";
            this.btnLan.UseVisualStyleBackColor = true;
            this.btnLan.Click += new System.EventHandler(this.btnLan_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(230, 130);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(159, 34);
            this.txbID.TabIndex = 5;
            // 
            // pgbCoolDown
            // 
            this.pgbCoolDown.Location = new System.Drawing.Point(230, 63);
            this.pgbCoolDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pgbCoolDown.Maximum = 1000;
            this.pgbCoolDown.Name = "pgbCoolDown";
            this.pgbCoolDown.Size = new System.Drawing.Size(159, 39);
            this.pgbCoolDown.TabIndex = 4;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(230, 12);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(159, 34);
            this.txtPlayerName.TabIndex = 3;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
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
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // chơiMớiToolStripMenuItem
            // 
            this.chơiMớiToolStripMenuItem.Enabled = false;
            this.chơiMớiToolStripMenuItem.Name = "chơiMớiToolStripMenuItem";
            this.chơiMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.chơiMớiToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.chơiMớiToolStripMenuItem.Text = "New game";
            this.chơiMớiToolStripMenuItem.Click += new System.EventHandler(this.chơiMớiToolStripMenuItem_Click);
            // 
            // lùiLạiToolStripMenuItem
            // 
            this.lùiLạiToolStripMenuItem.Enabled = false;
            this.lùiLạiToolStripMenuItem.Name = "lùiLạiToolStripMenuItem";
            this.lùiLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.lùiLạiToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.lùiLạiToolStripMenuItem.Text = "Undo";
            this.lùiLạiToolStripMenuItem.Click += new System.EventHandler(this.lùiLạiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(295, 36);
            this.thoátToolStripMenuItem.Text = "Quit game";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
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
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.hướngDẫnToolStripMenuItem.Text = "Tutorial";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // nguồnToolStripMenuItem
            // 
            this.nguồnToolStripMenuItem.Name = "nguồnToolStripMenuItem";
            this.nguồnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.nguồnToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.nguồnToolStripMenuItem.Text = "Credits";
            this.nguồnToolStripMenuItem.Click += new System.EventHandler(this.nguồnToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::BC_Nhom1.Properties.Resources.Bg_Xo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 336);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1175, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1193, 867);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1193, 750);
            this.Name = "Form1";
            this.Text = "CARO GANE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.ProgressBar pgbCoolDown;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.PictureBox pbImagePlayer;
        private System.Windows.Forms.Timer tmCountDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lùiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nguồnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLan;
    }
}

