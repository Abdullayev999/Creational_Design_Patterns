namespace AbstractFactoryTask
{
    class NorthAmerica : IContinent
    {
        public Herbivore createHerbivore()
        {
            return new Bison();
        }

        public Carnivore createCarnivore()
        {
            return new Wolf();
        }
    }
}
