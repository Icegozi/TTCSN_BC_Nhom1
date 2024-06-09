namespace BC_Nhom1
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntHuongDan = new System.Windows.Forms.Button();
            this.bntStart = new System.Windows.Forms.Button();
            this.bntLeaveGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BC_Nhom1.Properties.Resources.hinh_nen_anime_5;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bntHuongDan);
            this.panel1.Controls.Add(this.bntStart);
            this.panel1.Controls.Add(this.bntLeaveGame);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 750);
            this.panel1.TabIndex = 0;
            // 
            // bntHuongDan
            // 
            this.bntHuongDan.BackColor = System.Drawing.Color.Linen;
            this.bntHuongDan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuongDan.Location = new System.Drawing.Point(436, 320);
            this.bntHuongDan.Name = "bntHuongDan";
            this.bntHuongDan.Size = new System.Drawing.Size(313, 69);
            this.bntHuongDan.TabIndex = 5;
            this.bntHuongDan.Text = "TUTORIAL";
            this.bntHuongDan.UseVisualStyleBackColor = false;
            this.bntHuongDan.Click += new System.EventHandler(this.bntHuongDan_Click);
            // 
            // bntStart
            // 
            this.bntStart.BackColor = System.Drawing.Color.Linen;
            this.bntStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntStart.Location = new System.Drawing.Point(436, 225);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(313, 69);
            this.bntStart.TabIndex = 4;
            this.bntStart.Text = "START";
            this.bntStart.UseVisualStyleBackColor = false;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // bntLeaveGame
            // 
            this.bntLeaveGame.BackColor = System.Drawing.Color.Linen;
            this.bntLeaveGame.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLeaveGame.Location = new System.Drawing.Point(436, 415);
            this.bntLeaveGame.Name = "bntLeaveGame";
            this.bntLeaveGame.Size = new System.Drawing.Size(313, 69);
            this.bntLeaveGame.TabIndex = 3;
            this.bntLeaveGame.Text = "LEAVE GAME";
            this.bntLeaveGame.UseVisualStyleBackColor = false;
            this.bntLeaveGame.Click += new System.EventHandler(this.bntLeaveGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 703);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "CARO GAME";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntHuongDan;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Button bntLeaveGame;
    }
}