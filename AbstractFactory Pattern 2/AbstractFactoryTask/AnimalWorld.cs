using System;
using System.Collections.Generic;

namespace AbstractFactoryTask
{
    class AnimalWorld
    {

        public void MealsHerbivores(List<Animal> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Herbivore tmp)
                {
                    tmp.EatGrass();

                }
            }
        }

        public void MealsCarnivore(List<Animal> car)
        {
            Random random = new Random();
            int indexCar = car.Count;
            for (int i = 0; i < indexCar; i++)
            {
                if (car[i] is Carnivore tmp)
                {

                    int index=random.Next(0, 2);
                    if (index==0)
                    {
                        tmp.Eating(new Bison());
                    }
                    else if(index==1)
                    {
                        tmp.Eating(new Wildebeest());
                    }
                    
                }
            }

        }
    }
}
