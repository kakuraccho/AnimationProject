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

        int countdown = 3;
        int timer = 100;
        int point = 0;
        int Ptokuten = 1;

        int[] BposX = new int[2];
        int[] BposY = new int[2];
        int[] BmovX = new int[2];
        int[] BmovY = new int[2];
        int[] BoxHP = new int[28];

        // ボール,バーの初期位置保存
        Point[] Spoints = new Point[2];

        // 配列でpictureboxを管理
        private PictureBox[] Boxes;

        #endregion

        public GameWindow()
        {
            InitializeComponent();
            this.Name = "GameWindow";

            #region PictureBox配列

            Boxes = new PictureBox[28];
            
            // picturebox本体
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

            // pictureboxのHP
            BoxHP[0] = 3;
            BoxHP[1] = 3;
            BoxHP[2] = 3;
            BoxHP[3] = 3;
            BoxHP[4] = 3;
            BoxHP[5] = 3;
            BoxHP[6] = 3;
            BoxHP[7] = 3;
            BoxHP[8] = 3;
            BoxHP[9] = 3;
            BoxHP[10] = 3;
            BoxHP[11] = 3;
            BoxHP[12] = 3;
            BoxHP[13] = 3;
            BoxHP[14] = 3;
            BoxHP[15] = 3;
            BoxHP[16] = 3;
            BoxHP[17] = 3;
            BoxHP[18] = 3;
            BoxHP[19] = 3;
            BoxHP[20] = 3;
            BoxHP[21] = 3;
            BoxHP[22] = 3;
            BoxHP[23] = 3;
            BoxHP[24] = 3;
            BoxHP[25] = 3;
            BoxHP[26] = 3;
            BoxHP[27] = 3;

            #endregion
        }

        #region Method

        private bool CheckCollision(PictureBox pb1, PictureBox pb2) // 衝突判定
        {
            // PictureBoxの境界を表すRectangleオブジェクトを作成
            Rectangle rect1 = new Rectangle(pb1.Location, pb1.Size);
            Rectangle rect2 = new Rectangle(pb2.Location, pb2.Size);

            // Rectangle同士が交差(衝突)しているかを判定
            return rect1.IntersectsWith(rect2);
        }

        private void SetPictureBoxProperties(PictureBox pictureBox, int index, int movX, int movY)
        {
            BposX[index] = pictureBox.Location.X;
            BposY[index] = pictureBox.Location.Y;
            BmovX[index] = movX;
            BmovY[index] = movY;
            Spoints[index] = pictureBox.Location;
        }

        private void ChangeColor(PictureBox pictureBox, int index)
        {
            int BoxHPValue = BoxHP[index];
            --BoxHP[index];

            switch (BoxHPValue)
            {
                case 3:
                    pictureBox.BackColor = Color.Yellow;
                    break;
                case 2:
                    pictureBox.BackColor = Color.AliceBlue;
                    break;
                case 1:
                    pictureBox.BackColor= Color.DarkRed;
                    break;
                case 0:
                    pictureBox.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void CoordinateRefresh(object sender, EventArgs e)
        {
            BposX[0] += BmovX[0];
            BposY[0] += BmovY[0];
            BposX[1] += BmovX[1];
            BposY[1] += BmovY[1];
            Ball.Location = new Point(BposX[0], BposY[0]);
            Bar.Location = new Point(BposX[1], BposY[1]);
        }

        private void EndGame(object sender, EventArgs e)
        {
            Ball.Location = Spoints[0];
            Bar.Location = Spoints[1];
            Timer_Game.Enabled = false;
            Timer_Time.Enabled = false;
            GameResult gameResult = new GameResult();
            gameResult.ShowDialog();
        }

        #endregion

        #region Event Handlers

        // ---セットアップ---
        private void GameWindow_Load(object sender, EventArgs e)
        {
            Button_Start.Visible = true;
            Label_CountDown.Visible = false;
            Label_Start.Visible = false;
            Panel.Visible = false;
            SetPictureBoxProperties(Ball, 0, 3, -5);
            SetPictureBoxProperties(Bar, 1, 0, 0);
        }

        // ---スタートボタン---
        private void Button_Start_Click(object sender, EventArgs e)
        {
            Button_Start.Visible = false;
            Label_CountDown.Visible = true;
            Panel.Visible = true;

            Timer_CountDown.Enabled = true;
            Label_CountDown.Text = Convert.ToString(countdown);
        }

        // ---開始前カウントダウン---
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

        // ---主要動作---
        private void Timer_Game_Tick(object sender, EventArgs e)
        {
            CoordinateRefresh(sender, e); // ball,barの座標更新

            for (int i = 0; i < 28; i++)
            {
                // ---ブロックとの衝突,反射処理---
                if (CheckCollision(Ball, Boxes[i]))
                {
                    // ボールの中心位置
                    int ballCenterX = Ball.Left + Ball.Width / 2;
                    int ballCenterY = Ball.Top + Ball.Height / 2;

                    // ブロックの境界
                    int boxLeft = Boxes[i].Left;
                    int boxRight = Boxes[i].Right;
                    int boxTop = Boxes[i].Top;
                    int boxBottom = Boxes[i].Bottom;

                    // 衝突判定（どの面に近いかで判定）
                    int overlapLeft = Math.Abs(Ball.Right - boxLeft);
                    int overlapRight = Math.Abs(Ball.Left - boxRight);
                    int overlapTop = Math.Abs(Ball.Bottom - boxTop);
                    int overlapBottom = Math.Abs(Ball.Top - boxBottom);

                    bool collidedFromHorizontal = false;

                    // ボールの移動方向とオーバーラップを考慮して反射方向を決定
                    if (BmovX[0] > 0 && overlapLeft < overlapTop && overlapLeft < overlapBottom)
                    {
                        BmovX[0] = -BmovX[0];
                        Ball.Left = boxLeft - Ball.Width;
                        BposX[0] = Ball.Left;
                        collidedFromHorizontal = true;
                    }

                    else if (BmovX[0] < 0 && overlapRight < overlapTop && overlapRight < overlapBottom)
                    {
                        BmovX[0] = -BmovX[0];
                        Ball.Left = boxRight;
                        BposX[0] = Ball.Left;
                        collidedFromHorizontal = true;
                    }

                    else if (BmovY[0] > 0 && overlapTop < overlapLeft && overlapTop < overlapRight)
                    {
                        BmovY[0] = -BmovY[0];
                        Ball.Top = boxTop - Ball.Height;
                        BposY[0] = Ball.Top;
                    }

                    else if (BmovY[0] < 0 && overlapBottom < overlapLeft && overlapBottom < overlapRight)
                    {
                        BmovY[0] = -BmovY[0];
                        Ball.Top = boxBottom;
                        BposY[0] = Ball.Top;
                    }

                    else // 角に衝突した場合や、上記の条件に当てはまらない場合（一般的な反射）
                    {
                        if (overlapLeft < overlapRight && overlapLeft < overlapTop && overlapLeft < overlapBottom)
                        {
                            BmovX[0] = -BmovX[0];
                            Ball.Left = boxLeft - Ball.Width;
                            BposX[0] = Ball.Left;
                        }

                        else if (overlapRight < overlapLeft && overlapRight < overlapTop && overlapRight < overlapBottom)
                        {
                            BmovX[0] = -BmovX[0];
                            Ball.Left = boxRight;
                            BposX[0] = Ball.Left;
                        }

                        else if (overlapTop < overlapBottom && overlapTop < overlapLeft && overlapTop < overlapRight)
                        {
                            BmovY[0] = -BmovY[0];
                            Ball.Top = boxTop - Ball.Height;
                            BposY[0] = Ball.Top;
                        }

                        else if (overlapBottom < overlapTop && overlapBottom < overlapLeft && overlapBottom < overlapRight)
                        {
                            BmovY[0] = -BmovY[0];
                            Ball.Top = boxBottom;
                            BposY[0] = Ball.Top;
                        }

                        else
                        {
                            // どちらの面からの衝突か判断が難しい場合、Y方向を優先して反転（一般的なブレイクアウトの挙動）
                            BmovY[0] = -BmovY[0];
                        }
                    }

                    if (Boxes[i].Visible == false)
                    {
                        continue;
                    }

                    // 衝突後の処理（HP減少と色変更）
                    ChangeColor(Boxes[i], i);
                    break; // 1フレームで複数のブロックに衝突しないように、一度衝突したらループを抜ける
                }
            }

            // ---壁,バーの反射処理---
            // こちらも同様に、めり込み防止のための位置調整を追加
            if (CheckCollision(EdgeLeft, Ball))
            {
                BmovX[0] = -BmovX[0];
                Ball.Left = EdgeLeft.Right; // 左端に押し戻す
                BposX[0] = Ball.Left;
            }

            if (CheckCollision(EdgeRight, Ball))
            {
                BmovX[0] = -BmovX[0];
                Ball.Left = EdgeRight.Left - Ball.Width; // 右端に押し戻す
                BposX[0] = Ball.Left;
            }

            if (CheckCollision(EdgeTop, Ball))
            {
                BmovY[0] = -BmovY[0];
                Ball.Top = EdgeTop.Bottom; // 上端に押し戻す
                BposY[0] = Ball.Top;
            }

            if (CheckCollision(Bar, Ball))
            {
                BmovY[0] = -BmovY[0];
                // バーの動きを考慮して、ボールがバーにめり込まないように調整
                if (Ball.Bottom > Bar.Top)
                {
                    Ball.Top = Bar.Top - Ball.Height;
                    BposY[0] = Ball.Top;
                }
            }

            // ---ゲームオーバー---
            if (CheckCollision(OutZone, Ball))
            {
                EndGame(sender, e);
            }

        }

        // ---ゲーム内ティック---
        private void Timer_Time_Tick(object sender, EventArgs e)
        {
            --timer;
            Label_Time.Text = Convert.ToString(timer);
            
            // ---時間切れ---
            if (timer == 0)
            {
                EndGame(sender, e);
            }
        }

        // ---キーボード操作---
        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                BmovX[1] = -5;
            }
            else if (e.KeyCode == Keys.D)
            {
                BmovX[1] = 5;
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            BmovX[1] = 0;
        }


        #endregion
    }
}
