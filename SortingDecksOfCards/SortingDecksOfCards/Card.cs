namespace SortingDecksOfCards
{
    public class Card
    {
        public string Suit { get; set; }
        public string CardNumber { get; set; }
        
        public override string ToString()
        {
            return $"{Suit}:{CardNumber}";
        }
    }
}