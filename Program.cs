namespace HiLo {
    class Program {
        static void Main() {
            //start
            bool again = true;
            int score = 300;
            
            Deck deck1 = new Deck();
            int currentCard = deck1.draw();
    
            Director game = new Director();
            game.playGame(currentCard, score, deck1);
            
            //ending game
            Console.WriteLine("Thank you for playing!");
        }
    }
}