using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Fuad Mannan
 * Date: July 27, 2017
 * Description: Lab 25 main program
 * Version: 0.5 - Updated the Program class to include tests for Deal5
 */

namespace COMP123_S2017_Lesson11A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hand hand = new Hand(); // new empty Hand container

            Deck deck = new Deck();
            //Console.WriteLine(deck.ToString());
            //Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            Hand hand = deck.Deal5();
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            //Console.WriteLine(deck);
            //Console.WriteLine();
            //hand.HighestCards();
            //hand.Add(new Card(Face.King, Suit.Spades));   //test to see if HighestCards will display doubles
            //hand.Add(new Card(Face.King, Suit.Hearts));
            hand.HighestCards();
            Console.ReadKey();
            /*
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            */

            // hand = deck.Deal5(); // creates a new Hand object and assigns it to hand


        }
    }
}
