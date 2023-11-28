
namespace oobj_practice
{

    internal class @struct
    {
        struct MyStruct
        {
            public int Value { get; set; }
            // Other members and methods can be defined here
        }

        static void Main()
        {
            MyStruct myStruct = new MyStruct();
            Console.WriteLine(myStruct.ToString()); // This uses the ToString method from System.Object
        }
    }
}
