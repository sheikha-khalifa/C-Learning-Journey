namespace Arrays
{
    internal class Program
    {
            static void Main(string[] args)
            {
            Console.WriteLine("------------------------day 4 practice programs--------------------------------\n");
            #region Arrays
            //single line dimensional array
            //from any data type
            int[] arr = new int[5];
                    //dont forget that array is accessed by index
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
                arr[4] = 5;
               //arr[5] = 6;// out of bound width
               
            //array with not fixed size(from user)
            Console.WriteLine("enter array number:");
            int n;
            n=Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            #endregion
            //multidimensional array
            //1,2,3,4,,
            //5,6,7,8 ==>matrix
            //4,5,6
            int[,] Grade = new int[2, 2];
            Grade[0, 0] = 1;
            Grade[0, 1] = 2;
            Grade[1, 0] = 1;
            Grade[1 ,1] = 1;

            //jagged array
            int[][] jagged = new int[2][];
            jagged[0] = new int[3] { 1, 2, 3 };
            jagged[1] = new int[2] { 2, 3 };

            //creating single array(string)
            string[] name = new string[3];
            name[0] = "sheikha";
            name[1] = "maitha";
            name[2] = "kholood";
            Console.WriteLine("\n second name in the array is:" +name[0]);
            //creating multidimentional array(string)
            int[,] multi=new int[3, 3];
            multi[0,0] = 3;
            multi[0,1] = 1;
            multi[0,2] = 2;
            multi[1,0] = 1; 
            multi[1,1] = 2;
            multi[1,2] = 1;
            multi[2,0] = 1;
            multi[2,1] = 2;
            multi[2,2] = 1;
            Console.WriteLine("\n second name in the array is:" + multi[0,1]);
            //creating jagged array
            int[][]ty = new int[3][];
            ty[0] = new int[3] { 9, 8, 7 };
            ty[1] = new int[2] { 1, 3 };
            ty[2] = new int[1] { 4 };
            Console.WriteLine("\n the fisrt number in jagged arrayis :" + ty[0][2]);//access the 3 element in the first array

            #region if-condition
            Console.WriteLine("please enter student grade:");
            int value=Convert.ToInt32(Console.ReadLine());
            if(value >= 75)
            {
                Console.WriteLine("succed");

            }
            else if(value >= 50)//===> else if it check first condition , even first or second 
            {
                Console.WriteLine("goood");
            }
            else
            {
                Console.WriteLine("faild");

            }
            //second sitation
            if (value >= 75)
            {
                Console.WriteLine("succed");

            }
            if (value >= 50)//===> if it check each condetion as separate not link with first condition 
            {
                Console.WriteLine("goood");
            }
            else
            {
                Console.WriteLine("faild");

            }
            #endregion if-condition

            #region switch
            //switch
            Console.WriteLine("please enter student grade:");
            int namest = Convert.ToInt32(Console.ReadLine());
            string[] menu = { "latte", "cappcino", "amerecano" };
            string[] size = { "small", "cappcino", "amerecano" };
            //double [] price=new double[3]{ 3.25, 2.5, 3.5 };
            double[] prices = { 3.25, 2.5, 3.5 };//another way 
            Console.WriteLine($"1.{menu[0]}--3.25$");
            Console.WriteLine($"1.{menu[1]}--2.5$");
            Console.WriteLine($"1.{menu[2]}--3.5$");
            Console.WriteLine($"please enter the drink:(1-3");
            int drinks = Convert.ToInt32(Console.ReadLine());
            string drink = "";
            double price = 0.0;
            switch (namest)
            {
                case 1:
                    drink = menu[namest - 1];
                    price = prices[namest - 1]; ;
                    Console.WriteLine("choose the size of the drink:");
                    int uservalue = Convert.ToInt32(Console.ReadLine());
                    size=
                    break;

            }


            #endregion
        }

    }
    
}