namespace AbstractFactoryTask
{
    class Lion : Carnivore
    {
        public Lion()
        {
            Power = 120;
        }
        public override void Eating(Herbivore herbivore)
        {
            if (Power>herbivore.Weight)
            {
                Power += 10;
            }
            else
            {
                Power -= 10;
            }
        }

        public override string ToString()
        {
            return $"Lion Power : {Power}";
        }
    }
}
