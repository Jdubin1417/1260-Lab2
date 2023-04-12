////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab 2 – Deck of Cards
// File Name: Card.cs
// Description: Creates Default Card, and allows cards to be displayed in proper format
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Wednesday, September 14, 2022
// Copyright: Justin Dubin, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CardClass
{
    /// <summary>
    /// This class models one single card out of an ordinary deck of playing cards, and gives a way to display 
    /// it properly in string format.
    /// </summary>
    public class Card
    {
        //Attributes
        public Face Face { get; set; }
        public Suit Suit { get; set; }
        
        /// <summary>
        /// Default Constructor creaters default card. Ace of Diamonds is default card
        /// </summary>
        public Card()
        {
            Face = Face.Ace;
            Suit = Suit.Diamonds; //Default card is Ace of Diamonds
        }
        
        /// <summary>
        /// Parameterized Constructor allows Face and Suit ENUMs to be used for cards 
        /// </summary>
        /// <param name="n"></param>
        public Card(int n)
        {
            Face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            Suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
        }


        /// <summary>
        /// Copy constructor of Card Method. Face and Suit are also copied inside of method. 
        /// </summary>
        /// <param name="existingCard"></param>
        public Card(Card existingCard)
        {
            Face = existingCard.Face;
            Suit = existingCard.Suit;
        }
        
        /// <summary>
        /// Creates wording for the face and suit that makes sense. EX: The Ace of Diamonds / The Four of Clubs
        /// </summary>
        /// <returns>CardStr</returns>
        public override string ToString()
        {
            string CardStr = "The " + Face.ToString() + " of " + Suit.ToString() + "\n";
            return CardStr;

        }
    }
}
