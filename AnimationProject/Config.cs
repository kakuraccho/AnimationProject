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

        // jsonからの値
        int ballvalue, barvalue, sevalue;
        int Sballvalue, Sbarvalue, Ssevalue;
        string rightkey, leftkey;
        string Srightkey, Sleftkey;

        public Config()
        {
            InitializeComponent();
            _gameSettingsManager = new JsonManager("settings.json"); // jsonファイル名を指定
        }

        #region Method

        private void SetVariablesFromJson (object sender, EventArgs e)
        {
            ballvalue = _currentGameSetting.BallSpeed;
            barvalue = _currentGameSetting.BarSpeed;
            sevalue = _currentGameSetting.SeVolume;
            
            Sballvalue = _currentGameSetting.StnBallSpeed;
            Sbarvalue = _currentGameSetting.StnBarSpeed;
            Ssevalue = _currentGameSetting.StnSeVolume;

            rightkey = _currentGameSetting.RightKey;
            leftkey = _currentGameSetting.LeftKey;

            Srightkey = _currentGameSetting.StnRightKey;
            Sleftkey = _currentGameSetting.StnLeftKey;
        }

        private void SetVariablesToControl (object sender, EventArgs e)
        {
            Label_MoveValue.Text = Convert.ToString(ballvalue);
            TrackBar_Move.Value = ballvalue;
            Label_BarValue.Text = Convert.ToString(barvalue);
            TrackBar_Bar.Value = barvalue;
            Label_SEValue.Text = Convert.ToString(sevalue);
            TrackBar_SE.Value = sevalue;
        }

        private void ResetJsonValues (object sender, EventArgs e)
        {
            _currentGameSetting.BallSpeed = Sballvalue;
            _currentGameSetting.BarSpeed = Sbarvalue;
            _currentGameSetting.SeVolume = Ssevalue;
            _currentGameSetting.RightKey = Srightkey;
            _currentGameSetting.LeftKey = Sleftkey;
            SetVariablesFromJson (sender, e);
        }

        #endregion

        #region Event Handlers
        private void Config_Load(object sender, EventArgs e)
        {
            // jsonからロード,代入
            _currentGameSetting = _gameSettingsManager.LoadOrDefault(new GameSetting());
            SetVariablesFromJson(sender, e);

            // 結果を出力
            SetVariablesToControl(sender, e);

        }

        // ---TrackBarの値が変わった時---
        private void TrackBar_Move_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.BallSpeed = TrackBar_Move.Value;
            Label_MoveValue.Text = Convert.ToString(TrackBar_Move.Value);
        }

        private void TrackBar_Bar_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.BarSpeed = TrackBar_Bar.Value;
            Label_BarValue.Text = Convert.ToString(TrackBar_Bar.Value);
        }

        private void TrackBar_SE_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.SeVolume = TrackBar_SE.Value;
            Label_SEValue.Text = Convert.ToString(TrackBar_SE.Value);
        }

        // キーバインドの変更
        private void Button_RChange_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_LChange_Click(object sender, EventArgs e)
        {

        }


        // ---保存,キャンセル,リセット---
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

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            // 
            ResetJsonValues (sender, e);
            // jsonの値を反映
            SetVariablesToControl(sender, e);
        }

        #endregion
    }
}
