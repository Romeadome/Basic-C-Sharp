using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()//Constructor
        {
            //When there is no value assigned, it will default to the constructor values below
            Suit = "Hearts";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
