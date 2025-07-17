using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimationProject;

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
            _gameSettingsManager = new JsonManager("settings.json"); // 設定ファイル名を指定
        }

        private void Config_Load(object sender, EventArgs e)
        {
            _currentGameSetting = _gameSettingsManager.LoadOrDefault(new GameSetting()); // 設定をロード
            movevalue = _currentGameSetting.MoveSpeed;
            barvalue = _currentGameSetting.BarSpeed;
            sevalue = _currentGameSetting.SeVolume;

            Label_MoveValue.Text = Convert.ToString(movevalue);
            Label_BarValue.Text = Convert.ToString(barvalue);
            Label_SEValue.Text = Convert.ToString(sevalue);
        }            

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

        /// <summary>
        /// Saveボタンがクリックされたときのイベントハンドラ。
        /// 現在の設定内容をJSONファイルに保存し、フォームを閉じます。
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            // 現在の _currentGameSetting オブジェクトをJSONファイルに保存
            if (_gameSettingsManager.Save(_currentGameSetting))
            {
                MessageBox.Show("設定が保存されました！", "保存完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // ダイアログの結果をOKに設定してフォームを閉じる
            }
        }

        /// <summary>
        /// Cancelボタンがクリックされたときのイベントハンドラ。
        /// 設定を保存せずにフォームを閉じます。
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void Button_Cansel_Click(object sender, EventArgs e)
        {
            // 変更を保存せずにフォームを閉じる
            this.DialogResult = DialogResult.Cancel; // ダイアログの結果をCancelに設定してフォームを閉じる
        }
    }
}
