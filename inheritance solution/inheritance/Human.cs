
namespace inheritance
{
    internal class Human:creature ,IMove
    {
        public int id;
        public int age;
        public string name;
        bool hasjob;
        bool isMarried;

        public void Move()
        {
            Console.WriteLine("i am Moving");
        }
        public void Eat()
        {
            Console.WriteLine("i am eating");
        }
        public void Sleep ()
        {
            Console.WriteLine("i am sleeping");
        }
        public Human(int id, int age,string name,bool hasjob,bool isMarried)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.hasjob = hasjob;
            this.isMarried = isMarried;
        }
        public override string ToString()
        {
            return $"your ID is:{this.id} \n your age is: {this.age}\n your name is: {this.name}" +
                $"\n you has job: {this.hasjob} \n your married status is: {this.isMarried}";
        }
        public virtual void calculatesalary()
        {
            Console.WriteLine("your salary is calsulated according to:");
        }
        
    }
}
