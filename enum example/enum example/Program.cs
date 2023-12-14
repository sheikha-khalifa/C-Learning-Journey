namespace enum_example
{
    enum Months
    {
        Jan = 1,
        feb,
        march,
        Apr,
        may,
        june,
        july,
        aug,
        sep,
        oct,
        nov,
        dec
    }
    [Flags]
    enum permisions
    {
        None = 0, //0000 0000
        read = 1, //0000 0001
        write = 2, //0000 0010
        delete = 4, //0000 0100
        execute = 8, //0000 1000
        level1 = read | write,
        Admin = read | write | delete,
        SuperAdmin = read | delete | execute | write

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Months months = Months.Jan;
            Console.WriteLine($"The month is:{months}==>{(int)months}");

            permisions permision = permisions.read | permisions.write | permisions.execute;
            Console.WriteLine(permision);
            if (permision.HasFlag(permisions.Admin))
            {
                Console.WriteLine($"you have only read,write,delete your credentional is: {permisions.Admin.ToString()}");
            }

            //ENUM PARSING
            string month = "feb";
            Console.WriteLine((int)(Enum.Parse(typeof(Months), month)));
            if (Enum.TryParse(month, out Months mnth))
            {
                Console.WriteLine(mnth);
            }
            //.IsDefined
            if (Enum.IsDefined(typeof(Months), month))
            {
                Console.WriteLine(Enum.Parse(typeof(Months), month));
            }
            //foreach
            foreach (Months month2 in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(month2 + ":" + (int)(month2));
            }

        }
    }
}
   