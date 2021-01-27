namespace AbstractFactoryTask
{
    class Wildebeest : Herbivore
    {
        public Wildebeest()
        {
            Weight = 50;
        }
        public override void EatGrass()
        {
            Weight += 10;
        }
        public override string ToString()
        {
            return $"Wildebeest Weight : {Weight}";
        }
    }
}
