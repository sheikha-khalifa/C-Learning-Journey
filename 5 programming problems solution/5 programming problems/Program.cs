namespace _5_programming_problems
{
    internal class Program
    {
        static void Main(int x,string s)
        {
          /*  Given an integer x, return true if x is a palindrome, and false otherwise.
            Example 1:
            Input: x = 121
            Output: true
            Explanation: 121 reads as 121 from left to right and from right to left.*/

          /*  Console.WriteLine("Enter an Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            if (x < 0)
                Console.WriteLine("False");
                int original = x;
                int reversed = 0;

            while (reversed != 0) 
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
                Console.WriteLine("True");
                
               
            }
            Console.WriteLine(original == reversed);*/
        }
        /*Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000*/
        // Define a dictionary to store values of Roman numerals
        Dictionary<char, int> romanValues = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;
        
        // Loop through the input string
        for(int i = 0; i<s.Length; i++) {
            // Get the value of the current Roman numeral
            int value = romanValues[s[i]];
            
            // Check if subtractive notation is used (e.g., IV, IX, XL, XC, etc.)
            if (i<s.Length - 1 && value<romanValues[s[i + 1]]) {
                result -= value; // If true, subtract the current value
            } else {
                result += value; // Otherwise, add the current value
            }
          Console.WriteLine(result);
        }

    }
}