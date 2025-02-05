namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" }; //fruits array
            bool wordFound = false; //boolean for whether the word has been found (which will be our output)
            Console.WriteLine("What word would you like to find?"); //prompts user
            string wordToFind = Console.ReadLine(); //assigns user input to a string
            foreach (string f in fruits) //checks against every index in the fruits array
            {
                if (f == wordToFind) //compares the user input to the index within the fruits array
                {
                     wordFound = true; //if the index matches, the word has been found so the boolean is set to true
                     break; //breaks out of array, as the word has already been found
                }
            }
            Console.WriteLine(wordFound); //outputs True if the word is found and False if it isnt
            
            //////////////////////////////////////////////////////////////////////////////////////
            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
