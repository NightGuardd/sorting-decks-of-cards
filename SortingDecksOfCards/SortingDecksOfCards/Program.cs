using System;

namespace SortingDecksOfCards
{
    internal static class Program
    {
        public static void Main()
        {
            var deckOfCardsOperations = new DeckOfCardsOperations();
            string userCommand;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Chose the action:");
                Console.WriteLine("create - create new deck;");
                Console.WriteLine("remove - remove the deck;");
                Console.WriteLine("get list - to get list of decks");
                Console.WriteLine("shuffle - shuffle the deck");
                Console.WriteLine("get deck - get the deck");
                Console.WriteLine("exit - exit the program\n");
                
                userCommand = Console.ReadLine();
                string userNameOfDeck;
                
                switch (userCommand)
                {
                    case "create":
                        Console.Clear();
                        Console.WriteLine("Write the name of the deck you want to add:");
                        userNameOfDeck = Console.ReadLine();
                        
                        deckOfCardsOperations.DeckOfCards(userNameOfDeck);
                        
                        Console.WriteLine("The deck {0} added!", userNameOfDeck);
                        Console.ReadLine();
                        break;
                    case "remove":
                        Console.Clear();
                        Console.WriteLine("Write the name of the deck you want to remove:");
                        userNameOfDeck = Console.ReadLine();
                        
                        deckOfCardsOperations.RemoveDeckOfCards(userNameOfDeck);
                        
                        Console.ReadLine();
                        break;
                    case "get list":
                        Console.Clear();
                        
                        var listOfDeckNames = deckOfCardsOperations.GetListOfDecks();
                        foreach (var nameOfDeck in listOfDeckNames)
                        {
                            Console.WriteLine(nameOfDeck);
                        }
                        
                        Console.ReadLine();
                        break;
                    case "shuffle":
                        Console.Clear();
                        Console.WriteLine("Write the name of the deck you want to shuffle:");
                        userNameOfDeck = Console.ReadLine();
                        
                        Console.WriteLine("How do you want to shuffle the deck? \"auto\" or \"handle\"");
                        var shufflingMethod = Console.ReadLine();
                        
                        deckOfCardsOperations.ChoosingShuffleMethod(shufflingMethod, userNameOfDeck);
                        
                        Console.ReadLine();
                        break;
                    case "get deck":
                        Console.Clear();
                        Console.WriteLine("Write the name of the deck you want to get:");
                        userNameOfDeck = Console.ReadLine();
                        
                        var deckCards = deckOfCardsOperations.GetDeck(userNameOfDeck);
                        deckCards.ForEach(Console.WriteLine);
                        
                        Console.ReadLine();
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Sorry, but I don't know this command :(");
                        Console.ReadLine();
                        break;
                }
            } while (userCommand != null && !userCommand.Equals("exit"));
        }
    }
}