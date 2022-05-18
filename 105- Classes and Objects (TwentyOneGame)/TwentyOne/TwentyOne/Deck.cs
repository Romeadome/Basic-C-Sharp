using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Constructor
        //This method is called as soon as an  Deck object is created.
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades"};
            List<string> Faces = new List<string>()
            {"Ace", "Two", "Three", "Four", "Five" ,"Six",
                "Seven", "Eight", "Nine", "Ten", "Jack","Queen", "King"};
            
            foreach (string suit in Suits)
            {
                foreach (string face in Faces)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }
        }

        
        public List<Card> Cards { get; set; }
    }
}
