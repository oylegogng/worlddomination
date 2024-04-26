using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worlddomination
{
    public class Player
    {
        public string name;
        public List<City> cities; // список городов 
        public int average_income; // сумарный доход
        public int average_level; // сумарный уровень
        public int bombs_count; // кол-во бомб
        public bool create_bomb; // переключатель создания бомбы

        public Player(string name, List<City> cities)
        {
            this.name = name;
            this.cities = cities;
            this.average_income = AverageIncomeSum();
            this.average_level = AverageLevelSum();
            this.bombs_count = 0;
            this.create_bomb = false;
        }

        public int AverageIncomeSum()
        {
            int count = 0;
            foreach(City city in cities)
            {
                count += city.Income;
            }

            return count;
        }

        public int AverageLevelSum()
        {
            int count = 0;
            foreach (City city in cities)
            {
                count += city.LevelOfDevelopment;
            }

            return count;
        }

        public void CreateBomb()
        {
            this.bombs_count += 1;
        }

        
    }
}
