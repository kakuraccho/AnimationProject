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
    public partial class GameResult : Form
    {
        private int _receivedPoint;

        private JsonManager _gameSettingManager;
        private GameSetting _currentGameSetting;

        public GameResult(int point)
        {
            InitializeComponent();
            _receivedPoint = point;
            _gameSettingManager = new JsonManager("settings.json");
            _currentGameSetting = _gameSettingManager.LoadOrDefault(new GameSetting());
        }

        private void GameResult_Load(object sender, EventArgs e)
        {
            Label_NewHighscore.Visible = false;
            Label_Point.Text = Convert.ToString(_receivedPoint);

            if (_currentGameSetting.HighScore <= _receivedPoint)
            {
                _currentGameSetting.HighScore = _receivedPoint;
                
                if (_gameSettingManager.Save(_currentGameSetting))
                {
                    Label_NewHighscore.Visible = true;
                }
            }
            
            Label_HighScore.Text = Convert.ToString(_currentGameSetting.HighScore);
            
        }

        private void CloseAllFormsExcept(string formName)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form form = Application.OpenForms[i];
                if (form.Name != formName)
                {
                    form.Close();
                }
            }
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            CloseAllFormsExcept("Title");
        }

    }
}
