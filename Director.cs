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
            string answer = "c";
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
    }
}