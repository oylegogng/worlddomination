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
    public partial class Form1 : Form
    {

        Game game;

        public Form1()
        {
            InitializeComponent();
            this.game = new Game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CreateCrew_Click(object sender, EventArgs e)
        {
            // Создаем фабрику городов
            ICityFactory cityFactory = new ConcreteCityFactory();

            // Создаем города с помощью фабрики
            City city1 = cityFactory.CreateCity(City1Name.Text, Game.default_level, Game.default_income);
            City city2 = cityFactory.CreateCity(City2Name.Text, Game.default_level, Game.default_income);
            City city3 = cityFactory.CreateCity(City3Name.Text, Game.default_level, Game.default_income);
            City city4 = cityFactory.CreateCity(City4Name.Text, Game.default_level, Game.default_income);
            List<City> cities = new List<City>();

            cities.Add(city1);
            cities.Add(city2);
            cities.Add(city3);
            cities.Add(city4);

            // Создаем фабрику игроков
            IPlayerFactory playerFactory = new ConcretePlayerFactory(new ConcreteCityFactory());

            // Создаем игрока с помощью фабрики
            Player player = playerFactory.CreatePlayer(PlayerName.Text, cities);

            // Добавляем игрока в игру
            game.AddPlayer(player);

            // Обновляем список на форме
            PlayersList.Items.Add(player.name);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            PlayersList.Update();
        }

        private void StartGameButton_Click(object sender, EventArgs e) // начало игры
        {
            // Создание экземпляра Form2
            Form2 form2 = new Form2(game);

            // Отображение формы Form2
            form2.Show();
            
        }
    }
}
