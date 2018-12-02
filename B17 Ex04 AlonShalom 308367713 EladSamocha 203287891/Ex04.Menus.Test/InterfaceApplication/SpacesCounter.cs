using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class SpacesCounter : IActionOnMenu
    {
        public void DoActionOnMenu()
        {
            CountSpacesInInput();
        }

        public void CountSpacesInInput()
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
    }
}
