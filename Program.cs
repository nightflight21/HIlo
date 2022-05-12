namespace HiLo {
    class Program {
        static void Main() {
            //start
            bool again = true;
            int score = 300;
            int currentCard = firstCard();
            
            static int firstCard(){
            Deck deck1 = new Deck();
            int card = deck1.draw();
            return card;
            }   
    
            Director game = new Director();
            while (again == true)
            {
                again = game.playGame(currentCard, score);
            }
            //ending game
            Console.WriteLine("Thank you for playing!");
        }
    }
}