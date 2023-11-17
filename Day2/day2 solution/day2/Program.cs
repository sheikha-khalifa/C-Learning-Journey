namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello,world!");
            Console.WriteLine("this is makeen program" +
                "it will be nice joureny \n" +
                "\t have fun");//use Console to print text (\n to write in new line,\t for tab)
            string name = "sheikha AL Quyudhi";// declear variable and assign value
            string FulllnameJob = "full stack development";// declear variable and assign value
            int age = 25;// declear variable and assign value
            Console.WriteLine("my name is:" + name + "\n my age is:" + age + "\n the name of my job is:" + FulllnameJob);

            // single line comments
            /* double line comments 
             * ------
             * -------*/
            #region used region
            //-----------
            /* use region to colabs multi lines with title
             * */
            #endregion

            //casting to translate from one type of data to another
            // implicit casting
            int num_of_days = 80;
            long ssn = num_of_days;
            Console.WriteLine(ssn);
            // explicit casting
            double payment = 55.3;
            //int realpayment = payment;// cause error
            int realpayment = (int)payment;//this correct 

            // checked block used to check statements (transfer rom long data type to int)if it has errors will throw exeption 
            long suv = 1234567898;
            int update = (int)suv;
            Console.Write(update);//overflow exception

            //declear objects
            object obj1 = new object();//give space in stack 
            Console.Write(obj1.GetHashCode());


        }
    }
}
