using System.ComponentModel.DataAnnotations;

namespace classes_example
{
    //internal class product
    //{
    //    public const double pi = 3.14;
    //    public static int cnt;
    //    public int productid;
    //    public string productname;
    //    public int productprice;
    //    public int countinstore;
    //    public bool hasdicount;

    //    public void calculate(string productname, int productprice, int countstore, bool hasdicount)
    //    {
    //        cnt = +1;

    //        this.productname = productname;
    //        this.productprice = productprice;
    //        this.countinstore = countstore;
    //        this.hasdicount = hasdicount;

    //    }

    //}
   

    
    internal class Human
    {
        private string name;
        private int age;
        private string address;
        private int id;
        private string email;

        //constructor with same name as class name
        public Human(string name, int age, string address, int id,string email)
        {

            this.name = name;
            this.age = validateage(age) ? age : 0;
            this.address = address;
            this.id = id;
            this.email=email;

        }
        public string Name
        {
            get {return this.name;}
            set {this.name = value;}
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        //getter and setter
        //public void Setemail(string email)
        //{
           //this.email =email;
        //}
        //public string Getemail()
        //{
        //    return this.email;
        //}
        //public int GetId()
        //{
        //    return this.id;
        //}
      
        public static bool validateage(int age)
        {
            if (age <= 0 || age >= 100)
            {
                return false;
            }
            return true;
        }
        // another way of creating function
        public string greetingname()=>$"\n your name is: {this.name}\n yourage is :{this.age}\n your email is: {this.email}" +
            $"\n your address is:{this.address}";
       
        //public string greeting() {
        //    return ($"\n yourname is: {this.name} your age is :{this.age} your address is {this.address}");
        }

    } 

