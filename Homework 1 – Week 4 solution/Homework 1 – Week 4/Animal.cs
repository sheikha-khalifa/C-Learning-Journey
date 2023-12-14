using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1___Week_4
{
    internal class Animal
    {
        public enum DietType
        {
            CARNIVORE = 1,
            HERBIVORE,
            OMNIVORE
        }
        public string name { get; set; }
        public int age { get; set; }
        public string species { get; set; }
        public DietType diet { get; set; }

        public Animal(string name, int age, string species, DietType diet)
        {
            this.name = name;
            this.age = age;
            this.species = species;
            this.diet = diet;

        }
        public void PerformAction()
        {
            switch (species.ToLower())
            {
                case "lion":
                    Move();
                    break;
                case "eagle":
                    Eat();
                    break;
                default:
                    Console.WriteLine("No specific action for this animal.");
                    break;
            }
        }
        public void Move()
        {
            Console.WriteLine("i am Moving");
        }
        public void Eat()
        {
            Console.WriteLine("i am eating");
        }
        public void Sleep()
        {
            Console.WriteLine("i am sleeping");
        }
      
        //public override string ToString()
        //{
        //    return $"your ID is:{this.id} \n your age is: {this.age}\n your name is: {this.name}" +
        //        $"\n you has job: {this.hasjob} \n your married status is: {this.isMarried}";
        //}
    }
}
