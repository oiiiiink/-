using cw.TryToGuess.GameScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw.TryToGuess
{
    public partial class TryToGuess_GameScreen : Form
    {
        ControlsDepartment controls = new ControlsDepartment();
 
        Database database;
        DatabaseActions dbActions; //класс

        public TryToGuess_GameScreen(Database database, DatabaseActions dbActions) // передаём эти классы, что в скобках
        {
            this.database = database;    // конструктор 
            this.dbActions = dbActions;

            InitializeComponent();
        }

        private int level = 1, time, Score = 0, difficulty = 4;
        private bool rightSide;

        private string items;

        private void TryToGuess_GameScreen_Load(object sender, EventArgs e) // функция из форм, TryToGuess_GameScreen_Load выполняется когда запуск форм
        {
            LoadForm();

            //TimerStart(4);
        }

        private void LoadForm()
        {
            level = 1;
            TimeRem.Text = "TIME: none"; //текст на форму
            ScoreLabel.Text = "SCORE: 0"; //текст на форму 
            difficultyTextBox.Visible = false;
            controlsLabel.Visible = false;
            label1.Visible = false;

            ChangeCategoryName();

            minusPlus.Visible = GameController.Visible = firstCategory.Visible =
                secondCategory.Visible = ScoreLabel.Visible = TimeRem.Visible = false;

            this.rightSide = dbActions.rightSide;
        }

        private void ChangeCategoryName()
        {
            firstCategory.Text = secondCategory.Text = " ";

            bool labelIdent = true;

            for (int z = 0; z < dbActions.LevelName.Count(); z++)
            {
                char[] labelInfo = dbActions.LevelName[z].ToCharArray(); // поделит строки по одной букве в массив char 

                if (labelIdent)
                {
                    for (int x = 0; x < labelInfo.Count(); x++)
                    {
                        secondCategory.Text = secondCategory.Text + "\n" + labelInfo[x];
                    }

                    labelIdent = false;
                }
                else
                {
                    for (int x = 0; x < labelInfo.Count(); x++)
                    {
                        firstCategory.Text = firstCategory.Text + "\n" + labelInfo[x];
                    }
                }
            }
        } 

        private void TryToGuess_Load()
        {
            items = dbActions.ChooseItemsToCompare();

            this.rightSide = dbActions.rightSide;
            GameController.BackgroundImage = new Bitmap(items);

            TimerStart(difficulty);
        }

        private bool IsScoreChange(int first, int second)
        {
            if (first == second)
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void TryToGuess_GameScreen_KeyDown(object sender, KeyEventArgs e) //взаимодействие с клавиатурой 
        {
            if (e.KeyValue == (char)Keys.Left) // левая кнопка 
            {
                controlsLabel_Click(sender, e);
            } else if (e.KeyValue == (char)Keys.Right) // правая кнопка 

            {
                label1_Click(sender, e);
            }
        }

        private void startButton_Click(object sender, EventArgs e) //кнопка старта 
        {
            Start();
        }

        private void Start()
        {
            startButton.Visible = settingButton.Visible = recordsButton.Visible = !startButton.Visible;
            minusPlus.Visible = GameController.Visible = firstCategory.Visible =
                secondCategory.Visible = ScoreLabel.Visible = TimeRem.Visible
                = controlsLabel.Visible = label1.Visible = !startButton.Visible;

            if (!startButton.Visible) //если кнопка старт не видна, то он запускает 
            {
                TryToGuess_Load();
            }
        }

        private void controlsLabel_Click(object sender, EventArgs e)
        {
            int scoreCheck = Score;
            Score = controls.GameControllerChangeLocation(Score, true, rightSide, GameController, minusPlus);
            if (Score == 30)
            {
                GetScore();
                return;
            }
            ScoreLabel.Text = "SCORE: " + Score.ToString();
            if (Score == dbActions.ScoreToUnlock)
            {
                minusPlus.Text = "NEW LVL!"; minusPlus.ForeColor = Color.Green;
                level = ++level;
                dbActions.CategoryUpload(level);
                ChangeCategoryName();
                TryToGuess_Load();
            } else if (Score == -1)
            {
                this.Hide();
            }
            else if (IsScoreChange(scoreCheck, Score))
            {
                TryToGuess_Load();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int scoreCheck = Score;
            Score = controls.GameControllerChangeLocation(Score, false, rightSide, GameController, minusPlus);
            if (Score == 30)
            {
                GetScore();
                return;
            }
            ScoreLabel.Text = "SCORE: " + Score.ToString();
            if (Score == dbActions.ScoreToUnlock)
            {
                minusPlus.Text = "NEW LVL!"; minusPlus.ForeColor = Color.Green;
                level = ++level;
                dbActions.CategoryUpload(level);
                ChangeCategoryName();
                TryToGuess_Load();
            }
            else if (IsScoreChange(scoreCheck, Score))
            {
                TryToGuess_Load();
            }
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            XML xml = new XML();
            ScoreTable scoreTable = new ScoreTable(xml.UserDeserialize("users.xml"), Score, level, 0);
            scoreTable.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            difficultyTextBox.Visible = !difficultyTextBox.Visible;

            if (!difficultyTextBox.Visible & difficultyTextBox.Text.ToString() != String.Empty)
            {
                difficulty = Convert.ToInt32(difficultyTextBox.Text);
            } 
        }

        private void TimerStart(int interval) // таймер
        {
            time = interval;
            Timer.Interval = 1000;
            Timer.Enabled = true;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time = --time; // отнимет 1
            TimeRem.Text = "TIME: " + time.ToString();
            if (time <= 0)
            {
                startButton_Click(sender, e);
                Timer.Stop();
                GetScore();
            }
        }

        private void GetScore()
        {
            Start();
            Timer.Stop();
            this.Hide();
            XML xml = new XML();
            ScoreTable scoreTable = new ScoreTable(xml.UserDeserialize("users.xml"), Score, level, 1);
            scoreTable.FormClosed += (object s, FormClosedEventArgs ev) => { LoadForm(); this.Show(); };
            level = 1;
            controls.Score = Score = 0;
            dbActions.CategoryUpload(level);
            scoreTable.Show();
        }

    }
}
