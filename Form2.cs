using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worlddomination
{
    public partial class Form2 : Form
    {
        private Game game; 


        public Form2(Game game) 
        {
            InitializeComponent();
            this.game = game;
            game.currentPlayerIndex = 0; // Устанавливаем начальное значение индекса
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowPlayerInfo(); // Показываем информацию о первом игроке
        }

        private void ShowPlayerInfo()
        {
            Player currentPlayer = game.GetCurrentPlayer(); // вписываем в форму значение из Playera
            PlayerName.Text = currentPlayer.name;
            CurrentRound.Text = Convert.ToString(game.current_round);
            AverageIncome.Text = Convert.ToString(currentPlayer.average_income);
            AverageLevel.Text = Convert.ToString(currentPlayer.average_level);


            

            if (currentPlayer.cities[0].LevelOfDevelopment <= 0)
            {
                City1Name.Text = currentPlayer.cities[0].Name;
                City1Level.Text = "Город уничтожен";
                City1Income.Text = "Город уничтожен";
                City1Shield.Text = "Город уничтожен";
            }
            else
            {
                City1Name.Text = currentPlayer.cities[0].Name;
                City1Level.Text = Convert.ToString(currentPlayer.cities[0].LevelOfDevelopment);
                City1Income.Text = Convert.ToString(currentPlayer.cities[0].Income);
                City1Shield.Text = Convert.ToString(currentPlayer.cities[0].Shield);
            }
            

            if (currentPlayer.cities[1].LevelOfDevelopment <= 0)
            {
                City2Name.Text = currentPlayer.cities[0].Name;
                City2Level.Text = "Город уничтожен";
                City2Income.Text = "Город уничтожен";
                City2Shield.Text = "Город уничтожен";
            }
            else
            {
                City2Name.Text = currentPlayer.cities[1].Name;
                City2Level.Text = Convert.ToString(currentPlayer.cities[1].LevelOfDevelopment);
                City2Income.Text = Convert.ToString(currentPlayer.cities[1].Income);
                City2Shield.Text = Convert.ToString(currentPlayer.cities[1].Shield);
            }
            if (currentPlayer.cities[2].LevelOfDevelopment <= 0)
            {
                City3Name.Text = currentPlayer.cities[0].Name;
                City3Level.Text = "Город уничтожен";
                City3Income.Text = "Город уничтожен";
                City3Shield.Text = "Город уничтожен";
            }
            else
            {
                City3Name.Text = currentPlayer.cities[2].Name;
                City3Level.Text = Convert.ToString(currentPlayer.cities[2].LevelOfDevelopment);
                City3Income.Text = Convert.ToString(currentPlayer.cities[2].Income);
                City3Shield.Text = Convert.ToString(currentPlayer.cities[2].Shield);
            }
            

            if (currentPlayer.cities[3].LevelOfDevelopment <= 0)
            {
                City4Name.Text = currentPlayer.cities[0].Name;
                City4Level.Text = "Город уничтожен";
                City4Income.Text = "Город уничтожен";
                City4Shield.Text = "Город уничтожен";
            }
            else
            {
                City4Name.Text = currentPlayer.cities[3].Name;
                City4Level.Text = Convert.ToString(currentPlayer.cities[3].LevelOfDevelopment);
                City4Income.Text = Convert.ToString(currentPlayer.cities[3].Income);
                City4Shield.Text = Convert.ToString(currentPlayer.cities[3].Shield);
            }

            Bombs.Text = Convert.ToString(currentPlayer.bombs_count);

            if(currentPlayer.cities[0].Shield == true)
            {
               City1MakeShield.Enabled = false;
            }
            else
            {
                City1MakeShield.Enabled = true;
            }
            if (currentPlayer.cities[1].Shield == true)
            {
                City2MakeShield.Enabled = false;
            }
            else
            {
                City2MakeShield.Enabled = true;
            }
            if (currentPlayer.cities[2].Shield == true)
            {
                City3MakeShield.Enabled = false;
            }
            else
            {
                City3MakeShield.Enabled = true;
            }
            if (currentPlayer.cities[3].Shield == true)
            {
                City4MakeShield.Enabled = false;
            }
            else
            {
                City4MakeShield.Enabled = true;
            }


        }

        private void NextPlayer_Click(object sender, EventArgs e)
        {
            if (game.currentPlayerIndex < game.Players.Count - 1) // Проверяем, не вышли ли за пределы списка игроков
            {

                game.NextRoundEvent();
                game.currentPlayerIndex++; // Увеличиваем индекс
                ShowPlayerInfo(); // Показываем информацию о следующем игроке
                City1Upgrade.Enabled = true;
                City2Upgrade.Enabled = true;
                City3Upgrade.Enabled = true;
                City4Upgrade.Enabled = true;
            }
            else
            {
                if(game.current_round + 1 > 6)
                {
                    MessageBox.Show($"Победитель: {game.GetWinner().name}");

                    MessageBox.Show("Игра окончена");
                }
                else
                {
                    game.NextRoundEvent();
                    game.current_round += 1;

                    game.currentPlayerIndex = 0;
                    foreach (Control control in this.Controls)
                    {
                        // Проверяем, является ли контрол кнопкой
                        if (control is Button button)
                        {
                            control.Enabled = true;
                        }
                    }

                    
                    ShowPlayerInfo();
                    City1Upgrade.Enabled = true;
                    City2Upgrade.Enabled = true;
                    City3Upgrade.Enabled = true;
                    City4Upgrade.Enabled = true;
                }
            }
        }

        private void City1Upgrade_Click(object sender, EventArgs e)
        {
            if (game.CityUpgrade(0))
            {
                ShowPlayerInfo();
                City1Upgrade.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
            
        }

        private void City2Upgrade_Click(object sender, EventArgs e)
        {

            if (game.CityUpgrade( 1))
            {
                ShowPlayerInfo();
                City2Upgrade.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void City3Upgrade_Click(object sender, EventArgs e)
        {
            if (game.CityUpgrade(2))
            {
                ShowPlayerInfo();
                City3Upgrade.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void City4Upgrade_Click(object sender, EventArgs e)
        {

            if (game.CityUpgrade(3))
            {
                ShowPlayerInfo();
                City4Upgrade.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void City1MakeShield_Click(object sender, EventArgs e)
        {

            if (game.CityMakeShield(0))
            {
                ShowPlayerInfo();
                City1MakeShield.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void City2MakeShield_Click(object sender, EventArgs e)
        {

            if (game.CityMakeShield(1))
            {
                ShowPlayerInfo();
                City2MakeShield.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }

        }

        private void City3MakeShield_Click(object sender, EventArgs e)
        {

            if (game.CityMakeShield(2))
            {
                ShowPlayerInfo();
                City3MakeShield.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void City4MakeShield_Click(object sender, EventArgs e)
        {
            if (game.CityMakeShield(3))
            {
                ShowPlayerInfo();
                City4MakeShield.Enabled = false;
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void CreateBombButton_Click(object sender, EventArgs e)
        {
            if (game.CreateBomb())
            {
                MessageBox.Show("Вы запустили производство, бомба появится в следующем раунде.");
                ShowPlayerInfo();
            }
            else
            {
                MessageBox.Show("Недостаточно средств");
            }
        }

        private void ThrowBomb_Click(object sender, EventArgs e)
        {
            var player_name = BombPlayer.Text;
            var city_name = BombCity.Text;

            switch(game.ThrowBomb(player_name, city_name))
            {
                case -1:
                    MessageBox.Show("Город не был найден");
                    break;
                case 0:
                    MessageBox.Show("Вы сняли щит");
                    break;
                case 1:
                    MessageBox.Show("Вы уничтожили город");
                    break;
                case 2:
                    MessageBox.Show("Вы уничтожили часть города");
                    break;
            }
        }   
            
    }

}
