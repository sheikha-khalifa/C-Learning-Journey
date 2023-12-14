
namespace Homework_1___Week_4
{
    internal class Zoo
    {
        private Animal[] animals;
        private int currentAnimalsCount;
        private const int MaxAnimals = 100; // Maximum animals the zoo can hold

        public Zoo()
        {
            animals = new Animal[MaxAnimals];
            currentAnimalsCount = 0;
        }
        public void AddAnimal(string name, int age, string species, DietType diet)
        {
            if (name != null && species != null)
            {
                if (currentAnimalsCount < MaxAnimals)
                {
                    Animal newAnimal = new Animal(name, age, species, (Animal.DietType) diet);
                    animals[currentAnimalsCount] = newAnimal;
                    currentAnimalsCount++;
                    Console.WriteLine("Animal Added Successfully!");
                }
                else
                {
                    Console.WriteLine("Zoo is full. Cannot add more animals.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input: Name or Species cannot be null.");
            }
        }
    
        public void DisplayZooAnimals()
        {
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < currentAnimalsCount; i++)
            {
                Console.WriteLine($"Animal: {animals[i].name}, Age: {animals[i].age}, Species: {animals[i].species}, Diet: {animals[i].diet}");
            }
            Console.WriteLine("-----------------------------");
        }

        public void ObserveAnimalActions()
        {
            for (int i = 0; i < currentAnimalsCount; i++)
            {
                animals[i].PerformAction();
            }
        }
    }
}