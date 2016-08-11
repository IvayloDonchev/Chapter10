﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch11CardLib;

namespace Ch11CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck myDeck = new Deck();
            //myDeck.Shuffle();
            //for (int i = 0; i < 52; i++)
            //{
            //    WriteLine($"{i+1}. {myDeck.GetCard(i)}");
            //}
            //ReadKey();
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            deck1.Shuffle();
            WriteLine("Original deck shuffled.");
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            ReadKey();
        }
    }
}
