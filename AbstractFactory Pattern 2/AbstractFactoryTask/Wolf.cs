namespace AbstractFactoryTask
{
    class Wolf : Carnivore
    {
        public Wolf()
        {
            Power = 60;
        }
        public override void Eating(Herbivore herbivore)
        {
            if (Power > herbivore.Weight)
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
            return $"Wolf Power : {Power}";
        }
    }
}
