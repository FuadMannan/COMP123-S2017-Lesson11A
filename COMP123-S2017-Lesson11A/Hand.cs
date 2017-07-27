using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList class
 * Version: 0.1 - Created the Hand class
 */

namespace COMP123_S2017_Lesson11A
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        // PRIVATE METHODS

        protected override void _initialize()
        {
            throw new NotImplementedException();
        }

        // PUBLIC METHODS

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