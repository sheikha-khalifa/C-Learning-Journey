using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1___Week_4
{
    internal class Reptile:Animal
    {
        public bool HairORFur { get; set; }
        public string color { get; set; }
        public bool LayingEggs { get; set; }

        public Reptile(bool HairORFur, string color, bool LayingEggs, string name, int age, string species,DietType d):base(name, age, species,d)
        {
            this .HairORFur = HairORFur;
            this.color = color;
            this .LayingEggs = LayingEggs;
        }
        public void swim()
        {
            Console.WriteLine("i am swimming");
        }

    }
}
