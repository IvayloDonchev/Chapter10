﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class CardOutOfRangeException : SystemException
    {
        private Cards deckContents;
        public Cards DeckContents
        {
            get { return deckContents; }
        }
        public CardOutOfRangeException(Cards sourceDeckContents) : base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }
    }
}
