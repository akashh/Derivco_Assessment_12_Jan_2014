using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Derivco_12_Jan_2014
{
    public partial class NewRandomMovie : Form
    {

        int Player1Score, Player2Score = 0;

        public NewRandomMovie()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to the Movie Night Trivia Game!" + "\n" +
            "This game consists of two players." + "\n" 
            + "Good Luck!");
            
            Random random = new Random();
            string RandomMovie = (MovieList[random.Next(20)]);
            movie.Text = RandomMovie.ToString();
            ScorePlayer1.Text = "0";
            ScorePlayer2.Text = "0";
        }

        public void ResetGame()
        {
            Random random = new Random();
            string RandomMovie = (MovieList[random.Next(20)]);
            movie.Text = RandomMovie.ToString();
            PlayerAnswer.Text = "";
        }               

        string[] MovieList = new string[20]
        {                                  //years in comments as per imdb
            "The Shawshank Redemption",                             //1994
            "The Godfather",                                        //1972
            "The Godfather : Part 2",                               //1974
            "Pulp Fiction",                                         //1994
            "The Dark Knight",                                      //2008
            "The Good, the Bad and the Ugly",                       //1966
            "12 Angry Men",                                         //1957
            "Schindler's List",                                     //1993
            "The Lord of the Rings : The Return of the King",       //2003
            "Fight Club",                                           //1999
            "The Lord of the Rings : The Fellowship of the Ring",   //2001
            "Star Wars : Episode V - The Empire Strikes Back",      //1980
            "Inception",                                            //2010
            "One Flew Over the Cuckoo's Nest",                      //1975
            "Forrest Gump",                                         //1994
            "Goodfellas",                                           //1990
            "The Lord of the Rings : The Two Towers",               //2002
            "Star Wars : Episode IV - A New Hope",                  //1977
            "The Matrix",                                           //1999
            "Seven Samurai",                                        //1974
        };

        private void movie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string RandomMovie = (MovieList[random.Next(20)]);
            movie.Text = RandomMovie.ToString();
        }

        private void PlayerAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        int rounds = 1;

        private void submitAnswerPlayer1_Click(object sender, EventArgs e)
        {
            if (rounds <= 8)
            {
                if ((PlayerAnswer.Text == "1994") && (movie.Text == "The Shawshank Redemption"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    Player1Score += 5;
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1972") && (movie.Text == "The Godfather"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1974") && (movie.Text == "The Godfather : Part 2"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1994") && (movie.Text == "Pulp Fiction"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "2008") && (movie.Text == "The Dark Knight"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1966") && (movie.Text == "The Good, the Bad and the Ugly"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1957") && (movie.Text == "12 Angry Men"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1993") && (movie.Text == "Schindler's List"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "2003") && (movie.Text == "The Lord of the Rings : The Return of the King"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1999") && (movie.Text == "Fight Club"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "2001") && (movie.Text == "The Lord of the Rings : The Fellowship of the Ring"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1980") && (movie.Text == "Star Wars : Episode V - The Empire Strikes Back"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "2010") && (movie.Text == "Inception"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1975") && (movie.Text == "One Flew Over the Cuckoo's Nest"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1994") && (movie.Text == "Forrest Gump"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1990") && (movie.Text == "Goodfellas"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "2002") && (movie.Text == "The Lord of the Rings : The Two Towers"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1977") && (movie.Text == "Star Wars : Episode IV - A New Hope"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1999") && (movie.Text == "The Matrix"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else if ((PlayerAnswer.Text == "1974") && (movie.Text == "Seven Samurai"))
                {
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                    Player1Score += 5;
                }
                else
                {
                    MessageBox.Show("Sorry you loose 3 points");
                    rounds++;
                    Player1Score -= 3;
                }
            }
            else
            {
                MessageBox.Show("Game Over!");
                if (Player1Score > Player2Score)
                    MessageBox.Show("Player 1 Wins! ");
                    else if (Player1Score == Player2Score)
                        MessageBox.Show("Draw! ");
                MessageBox.Show("A New Game Starts Automatically");
                ResetGame();
                rounds = 1;
                Player1Score = 0;
                ScorePlayer1.Text = "0";
                Player2Score = 0;
                ScorePlayer2.Text = "0";
            }//Main if closing brace
            ScorePlayer1.Text = Player1Score.ToString();
        }

        private void submitAnswerPlayer2_Click(object sender, EventArgs e)
        {
            if (rounds <= 8)
            {
                if ((PlayerAnswer.Text == "1994") && (movie.Text == "The Shawshank Redemption"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1972") && (movie.Text == "The Godfather"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1974") && (movie.Text == "The Godfather : Part 2"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1994") && (movie.Text == "Pulp Fiction"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "2008") && (movie.Text == "The Dark Knightn"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1966") && (movie.Text == "The Good, the Bad and the Ugly"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1957") && (movie.Text == "12 Angry Men"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1993") && (movie.Text == "Schindler's List"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "2003") && (movie.Text == "The Lord of the Rings : The Return of the King"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1999") && (movie.Text == "Fight Club"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "2001") && (movie.Text == "The Lord of the Rings : The Fellowship of the Ring"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1980") && (movie.Text == "Star Wars : Episode V - The Empire Strikes Back"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "2010") && (movie.Text == "Inception"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1975") && (movie.Text == "One Flew Over the Cuckoo's Nest"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1994") && (movie.Text == "Forrest Gump"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1990") && (movie.Text == "Goodfellas"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "2002") && (movie.Text == "The Lord of the Rings : The Two Towers"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1977") && (movie.Text == "Star Wars : Episode IV - A New Hope"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1999") && (movie.Text == "The Matrix"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else if ((PlayerAnswer.Text == "1974") && (movie.Text == "Seven Samurai"))
                {
                    Player2Score += 5;
                    MessageBox.Show("Correct + 5 Points! ");
                    ResetGame();
                    rounds++;
                }
                else
                {
                    MessageBox.Show("Sorry you loose 3 points");
                    Player2Score -= 3;
                    rounds++;
                }
            }
            else
            {
                MessageBox.Show("Game Over!");
                if (Player2Score > Player1Score)
                    MessageBox.Show("Player 2 Wins! ");
                    else if (Player2Score == Player1Score)
                        MessageBox.Show("Draw! ");
                MessageBox.Show("A New Game Starts Automatically");
                ResetGame();
                rounds = 1;
                Player2Score = 0;
                ScorePlayer2.Text = "0";
                Player1Score = 0;
                ScorePlayer1.Text = "0";
            }//Main if closing brace            
            ScorePlayer2.Text = Player2Score.ToString();
        }


        private void ScorePlayer1_Click(object sender, EventArgs e)
        {
            //ScorePlayer1.Text = Player1Score.ToString();
        }

        private void ScorePlayer2_Click(object sender, EventArgs e)
        {
            //ScorePlayer2.Text = Player2Score.ToString();
        }   
        
    }
}
