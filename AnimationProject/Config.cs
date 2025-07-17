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
    public partial class Config : Form
    {

        // 設定値の配列
        int[] movevalue = new int[2];
        int[] barvalue = new int[2];
        int[] sevalue = new int[2];

        public Config()
        {
            InitializeComponent();
        }

        public class GameSetting
        {
            
        }

        private void Config_Load(object sender, EventArgs e)
        {
            // 変数代入
            // value[1]は初期値を表す
            for (int i = 0; i < 1; i++)
            {
                movevalue[i] = 5;
                barvalue[i] = 1;
                sevalue[i] = 5;
            }            
        }

        private void TrackBar_Move_ValueChanged(object sender, EventArgs e)
        {
            movevalue[0] = TrackBar_Move.Value;
            Label_MoveValue.Text = Convert.ToString(movevalue);
        }

        private void TrackBar_Bar_ValueChanged(object sender, EventArgs e)
        {
            barvalue[0] = TrackBar_Bar.Value;
            Label_BarValue.Text = Convert.ToString(barvalue);
        }

        private void TrackBar_SE_ValueChanged(object sender, EventArgs e)
        {
            sevalue[0] = TrackBar_SE.Value;
            Label_SEValue.Text = Convert.ToString(sevalue);
        }

    }
}
