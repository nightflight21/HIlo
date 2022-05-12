using System;

namespace HiLo {
    class Deck {
        List<int> deck = new List<int>(); 
        public Deck() {        //adds 1-13 to a list 4 times
            for (int i = 0; i<4; i++) {
                for (int j = 1; j<=13; j++){
                    deck.Add(j);
                }
            }
        }

        public int draw() {
            Random random = new Random();
            int index = random.Next(this.deck.Count);
            int card = this.deck[index];
            this.deck.Remove(index);
            return card;
        }
    }
}