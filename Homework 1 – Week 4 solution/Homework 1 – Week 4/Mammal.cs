using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1___Week_4
{
    internal class Mammal:Animal
    {
        public bool Warmblooded { get; set; }
        public bool MammaryGlands { get; set; }
        public string MammalColor { get; set; }

        public Mammal(bool Warmblooded, bool MammaryGlands, string MammalColor,string name, int age, string species, DietType d) :base (name,age,species,d)
        {
            this.Warmblooded = Warmblooded;
            this.MammaryGlands = MammaryGlands;
            this.MammalColor= MammalColor;
        }
        public void make_sound()
        {
            Console.WriteLine("i can make sounds");
        }

    }
}
