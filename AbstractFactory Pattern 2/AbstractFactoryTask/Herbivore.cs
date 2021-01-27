namespace AbstractFactoryTask
{
    public abstract class Herbivore : Animal
    {
        public int Weight { get; set; }
        public bool Life { get; set; }

        public abstract void EatGrass();
    }
}
