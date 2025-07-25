﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private enum KeyBindingState // 入力待ちの状態管理
        {
            None,
            WaitingForRightKey,
            WaitingForLeftKey
        }

        private KeyBindingState _currentKeyBindingState = KeyBindingState.None;
        private Label _activeKeyLabel = null;

        public Config()
        {
            InitializeComponent();
            _gameSettingsManager = new JsonManager("settings.json"); // jsonファイル名を指定
        }

        #region Method

        private void SetVariablesFromJson()
        {
            Label_BallValue.Text = Convert.ToString(_currentGameSetting.BallSpeed);
            TrackBar_Ball.Value = _currentGameSetting.BallSpeed;
            Label_BarValue.Text = Convert.ToString(_currentGameSetting.BarRange);
            TrackBar_Bar.Value = _currentGameSetting.BarRange;
            Label_SEValue.Text = Convert.ToString(_currentGameSetting.SeVolume);
            TrackBar_SE.Value = _currentGameSetting.SeVolume; 
            Label_RightKey.Text = _currentGameSetting.RightKey;
            Label_LeftKey.Text = _currentGameSetting.LeftKey;
        }


        private void ResetJsonValues()
        {
            _currentGameSetting = new GameSetting();
            SetVariablesFromJson();
        }

        private void ResetKeyBindingState()
        {
            if (_activeKeyLabel != null)
            {
                _activeKeyLabel.BackColor = SystemColors.Control; // 背景色を戻す

                if (_currentKeyBindingState == KeyBindingState.WaitingForRightKey) 
                {
                    Label_RightKey.Text = _currentGameSetting.RightKey;
                }
                else if (_currentKeyBindingState == KeyBindingState.WaitingForLeftKey)
                {
                    Label_LeftKey.Text = _currentGameSetting.LeftKey;
                }
            }
            _currentKeyBindingState = KeyBindingState.None; // 状態をリセット
            _activeKeyLabel = null; // 参照をクリア
        }

        #endregion

        #region Event Handlers
        private void Config_Load(object sender, EventArgs e)
        {
            // jsonからロード,代入
            _currentGameSetting = _gameSettingsManager.LoadOrDefault(new GameSetting());
            SetVariablesFromJson();
        }

        // ---TrackBarの値が変わった時---
        private void TrackBar_Move_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.BallSpeed = TrackBar_Ball.Value;
            Label_BallValue.Text = Convert.ToString(TrackBar_Ball.Value);
        }

        private void TrackBar_Bar_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.BarRange = TrackBar_Bar.Value;
            Label_BarValue.Text = Convert.ToString(TrackBar_Bar.Value);
        }

        private void TrackBar_SE_ValueChanged(object sender, EventArgs e)
        {
            _currentGameSetting.SeVolume = TrackBar_SE.Value;
            Label_SEValue.Text = Convert.ToString(TrackBar_SE.Value);
        }

        // キーバインドの変更

        private void Config_KeyDown(object sender, KeyEventArgs e)
        {
            if (_currentKeyBindingState != KeyBindingState.None)
            {
                string newKeyString = Convert.ToString(e.KeyCode);

                if (_currentKeyBindingState == KeyBindingState.WaitingForRightKey)
                {
                    _currentGameSetting.RightKey = newKeyString;
                    Label_RightKey.Text = newKeyString;
                }
                else if (_currentKeyBindingState == KeyBindingState.WaitingForLeftKey)
                {
                    _currentGameSetting.LeftKey = newKeyString;
                    Label_LeftKey.Text = newKeyString;
                }
                SetVariablesFromJson();
                ResetKeyBindingState();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Button_RChange_Click(object sender, EventArgs e)
        {
            ResetKeyBindingState();

            _currentKeyBindingState = KeyBindingState.WaitingForRightKey;
            _activeKeyLabel = Label_RightKey;

            _activeKeyLabel.Text = "...";
            _activeKeyLabel.BackColor = Color.LightYellow;
        }

        private void Button_LChange_Click(object sender, EventArgs e)
        {
            ResetKeyBindingState();

            _currentKeyBindingState= KeyBindingState.WaitingForLeftKey;
            _activeKeyLabel = Label_LeftKey;

            _activeKeyLabel.Text = "...";
            _activeKeyLabel.BackColor = Color.LightYellow;
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
            ResetJsonValues();
            
        }

        #endregion
    }
}
