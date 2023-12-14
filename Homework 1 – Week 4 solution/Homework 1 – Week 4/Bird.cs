using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1___Week_4
{
    internal class Bird:Animal
    {
        public bool LayingEggs { get; set; }
        public bool HollowBones { get; set; }
        public bool Feathers { get; set; }

        public Bird(bool LayingEggsstring , bool HollowBones, bool Feathers,string name,int age, string species, DietType d) : base (name, age, species,d)
        {
            this.LayingEggs = LayingEggs;
            this.HollowBones = HollowBones;
            this.Feathers = Feathers;
        }
        public void fly()
        {
            Console.WriteLine("i am flying");
        }
       
    }
}
