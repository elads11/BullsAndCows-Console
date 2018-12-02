using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CharsCounter : IActionOnMenu
    {
        public void DoActionOnMenu()
        {
            CountCharsInInput();
        }

        public void CountCharsInInput()
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
    }
}
