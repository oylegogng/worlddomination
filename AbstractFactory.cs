using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worlddomination
{
    // Интерфейс для фабрики городов
    public interface ICityFactory
    {
        City CreateCity(string name, int defaultLevel, int defaultIncome);
    }

    // Интерфейс для фабрики игроков
    public interface IPlayerFactory
    {
        Player CreatePlayer(string name, List<City> cities);
    }
    // Конкретная реализация фабрики городов
    public class ConcreteCityFactory : ICityFactory
    {
        public City CreateCity(string name, int defaultLevel, int defaultIncome)
        {
            return new City(name, defaultLevel, defaultIncome);
        }
    }

    // Конкретная реализация фабрики игроков
    public class ConcretePlayerFactory : IPlayerFactory
    {
        private ICityFactory _cityFactory;

        public ConcretePlayerFactory(ICityFactory cityFactory)
        {
            _cityFactory = cityFactory;
        }

        public Player CreatePlayer(string name, List<City> cities)
        {
            return new Player(name, cities);
        }

    }
}
