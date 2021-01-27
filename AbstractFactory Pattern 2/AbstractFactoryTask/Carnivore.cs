namespace AbstractFactoryTask
{
    public abstract class Carnivore : Animal
    {
        public int Power { get; set; }
        public abstract void  Eating(Herbivore herbivore);
    }
}
