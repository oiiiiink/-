using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw.TryToGuess
{
    public class ControlsDepartment
    {
        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                if (value < 0) { throw new Exception("You lose."); }
                else { score = value; }
            }
        }
        public ControlsDepartment()
        {
           
        }

        public int ScoreCounter(int score, bool answer) 
        {
            if (answer)
            {
                try
                {
                    Score = ++score;
                    
                }
                catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
                
                return Score;
            } else
            {
    
                try { Score = --score; }
                catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }

                return Score;
            }
        }
        public int GameControllerChangeLocation(int score, bool side, bool rightSide, // сторона правильного ответа 
            System.Windows.Forms.PictureBox gameController, System.Windows.Forms.Label minusPlusScore) //функция на изменение локации 
        {
            if (side) //  если слева 
            {
                gameController.Location = new Point(90, gameController.Location.Y);

                if (gameController.Location.X == 90 && rightSide)
                {
                    gameController.Location = new Point(110, gameController.Location.Y);

                    minusPlusScore.ForeColor = Color.Green;
                    minusPlusScore.Text = "+1";

                    return ScoreCounter(score, true);
                }
                else if (gameController.Location.X == 90 && !rightSide)
                {
                    gameController.Location = new Point(110, gameController.Location.Y);

                    minusPlusScore.ForeColor = Color.Red;
                    minusPlusScore.Text = "-1";

                    return ScoreCounter(score, false);
                }
                return score;
            }
            else // если справа 
            {
                gameController.Location = new Point(130, gameController.Location.Y);

                if (gameController.Location.X == 130 && !rightSide)
                {
                    gameController.Location = new Point(110, gameController.Location.Y);

                    minusPlusScore.ForeColor = Color.Green;
                    minusPlusScore.Text = "+1";

                    return ScoreCounter(score, true);
                }
                else if (gameController.Location.X == 130 && rightSide)
                {
                    gameController.Location = new Point(110, gameController.Location.Y);

                    minusPlusScore.ForeColor = Color.Red;
                    minusPlusScore.Text = "-1";

                    return ScoreCounter(score, false);
                }

                return score;
            }
        }
    }
}
