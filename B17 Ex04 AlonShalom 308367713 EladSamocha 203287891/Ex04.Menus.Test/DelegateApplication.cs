using System;

namespace Ex04.Menus.Test
{
    // $G$ DSN-004 (-10) Redundant code duplication.
    public static class DelegateApplication
    {
        public static void CountSpacesInInput()
        {
            string userSentenceInput;
            int counterOfSpaces = 0;
            Console.WriteLine("please enter a sentence: ");
            userSentenceInput = Console.ReadLine();
            for (int i = 0; i < userSentenceInput.Length; i++)
            {
                if (userSentenceInput[i] == ' ')
                {
                    counterOfSpaces++;
                }
            }

            Console.WriteLine("there are {0} spaces in the sentence.", counterOfSpaces);
        }

        public static void CountCharsInInput()
        {
            string usersentenceInput;
            int counterOfChars = 0;
            Console.WriteLine("please enter a sentence: ");
            usersentenceInput = Console.ReadLine();
            for (int i = 0; i < usersentenceInput.Length; i++)
            {
                if (char.IsLetter(usersentenceInput[i]))
                {
                    counterOfChars++;
                }
            }

            Console.WriteLine("there are {0} chars in the sentence.", counterOfChars);
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
        }

        public static void ShowDate()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("d"));
        }
    }
}