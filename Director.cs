using System;

namespace HiLo{
    class Director{
        // points
        // take input
        // bool still_playing
        // game loop
        // this would include removing the card from the 
        
        // This is the variable that will store the current score of the user.

        static bool DetermineHiLo(string guess, int currentCard, int newCard){
            string answer;
            if (newCard > currentCard)
            {answer = "h";}
            else if (newCard < currentCard)
            {answer = "l";}
            else
            {answer = guess;}

            if (answer == guess)
            {return true;}
            else
            {return false;}
        }

        static int AdjustScore(int score, bool correct)
        {
            if (correct == true)
            {score = score + 100;}
            else
            {score = score - 75;}

            return score;
        }
        
        public static bool checkLoss(int score){            //public bool class that you pass the score in
                if (score <= 0)                             //if the score is 0 or less than 0
                return false;                               //returns a false value, preferably to a Continue or stillPlaying boolean variable
                else                                        //else
                return true;                                //the game continues on
            }

        public static bool askContinue(){                   //public bool class to get user input
                Console.WriteLine("Play again? [y/n] ");    //writes line to console to prompt player for input
                string playAgain = Console.ReadLine();      //writes the user input to a string
                if (playAgain == "y")                       //if the string is y
                return true;                                //the game continues on
                else                                        //if its anything but y, even some random character
                return false;                               //the game is over. return false to a stillPlaying boolean variable
            }
    }
}
