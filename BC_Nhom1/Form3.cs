using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Nhom1
{
    public partial class Form3 : Form
    {
        #region Properties
        ChessBoardManage BanCo;
        #endregion
        public Form3()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            // Đặt kích thước của Form về giá trị mặc định
            this.Size = this.MinimumSize;


            BanCo = new ChessBoardManage(pnPlay, txtNamePlayer, pbImagePlayer);
            BanCo.KetThucTroChoi += BanCo_KetThucTroChoi;
            BanCo.DanhDauNguoiChoi += BanCo_DanhDauNguoiChoi;

            

  
            BanCo.VeBanCo();
        }

        void KetThucTroChoi()
        {
            pnPlay.Enabled = false;
            lùiLạiToolStripMenuItem.Enabled = false;
        }

        void TaoMoiTroChoi()
        {
            BanCo.VeBanCo();
            
            lùiLạiToolStripMenuItem.Enabled = true;
            
        }

        void Lui()
        {
            BanCo.LuiMotBuoc();
            
        }

        void ThoatTroChoi()
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); 
        }
        void BanCo_DanhDauNguoiChoi(object sender, ButtonClickEvent e)
        {
            pnPlay.Enabled = true;
            
            lùiLạiToolStripMenuItem.Enabled = true;
        }

        void BanCo_KetThucTroChoi(object sender, EventArgs e)
        {
            KetThucTroChoi();
        }

        private void pnPlay_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {          
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HuongDan huongDan = new HuongDan();
            huongDan.ShowDialog();
        }

        private void nguồnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThongTin thongTin = new ThongTin();
            thongTin.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pnPlay.Enabled = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {        
        }

        private void lùiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lui();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to quit?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK))
            {
                ThoatTroChoi();
            }
        }

        private void chơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoMoiTroChoi();         
        }

        private void tmCountDown_Tick_1(object sender, EventArgs e)
        {
            
        }
    }
}
