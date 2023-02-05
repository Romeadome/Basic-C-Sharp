using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you can use a named parameter (times: 3) or just input the int value = (3)
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck,out timesShuffled, 12);
            foreach (Card card in deck.Cards)
            {
            Console.WriteLine(card.Face + " of " + card.Suit);
            
            }
            Console.WriteLine("Total Number of cards: {0}",deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}",timesShuffled);
            Console.ReadLine(); 

        }

        //create a static method/function that takes a deck parameter and returns a shuffled deck from the templist variable.
        public static Deck Shuffle(Deck deck , out int timesShuffled, int times = 1)
        {
            timesShuffled= 0;
            for (int i = 0; i < times; i++)
            {   
                timesShuffled++;
                List<Card> shuffledDeck = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    shuffledDeck.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);

                }
                deck.Cards = shuffledDeck;
            }  
            return deck;

        }
        ////overloaded method
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++) {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
