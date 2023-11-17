
namespace jagged_Array
{
    internal class reverse_slice
    {
            static void Main(string[] args)
            {
                int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Array.Reverse(originalArray);
                int startIndex = 2;
                int endIndex = 7;
                if (startIndex >= 0 && endIndex < originalArray.Length && startIndex <= endIndex)
                {
                    for (int i = endIndex; i >= startIndex; i--)
                    {
                        Console.Write(originalArray[i] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid slice indices.");
                }

            }
        }
    }

