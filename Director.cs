using System;

namespace HiLo{
    class Director{
        
        

        bool again = true;
        int score = 300;
        int currentCard = firstCard();

        static int firstCard(){
        Deck deck1 = new Deck();
        int card = deck1.draw();
        return card;
        }

        static bool playGame(int card, int currentCard, int score)
        {
            // This is the game loop.
            Console.WriteLine($"The current card is: {card}");
            string guess = guess();
            int newCard = deck1.draw();
            bool correct = DetermineHiLo(guess, currentCard, newCard);
            score = AdjustScore(score, correct);
            if (checkLoss(score) == false)
            {
                Console.WriteLine("Your Score went below 0. You Lose!");
                return false;
            }
            Console.WriteLine($"Your score is: {score}");
            return askContinue();
        }   

        public static string guess(){
            Console.WriteLine("Is the next card higher [h] or lower [l]?");
            string guess = Console.ReadLine();
            return guess;
        }
        static bool DetermineHiLo(string guess, int currentCard, int newCard){
            // Accepts the users guess, the current card, and the new card as
            // parameters than determines if the guess was correct returning 
            // True if the user guessed correctly or False if they did not.

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
            // Accepts the current score and the return value for the
            //  DetermineHiLo function and returns the adjusted score.
            
            if (correct == true)
            {score = score + 100;}
            else
            {score = score - 75;}

            return score;
        }
//add curly braces if the function dont work well
        public static bool checkLoss(int score){            //public bool class that you pass the score into
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
