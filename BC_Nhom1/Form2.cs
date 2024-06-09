using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Nhom1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
 
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

        private bool isLoaOn = false;

        

        private void bntLeaveGame_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exits?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                    Application.Exit();
            } 
        }

        private void bntHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan huongDan = new HuongDan();      
            huongDan.ShowDialog();
        }

        private void bntStart_Click(object sender, EventArgs e)
        {         
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }   
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
