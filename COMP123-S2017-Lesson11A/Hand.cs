using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList class
 * Version: 0.4 - added HighestCards method
 */

namespace COMP123_S2017_Lesson11A
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes class variables and other objects
        /// </summary>
        protected override void _initialize()
        {
            // This method is currently empty
        }

        // PUBLIC METHODS
        public void HighestCards()
        {
            var max =
                from card in this
                orderby card.Face descending
                select card;
            int highestValue = 0;
            Console.WriteLine("Highest cards in hand:");
            foreach(var card in max)
            {
                if ((int)card.Face >= highestValue)
                {
                    Console.WriteLine(card);
                    highestValue = (int)card.Face;
                }
            }
        }

        /// <summary>
        /// This method overrides the built-in ToString method
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "The Hand contains:\n";
            outputString += "================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }





    }
}