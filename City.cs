using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worlddomination
{
    public class City
    {
        private string name { get; set; }
        private int level_of_development { get; set; } // уровень развития города
        private int income { get; set; } // доход города
        private bool shield { get; set; } // наличие у города щита
        

        public City(string name, int default_level, int default_income)
        {
            this.name = name;
            this.level_of_development = default_level;
            this.income = default_income;
            this.shield = false;
            
        }

        public string Name { get { return name; } }

        

        public void SetUpgrade() // улучшить город
        {
            this.level_of_development += Game.default_level / 5;
            this.income += Game.default_income;
        }

        public void SetShield() // установить щит
        {
            this.Shield = true;
        }
        
        public int LevelOfDevelopment
        {
            get { return level_of_development; }
            set { level_of_development = value; }
        }

        public int Income
        {
            get { return income; }
            set { income = value; }
        }

        public bool Shield
        {
            get { return shield; }
            set { shield = value; }
        }


    }
}
