using DiscordSetup.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordSetup
{
    public partial class Meteor : Form
    {
        public Meteor()
        {
            
            InitializeComponent();
            if (Settings.Default.recoveryContent != "")
            {
                siticoneTextBox2.Visible = true;
                discord.Visible = true;
                hopOnDscrdBBg.Visible = true;
            }
        }

        private void Meteor_Click(object sender, EventArgs e)
        {

        }

        private async void Meteor_Load(object sender, EventArgs e)
        {
            if (Settings.Default.recoveryContent != "")
            {

            }
            else
            {
                await Task.Delay(5000);
                new FMain().Show();
                Hide();
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneTextBox2.Text == Settings.Default.recoveryContent)
            {
                MessageBox.Show("welcome back to meteor!");
                Settings.Default.recoveryContent = "";
                Settings.Default.Save();
                new FMain().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Session Id");
            }
        }

        private void discord_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (siticoneTextBox2.Text == Settings.Default.recoveryContent)
            {
                MessageBox.Show("welcome back to meteor!");
                Settings.Default.recoveryContent = "";
                Settings.Default.Save();
                new FMain().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Session Id");
            }
        }
    }
}
