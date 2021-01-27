namespace AbstractFactoryTask
{
    class Africa : IContinent
    {
        public Herbivore createHerbivore()
        {
            return new Wildebeest();
        }

        public Carnivore createCarnivore()
        {
            return new Lion();
        }
    }
}
