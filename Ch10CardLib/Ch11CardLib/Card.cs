﻿using System;
//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11CardLib
{
    public class Card : ICloneable
    {
        public readonly Rank rank;
        public readonly Suit suit;

        private Card()
        {}

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }

        public object Clone() => MemberwiseClone();
       
    }
}