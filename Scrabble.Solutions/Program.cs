using System;


namespace ScrabbleScore
{
  public class Program
  {

   public static void Main() 
   {
    Console.WriteLine("Welcome to the premier Scrabble score checker!");
    UserInput();
   }

   public static void UserInput()
   {
    Console.WriteLine("Please enter a word to see the Scrabble value!");
    string inputWord = Console.ReadLine();
    if (letterCheck(inputWord) == true)
    {
      int wordResult = Scorer.ScoreTotal(inputWord.ToUpper());
      Console.WriteLine("The word " + inputWord + " is worth: " + wordResult + " points!");
      UserInput();
    }
    else
    {
      Console.WriteLine("Please make sure to enter a word without spaces, numbers, or special characters! Valid Scrabble words only!");
      UserInput();
    }
   }

   public static bool letterCheck(string inputWord)
   {
    foreach (char letter in inputWord)
    {
      if (char.IsLetter(letter) != true)
      {
        return false;
      }
    }
      return true;
   }
  }
}


// char[] userWordArray = userInput.ToCharArray();
//     bool charFind = userWordArray.Contains();
//     foreach (var word in userWordArray)
//     {
//      Console.WriteLine(word);
//     }

// foreach( KeyValuePair<string, int> kvPair in letterValues)
    
    // static void SplitWordValue()
    // {
      
    // }