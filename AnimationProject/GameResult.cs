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
        public GameResult()
        {
            InitializeComponent();
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

        private void GameResult_Load(object sender, EventArgs e)
        {

        }
    }
}
