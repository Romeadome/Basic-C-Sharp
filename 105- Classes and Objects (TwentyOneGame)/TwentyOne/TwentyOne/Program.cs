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

            //object initialization Example
            //Card card = new Card() { Face = "King", Suit = "Spades"};
            //you can use a named parameter (times: 3) or just input the int value = (3)

            //Calling the super class
            TwentyOneGame game= new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Roman" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            //Deck deck = new Deck();

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //Console.WriteLine(card.Face + " of " + card.Suit);           
            //}
            //Console.WriteLine("Total Number of cards: {0}",deck.Cards.Count);
            //Console.ReadLine(); 

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
