using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationProject
{
    public partial class GameWindow : Form
    {
        #region Variable

        // 変数定義
        int countdown = 3;
        int timer = 100;
        int point = 0;

        int BposX, BposY;
        int BmovX = 5;
        int BmovY = -5;
        int Btokuten = 1;

        // 配列でpictureboxを管理
        private PictureBox[] Boxes;

        #endregion

        public GameWindow()
        {
            InitializeComponent();

            #region PictureBox配列

            Boxes = new PictureBox[28];
            Boxes[0] = pictureBox1;
            Boxes[1] = pictureBox2;
            Boxes[2] = pictureBox3;
            Boxes[3] = pictureBox4;
            Boxes[4] = pictureBox5;
            Boxes[5] = pictureBox6;
            Boxes[6] = pictureBox7;
            Boxes[7] = pictureBox8;
            Boxes[8] = pictureBox9;
            Boxes[9] = pictureBox10;
            Boxes[10] = pictureBox11;
            Boxes[11] = pictureBox12;
            Boxes[12] = pictureBox13;
            Boxes[13] = pictureBox14;
            Boxes[14] = pictureBox15;
            Boxes[15] = pictureBox16;
            Boxes[16] = pictureBox17;
            Boxes[17] = pictureBox18;
            Boxes[18] = pictureBox19;
            Boxes[19] = pictureBox20;
            Boxes[20] = pictureBox21;
            Boxes[21] = pictureBox22;
            Boxes[22] = pictureBox23;
            Boxes[23] = pictureBox24;
            Boxes[24] = pictureBox25;
            Boxes[25] = pictureBox26;
            Boxes[26] = pictureBox27;
            Boxes[27] = pictureBox28;

            #endregion
        }

        #region Method

        private bool CheckCollision(PictureBox pb1, PictureBox pb2) // 衝突判定
        {
            // PictureBoxの境界を表すRectangleオブジェクトを作成
            Rectangle rect1 = new Rectangle(pb1.Location, pb1.Size);
            Rectangle rect2 = new Rectangle(pb2.Location, pb2.Size);

            //　Rectangle同士が交差(衝突)しているかを判定
            return rect1.IntersectsWith(rect2);
        }

        #endregion

        #region Event Handlers

        private void GameWindow_Load(object sender, EventArgs e)
        {
            // セットアップ
            Button_Start.Visible = true;
            Label_CountDown.Visible = false;
            Label_Start.Visible = false;
            Panel.Visible = false;
            BposX = Ball.Location.X;
            BposY = Ball.Location.Y;
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Button_Start.Visible = false;
            Label_CountDown.Visible = true;
            Panel.Visible = true;

            Timer_CountDown.Enabled = true;
            Label_CountDown.Text = Convert.ToString(countdown);
        }

        private void Timer_CountDown_Tick(object sender, EventArgs e)
        {
            --countdown;
            Label_CountDown.Text = Convert.ToString(countdown);

            if (countdown == 0)
            {
                Label_Start.Visible = true;
                Label_CountDown.Visible = false;
                Timer_Time.Enabled = true;
                Timer_Game.Enabled = true;
            }

            if (countdown == -1)
            {
                Timer_CountDown.Enabled = false;
                Label_Start.Visible = false;
            }
        }

        private void Timer_Time_Tick(object sender, EventArgs e)
        {
            --timer;
            Label_Time.Text = Convert.ToString(timer);
        }

        #endregion

        private void Timer_Game_Tick(object sender, EventArgs e) // ゲームの主要動作
        {
            BposX += BmovX;
            BposY += BmovY;            
            Ball.Location = new Point(BposX, BposY);

            for (int i = 0; i < 28; i++)
            {
                if (CheckCollision(Ball, Boxes[i]))
                {
                    point += Btokuten;
                    Label_Point.Text = Convert.ToString(point);
                    BmovX = -BmovX;
                    BmovY = -BmovY;
                }
            }

        }
    }
}
