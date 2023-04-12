////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab 2 – Deck of Cards
// File Name: DeckDriver.cs
// Description: Creates Initial Deck, then shuffles deck and creates 2 hands of 7 cards with new deck.
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Wednesday, September 14, 2022
// Copyright: Justin Dubin, 2022
//
/////////////////////////
using Lab2CardClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DubinJustin_Lab2
{
    /// <summary>
    /// Driver creates hand size, a new deck, then shuffles that deck and displays it along with 2 hands from the shuffled deck
    /// </summary>
    public class DeckDriver
    {
        /// <summary>
        /// Main method of driver class, where all decks are created and modified
        /// </summary>
        public static void Main()
        {
            int handSize = 7; //Number of cards to be introduced in a hand

            Deck DeckCards = new Deck(); //Creates new Deck
            Console.WriteLine("The Initial Deck is:" + "\n" + DeckCards); //Displays first Deck (Initial Deck)

            DeckCards.Shuffle();    //Shuffles Deck 1 time
            DeckCards.Shuffle();    //Shuffles Deck 2 times
            DeckCards.Shuffle();    //Shuffles Deck 3 times

            Console.WriteLine("The Second Shuffled Deck is: "+ "\n"+ DeckCards);   //Shuffled Deck after shuffling 3 times
        
            Console.WriteLine("First Hand of Seven Cards:\n" + DeckCards.DealAHand(handSize));     //First hand of cards in shuffled deck
            Console.WriteLine("Second Hand of Seven Cards:\n" + DeckCards.DealAHand(handSize));    //Second hand of cards in shuffled deck
        }
    }
}
