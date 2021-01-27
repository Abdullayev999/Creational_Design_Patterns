namespace AbstractFactoryTask
{
    class Bison : Herbivore
    {
        public Bison()
        {
            Weight = 100;
        }
        public override void EatGrass()
        {
            Weight += 10;
        }
        public override string ToString()
        {
            return $"Bison Weight : {Weight}";
        }
    }
}
