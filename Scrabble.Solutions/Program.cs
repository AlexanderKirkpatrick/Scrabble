using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class Program
  {
   public static Dictionary<string, int> letterValues = new Dictionary<string, int>()
   {{"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1}, {"D", 2}, {"G", 2}, {"B", 3}, {"C", 3}, {"M", 3}, {"P", 3}, {"F", 4}, {"H", 4}, {"V", 4}, {"W", 4}, {"Y", 4}, {"K", 5}, {"J", 8}, {"X", 8}, {"Q", 10}, {"Z", 10}};
   
   public static void Main() 
   {
    Console.WriteLine("Welcome to the premier Scrabble score checker!");
    Console.WriteLine("Please enter a word to see the Scrabble value!");
    string userInput = Console.ReadLine();

    char[] userWordArray = userInput.ToCharArray();
    foreach (var word in userWordArray)
    {
     Console.WriteLine(word);
    }
    
    static void SplitWordValue()
    {
      
    }
  }

}
}


// foreach (var item in letterValues)
//     Console.WriteLine(item + ", " );