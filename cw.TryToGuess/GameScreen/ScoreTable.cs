using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw.TryToGuess.GameScreen
{
    public partial class ScoreTable : Form
    {
        private int trr = 1;
        User[] data;
        public ScoreTable(User[] user, int score, int lvl, int trr)
        {
            this.data = user;
            InitializeComponent();

            scoreTextBox.Text = score.ToString();
            levelTextBox.Text = lvl.ToString();

            if (trr == 0)
                addButton.Enabled = false;
            else
                addButton.Enabled = true;
        }

        private void ScoreTable_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach(User users in data)
            {
                string[] row = {
                    users.BestScore.ToString(),
                    users.Username.ToString(),
                    users.Level.ToString(),
                    users.dateTime.ToString()
                };

                listView1.Items.Add(new ListViewItem(row));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (username.Text == String.Empty)
            {
                return;
            } else
            {
                List<User> usrs = data.ToList();
                usrs.Add(new User(username.Text, Convert.ToInt32(scoreTextBox.Text), Convert.ToInt32(levelTextBox.Text)));
                data = usrs.ToArray();

                XML xml = new XML();
                xml.UserSerializer(data, "users.xml");

                ScoreTable_Load(sender, e);

                addButton.Enabled = !addButton.Enabled;
            }
        }
    }
}
