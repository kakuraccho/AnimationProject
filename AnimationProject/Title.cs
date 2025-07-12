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
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            this.Hide();
            gameWindow.ShowDialog();
            this.Show();
        }

        private void Button_modechange_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            this.Hide();
            config.ShowDialog();
            this.Show();
        }
    }
}
