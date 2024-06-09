using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Nhom1
{

    public class ChessBoardManage
    {
        #region Properties
        private Panel BanCo;
        public Panel BanCo1 { get => BanCo; set => BanCo = value; }

        private List<Player> player;
        internal List<Player> Player { get => player; set => player = value; }

        private int currentPlayer;
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private TextBox playerName;
        public TextBox PlayerName { get => playerName; set => playerName = value; }

        private PictureBox playerMark;
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }

        private List<List<Button>> matran;
        public List<List<Button>> Matran { get => matran; set => matran = value; }

        private event EventHandler<ButtonClickEvent> danhdauNguoiChoi;
        public event EventHandler<ButtonClickEvent> DanhDauNguoiChoi
        {
            add
            {
                danhdauNguoiChoi += value;
            }
            remove
            {
                danhdauNguoiChoi -= value;
            }
        }

        private event EventHandler ketthucTroChoi;
        public event EventHandler KetThucTroChoi
        {
            add
            {
                ketthucTroChoi += value;
            }
            remove
            {
                ketthucTroChoi -= value;
            }
        }

        private Stack<ThongTinTroChoi> lichsuBuocDi;
        public Stack<ThongTinTroChoi> LichsuBuocDi { get => lichsuBuocDi; set => lichsuBuocDi = value; }
        #endregion

        #region Initialize
        public ChessBoardManage(Panel BanCo, TextBox playerName, PictureBox mark)
        {
            this.BanCo1 = BanCo;
            this.playerName = playerName;
            this.playerMark = mark;
            this.player = new List<Player>()
            {
                new Player("Player No.1",Image.FromFile(Application.StartupPath + "\\Resources\\X_Shuniken.png")),
                new Player("Player No.2", Image.FromFile(Application.StartupPath+ "\\Resources\\O_Sharigan.png"))
            };
            LichsuBuocDi = new Stack<ThongTinTroChoi>();
        }
        #endregion

        #region Methods
        public static int Chieudai_O = 30;
        public static int Chieurong_O = 30;
        public static int Chieudai_Banco = 19;
        public static int Chieurong_Banco = 18;

        public void VeBanCo()
        {
            BanCo.Enabled = true;
            BanCo.Controls.Clear();

            lichsuBuocDi = new Stack<ThongTinTroChoi>();

            CurrentPlayer = 0;
            DoiNguoiChoi();

            Matran = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Chieurong_Banco; i++)
            {
                Matran.Add(new List<Button>());

                for (int j = 0; j < Chieudai_Banco; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Chieurong_O,
                        Height = Chieudai_O,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        BackColor = Color.LightGray,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;

                    BanCo1.Controls.Add(btn);

                    Matran[i].Add(btn);

                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Chieudai_O);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }
        private void playSoundOfClick()
        {
            SoundPlayer clickedSound = new SoundPlayer(Application.StartupPath + "\\SoundGame\\click.wav");
            clickedSound.Play();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackgroundImage != null)
                return;
            Danhdau(btn);

            LichsuBuocDi.Push(new ThongTinTroChoi(GetViTriCo(btn), CurrentPlayer));


            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            DoiNguoiChoi();

            if (danhdauNguoiChoi != null)
            {
                danhdauNguoiChoi(this, new ButtonClickEvent(GetViTriCo(btn)));
            }

            if (ktKetThucGame(btn))
            {
                MessageBox.Show("Game Over");
                KetThucGame();
            }
        }

        public void KetThucGame()
        {
            if (ketthucTroChoi != null)
                ketthucTroChoi(this, new EventArgs());
        }

        public Stack<ThongTinTroChoi> GetLichsuBuocDi()
        {
            return LichsuBuocDi;
        }


        public bool LuiMotBuoc()
        {
            if (lichsuBuocDi.Count <= 0)
            {
                return false;
            }
            ThongTinTroChoi oldPoint = lichsuBuocDi.Pop();
            Button btn = Matran[oldPoint.Point.Y][oldPoint.Point.X];

            btn.BackgroundImage = null;


            if (lichsuBuocDi.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                oldPoint = lichsuBuocDi.Peek();

            }

            DoiNguoiChoi();

            return true;
        }

        private bool ktKetThucGame(Button btn)
        {
            return ktKetThucNgang(btn) || ktKetThucDoc(btn) || ktKetThucCheoChinh(btn) || ktKetThucCheoPhu(btn);
        }
        private Point GetViTriCo(Button btn)
        {
            int ngang = Convert.ToInt32(btn.Tag);
            int doc = Matran[ngang].IndexOf(btn);

            Point vitri = new Point(doc, ngang);

            return vitri;
        }
        private bool ktKetThucNgang(Button btn)
        {
            Point vitri = GetViTriCo(btn);

            int demTrai = 0;
            for (int i = vitri.X; i >= 0; i--)
            {
                if (Matran[vitri.Y][i].BackgroundImage == btn.BackgroundImage)
                    demTrai++;
                else
                    break;
            }

            int demPhai = 0;
            for (int i = vitri.X + 1; i < Chieurong_Banco; i++)
            {
                if (Matran[vitri.Y][i].BackgroundImage == btn.BackgroundImage)
                    demPhai++;
                else
                    break;
            }

            return demPhai + demTrai == 5;
        }
        private bool ktKetThucDoc(Button btn)
        {
            Point vitri = GetViTriCo(btn);

            int demTren = 0;
            for (int i = vitri.Y; i >= 0; i--)
            {
                if (Matran[i][vitri.X].BackgroundImage == btn.BackgroundImage)
                    demTren++;
                else
                    break;
            }

            int demDuoi = 0;
            for (int i = vitri.Y + 1; i < Chieudai_Banco; i++)
            {
                if (Matran[i][vitri.X].BackgroundImage == btn.BackgroundImage)
                    demDuoi++;
                else
                    break;
            }

            return demTren + demDuoi == 5;
        }
        private bool ktKetThucCheoChinh(Button btn)
        {
            Point vitri = GetViTriCo(btn);

            int demTren = 0;
            for (int i = 0; i <= vitri.X; i++)
            {
                if (vitri.X - i < 0 || vitri.Y - i < 0)
                    break;
                if (Matran[vitri.Y - i][vitri.X - i].BackgroundImage == btn.BackgroundImage)
                    demTren++;
                else
                    break;
            }

            int demDuoi = 0;
            for (int i = 1; i <= Chieurong_Banco - vitri.X; i++)
            {
                if (vitri.X + i >= Chieurong_Banco || vitri.Y + i >= Chieudai_Banco)
                    break;
                if (Matran[vitri.Y + i][vitri.X + i].BackgroundImage == btn.BackgroundImage)
                    demDuoi++;
                else
                    break;
            }

            return demTren + demDuoi == 5;
        }
        private bool ktKetThucCheoPhu(Button btn)
        {
            Point vitri = GetViTriCo(btn);

            int demTren = 0;
            for (int i = 0; i <= vitri.X; i++)
            {
                if (vitri.X + i >= Chieurong_Banco || vitri.Y - i < 0)
                    break;
                if (Matran[vitri.Y - i][vitri.X + i].BackgroundImage == btn.BackgroundImage)
                    demTren++;
                else
                    break;
            }

            int demDuoi = 0;
            for (int i = 1; i <= Chieurong_Banco - vitri.X; i++)
            {
                if (vitri.X - i < 0 || vitri.Y + i >= Chieudai_Banco)
                    break;
                if (Matran[vitri.Y + i][vitri.X - i].BackgroundImage == btn.BackgroundImage)
                    demDuoi++;
                else
                    break;
            }

            return demTren + demDuoi == 5;
        }
        private void Danhdau(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
        }
        private void DoiNguoiChoi()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }

   
}
