using System;
using System.Collections.Generic;

namespace SortingDecksOfCards
{
    public class DeckOfCardsOperations
    {
        private readonly List<Card> cards = new List<Card>(52);
        private readonly Dictionary<string, List<Card>> dictionaryOfDecks = new Dictionary<string, List<Card>>();

        public void DeckOfCards (string nameOfDeck)
        {
            foreach (var suitName in Enum.GetNames(typeof(Suit)))
            {
                foreach (var cardNumber in Enum.GetNames(typeof(CardNumber)))
                {
                    cards.Add(new Card
                    {
                        Suit = suitName,
                        CardNumber = cardNumber
                    });
                }
            }
            dictionaryOfDecks.Add(nameOfDeck, cards);
        }

        public void RemoveDeckOfCards(string nameOfDeck)
        {
            if (dictionaryOfDecks.ContainsKey(nameOfDeck))
            {
                dictionaryOfDecks.Remove(nameOfDeck);
                Console.WriteLine("The deck {0} removed!", nameOfDeck);
            }
            else
            {
                Console.WriteLine("There is no this deck");
            }
        }
        
        public Dictionary<string, List<Card>>.KeyCollection GetListOfDecks()
        {
            return dictionaryOfDecks.Keys;
        }

        private void AutoShuffling (string nameOfDeck)
        {
            if (dictionaryOfDecks.ContainsKey(nameOfDeck))
            {
                var currentDeck = dictionaryOfDecks[nameOfDeck];
                var randomIndex = new Random();
                for (var i = currentDeck.Count - 1; i >= 1; i--)
                {
                    var j = randomIndex.Next( i + 1);
                    (currentDeck[j], currentDeck[i]) = (currentDeck[i], currentDeck[j]);
                }
                Console.WriteLine("The deck {0} shuffled!", nameOfDeck);
            }
            else
            {
                Console.WriteLine("There is no this deck");
            }

        }

        private void ManualShuffling(string nameOfDeck)
        {
            Console.WriteLine("Sorry, but I can't do this yet");
        }

        public void ChoosingShuffleMethod(string command, string nameOfDeck)
        {
            switch (command)
            {
                case "auto":
                    AutoShuffling(nameOfDeck);
                    break;
                case "handle":
                    ManualShuffling(nameOfDeck);
                    break;
                default:
                    Console.WriteLine("Have you selected a valid option?");
                    break;
            }
        }
        
        public List<Card> GetDeck (string nameOfDeck)
        {
            var deckOfCards = new List<Card>();
            if (dictionaryOfDecks.ContainsKey(nameOfDeck))
            {
                deckOfCards = dictionaryOfDecks[nameOfDeck];
            }
            else
            {
                Console.WriteLine("There is no this deck");
            }

            return deckOfCards;
        }
    }
}