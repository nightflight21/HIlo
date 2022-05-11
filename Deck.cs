
namespace HiLo {
    class Deck {
        List<int> deck = new List<int>();
        public void constuctDeck() {
            for (int i = 0; i<4; i++) {
                for (int j = 0; i<13; i++){
                    deck.Add(j);
                }
            }
        }

        public int draw() {
            var random = new Random();
            int index = random.Next(this.deck.Count);
            this.deck.Remove(index);
            return this.deck[index];
        }
    }
}