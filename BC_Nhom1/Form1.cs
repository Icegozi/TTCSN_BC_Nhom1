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
    public partial class Form1 : Form
    {
        #region Properties
        XuLyBanCo BanCo;

        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            // Đặt kích thước của Form về giá trị mặc định
            this.Size = this.MinimumSize;


            BanCo = new XuLyBanCo(pnlChessBoard, txtPlayerName, pbImagePlayer);
            BanCo.KetThucTroChoi += BanCo_KetThucTroChoi;
            BanCo.DanhDauNguoiChoi += BanCo_DanhDauNguoiChoi;

            pgbCoolDown.Step = COOL_DOWN_STEP;
            pgbCoolDown.Maximum = COOL_DOWN_TIME;
            pgbCoolDown.Value = 0;

            tmCountDown.Interval = COOL_DOWN_INTERVAL;
            

            socket = new SocketManager();

            BanCo.VeBanCo();
        }

        void KetThucTroChoi()
        {
            tmCountDown.Stop();
            pnlChessBoard.Enabled = false;
            lùiLạiToolStripMenuItem.Enabled = false;
        }

        void TaoMoiTroChoi()
        {
            BanCo.VeBanCo();
            pgbCoolDown.Value = 0;
            lùiLạiToolStripMenuItem.Enabled=false;
            tmCountDown.Stop();
        }

        void Lui()
        {
            BanCo.Lui();
            pgbCoolDown.Value = 0;
        }

        void ThoatTroChoi()
        {
            Form2 form2 = new Form2();
            form2.FormClosed += Form2_FormClosed1;          
            form2.Show();
            this.Hide();
        }

        private void Form2_FormClosed1(object sender, FormClosedEventArgs e)
        {  
                     this.Close();        
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        void BanCo_DanhDauNguoiChoi(object sender, ButtonClickEvent e)
        {
            tmCountDown.Start();
            pnlChessBoard.Enabled = false;
            pgbCoolDown.Value = 0;
            
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            lùiLạiToolStripMenuItem.Enabled = false;
            Listen();
        }

        void BanCo_KetThucTroChoi(object sender, EventArgs e)
        {
            KetThucTroChoi();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlChessBoard.Enabled = false;
        }

        private void pnPlay_Paint(object sender, PaintEventArgs e)
        {

        }

        public static int COOL_DOWN_STEP = 150;
        public static int COOL_DOWN_TIME = 60000;
        public static int COOL_DOWN_INTERVAL = 100;
        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            pgbCoolDown.PerformStep();
            if (pgbCoolDown.Value >= pgbCoolDown.Maximum)
            {
                KetThucTroChoi();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void chơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start new game?", "Nofication", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TaoMoiTroChoi();
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            }
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?","Nofication",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                ThoatTroChoi();
            }
        }

        private void lùiLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lui();
            socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
               try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch
                {
                }            
        }

        private void btnLan_Click(object sender, EventArgs e)
        {
            socket.IP = txbID.Text;

            try
            {
                if (!socket.ConnectServer())
                {
                    socket.isServer = true;
                    pnlChessBoard.Enabled = true;
                    chơiMớiToolStripMenuItem.Enabled = false;
                    try
                    {
                        socket.CreateServer();
                    }
                    catch { }
                    MessageBox.Show("The server created successfully");
                }
                else
                {
                    socket.isServer = false;
                    pnlChessBoard.Enabled = false;
                    Listen();
                    MessageBox.Show("Connect to server successfully");
                }
            }
            catch
            {               
                
            }

            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbID.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if(string.IsNullOrEmpty(txbID.Text))
            {
                txbID.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }    
        }

        void Listen()
        {          
            Thread listenThread = new Thread(() =>
           {
               try
               {
                   chơiMớiToolStripMenuItem.Enabled=true;                  
                   SocketData data = (SocketData)socket.Receive();                
                   ProcessData(data);                

               }
               catch
               {

               }
            });
               listenThread.IsBackground = true;
               listenThread.Start();            
        }    

        private void ProcessData(SocketData data)
        {
            switch(data.Command)
            {
                case(int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        if (MessageBox.Show("Do you want to new game with other player?", "Nofication", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            TaoMoiTroChoi();
                            pnlChessBoard.Enabled = false;
                        }
                        else
                        {
                            
                            ThoatTroChoi();
                        }
                       
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pgbCoolDown.Value = 0;
                        pnlChessBoard.Enabled = true;
                        tmCountDown.Start();
                        BanCo.DanhDauNguoiChoiKhac(data.Point);
                        lùiLạiToolStripMenuItem.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    Lui();
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Game over!");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Out of time!");
                    break;
                case (int)SocketCommand.QUIT:
                    tmCountDown.Stop();
                    MessageBox.Show("Player exited!");
                    break;
                default:
                    break;
            }   
            
            Listen();
        }

        private void nguồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin thongTin = new ThongTin();
            thongTin.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan huongDan = new HuongDan();
            huongDan.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
