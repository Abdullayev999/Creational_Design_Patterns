using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace AbstractFactoryTask
{

    interface IContinent
    {
        public Herbivore createHerbivore();
        public Carnivore createCarnivore();
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            AnimalCreator animalCreator = new AnimalCreator();

            animalCreator.UnitFactory = new Africa();

            animalCreator.AddCarnivore(animals);
            animalCreator.AddCarnivore(animals);
            animalCreator.AddCarnivore(animals);

            animalCreator.AddHerbivore(animals);
            animalCreator.AddHerbivore(animals);

            animalCreator.UnitFactory = new NorthAmerica();

            animalCreator.AddCarnivore(animals);
            animalCreator.AddCarnivore(animals);
            animalCreator.AddCarnivore(animals);

            animalCreator.AddHerbivore(animals);
            animalCreator.AddHerbivore(animals);

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            AnimalWorld animal = new AnimalWorld();
            animal.MealsCarnivore(animals);
            animal.MealsHerbivores(animals);

            Console.WriteLine();
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
