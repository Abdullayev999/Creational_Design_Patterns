using System.Collections.Generic;

namespace AbstractFactoryTask
{
    class AnimalCreator
    {
        public IContinent UnitFactory { get; set; }

        public void AddHerbivore(List<Animal> units)
        {
            units.Add(UnitFactory.createHerbivore());
        }

        public void AddCarnivore(List<Animal> units)
        {
            units.Add(UnitFactory.createCarnivore());
        }
    }
}
