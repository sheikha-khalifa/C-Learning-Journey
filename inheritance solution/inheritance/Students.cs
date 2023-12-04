
namespace inheritance
{
    internal class Students:Human
    {
        string qualifications;
        bool IsIntern;
        int totalgrade;
        int StudingHours;

        public Students(string qualifications, bool IsIntern,int totalgrade,int StudingHoursint ,int id, int age, string name, bool hasjob, bool isMarried) : base(id, age, name, hasjob, isMarried)
        { 
            this.qualifications = qualifications;
            this.IsIntern = IsIntern;
            this.totalgrade = totalgrade;
            this.StudingHours = StudingHours;

        }
        public void calculategrade()
        {

        }
    }
}
