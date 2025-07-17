using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationProject
{
    public partial class Config : Form
    {
        private JsonManager _gameSettingsManager;
        private GameSetting _currentGameSetting;

        int movevalue, barvalue, sevalue;

        public Config()
        {
            InitializeComponent();
            _gameSettingsManager = new JsonManager("settings.json"); // jsonファイル名を指定
        }

        private void Config_Load(object sender, EventArgs e)
        {
            // jsonからロード,代入
            _currentGameSetting = _gameSettingsManager.LoadOrDefault(new GameSetting());
            movevalue = _currentGameSetting.MoveSpeed;
            barvalue = _currentGameSetting.BarSpeed;
            sevalue = _currentGameSetting.SeVolume;

            // 結果を出力
            Label_MoveValue.Text = Convert.ToString(movevalue);
            TrackBar_Move.Value = movevalue;
            Label_BarValue.Text = Convert.ToString(barvalue);
            TrackBar_Bar.Value = barvalue;
            Label_SEValue.Text = Convert.ToString(sevalue);
            TrackBar_SE.Value = sevalue;

        }

        // ---TrackBarの値が変わった時---
        private void TrackBar_Move_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.MoveSpeed = TrackBar_Move.Value;
            Label_MoveValue.Text = TrackBar_Move.Value.ToString();
        }

        private void TrackBar_Bar_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.BarSpeed = TrackBar_Bar.Value;
            Label_BarValue.Text = TrackBar_Bar.Value.ToString();
        }

        private void TrackBar_SE_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.SeVolume = TrackBar_SE.Value;
            Label_SEValue.Text = TrackBar_SE.Value.ToString();
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            _currentGameSetting.MoveSpeed = _currentGameSetting.StnMoveSpeed;
            _currentGameSetting.BarSpeed = _currentGameSetting.StnSpeed;
            _currentGameSetting.SeVolume = _currentGameSetting.StnSeVolume;
            Label_MoveValue.Text = TrackBar_Move.Value.ToString();
            Label_BarValue.Text = TrackBar_Bar.Value.ToString();
            Label_SEValue.Text = TrackBar_SE.Value.ToString();
        }

        private async void Button_Save_Click(object sender, EventArgs e)
        {
            // 現在の_currentGameSetting オブジェクトをJSONファイルに保存
            if (_gameSettingsManager.Save(_currentGameSetting))
            {
                Label_SvCol.Visible = true;
                await Task.Delay(1000);
                Label_SvCol.Visible = false;
                this.Close();
            }
        }

        private void Button_Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
