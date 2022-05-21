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
        //properties
        public List<Card> Cards { get; set; }

        //Shuffle Method for Deck
        public void Shuffle(int times = 1)
        {
           
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
