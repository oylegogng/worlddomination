using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worlddomination
{
    public class Game
    {
        public static int default_level = 20; // начальное развитие
        public static int default_income = 100; // начальный доход
        public static int rounds_limit = 6; // лимит раундов
        public static int shield_cost = 120; // цена щита
        public static int upgrade_cost = 250; // цена улучшения города
        public static int bomb_cost = 350; // цена создания бомбы
         
        public static int damage = 30; // урон

        public int current_round; // текущий раунд
        public List<Player> Players; // список игроков
        public int currentPlayerIndex; // текущий игрок

        // реалезация паттерна одиночка

        public Game() 
        {
            this.Players = new List<Player>();
            this.current_round = 1;
        }

        private static Game instance;

        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }

        
        // добавление игрока
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        
        // выполнение событий по окончанию раунда
        public void NextRoundEvent()
        {
            this.Players[currentPlayerIndex].average_income += this.Players[currentPlayerIndex].AverageIncomeSum();
            this.Players[currentPlayerIndex].average_level += this.Players[currentPlayerIndex].AverageLevelSum();
            if(this.Players[currentPlayerIndex].create_bomb)
            {
                this.Players[currentPlayerIndex].bombs_count++;
                this.Players[currentPlayerIndex].create_bomb = false;
            }
        }


        // улучшение города
        public bool CityUpgrade(int currentCityIndex)
        {
            if (this.Players[currentPlayerIndex].average_income >= Game.upgrade_cost)
            {
                this.Players[currentPlayerIndex].cities[currentCityIndex].SetUpgrade();
                this.Players[currentPlayerIndex].average_income -= Game.upgrade_cost;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //создание щита для города
        public bool CityMakeShield(int currentCityIndex)
        {
            if (this.Players[currentPlayerIndex].average_income >= Game.shield_cost)
            {
                this.Players[currentPlayerIndex].cities[currentCityIndex].SetShield();
                this.Players[currentPlayerIndex].average_income -= Game.shield_cost;
                return true;
            }
            else
            {
                return false;
            }
        }
        // создание бомбы
        public bool CreateBomb()
        {
            if (this.Players[currentPlayerIndex].average_income >= Game.bomb_cost)
            {
                this.Players[currentPlayerIndex].average_income -= Game.bomb_cost;
                this.Players[currentPlayerIndex].create_bomb = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        // запуск бомбы
        public int ThrowBomb(string player_name, string city_name)
        {
            if (this.Players[currentPlayerIndex].bombs_count > 0)
            {
                foreach (Player player in this.Players)
                {
                    if (player.name == player_name)
                    {
                        foreach (City city in player.cities)
                        {
                            if (city.Name == city_name)
                            {
                                if (city.Shield == true)
                                {
                                    city.Shield = false;
                                    return 0; // сняли щит
                                }
                                else
                                {
                                    city.LevelOfDevelopment -= Game.damage;
                                    city.Income -= Game.damage * 5;

                                    if (city.LevelOfDevelopment <= 0)
                                    {
                                        return 1; // уничтожили город
                                    }
                                    else
                                    {
                                        return 2; // уничтожили часть города
                                    }
                                    this.Players[currentPlayerIndex].bombs_count--;
                                }
                            }
                        }
                    }
                }
            }
            
            return -1; //ошибка
        }

        // получение текущего игрока
        public Player GetCurrentPlayer() => this.Players[currentPlayerIndex];

        // получение победителя
        public Player GetWinner()
        {
            Player winner = null;
            int max = 0;
            foreach(Player player in this.Players)
            {
                if (player.average_income > max)
                {
                    max = player.average_income;
                    winner = player;
                }
            }

            return winner;
        }
    }
}
