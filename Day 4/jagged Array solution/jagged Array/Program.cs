namespace jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a jagged array
            int[][] jaggedArray = new int[3][];

            // Initializing the jagged array with different sizes for each row
            jaggedArray[0] = new int[] { 1, 2, 3 };       // Row 1 with 3 elements
            jaggedArray[1] = new int[] { 4, 5 };          // Row 2 with 2 elements
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };    // Row 3 with 4 elements

            // Accessing and printing elements of the jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
