using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);
            //deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine("{0} of {1}.", card.Face, card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            //deck.Cards = new List<Card>();//instantiated the list<card>
            //deck.Cards.Add(cardOne);
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            //Console.WriteLine("{0} of {1}", cardOne.Face, cardOne.Suit);
            //Console.WriteLine("{0} of {1}", deck.Cards[0].Face, deck.Cards[0].Suit);

        }

        public static Deck Shuffle(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }

            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);

        //    }
        //    return deck;
        //}
    }
}
