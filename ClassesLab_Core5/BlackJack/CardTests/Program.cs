using System;
using CardClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCardConstuctors(); // test worked
            //TestOverloadedConstructorException(); // test worked
            //TestGetters();  // test worked
            //TestSetter(); // test worked
            //TestSetterException(); // test worked
            //TestHasMatching(); // test worked

            //TestDeckConstructor();
            //TestDeckShuffle();
            TestDeckDeal();

            Console.ReadLine();


            static void TestDeckConstructor()
            {
                Deck d = new Deck();

                Console.WriteLine("Testing deck of cards default constructor");
                Console.WriteLine("NumCards.  Expecting 52. " + d.NumCards);
                Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
                Console.WriteLine("ToString.  Expect a ton of cards in order.\n" + d.ToString());
                Console.WriteLine();
            }

            static void TestDeckShuffle()
            {
                Deck d = new Deck();
                d.Shuffle();
                Console.WriteLine("Testing deck of cards shuffle");
                Console.WriteLine("NumCards.  Expecting 52. " + d.NumCards);
                Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
                Console.WriteLine("First Card will rarely be the Ace of Clubs. " + d[0]);
                Console.WriteLine("ToString.  Expect a ton of cards in shuffled order.\n" + d.ToString());
                Console.WriteLine();
            }

            static void TestDeckDeal()
            {
                Deck d = new Deck();
                Card c = d.Deal();

                Console.WriteLine("Testing deck of cards deal");
                Console.WriteLine("NumCards.  Expecting 51. " + d.NumCards);
                Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
                Console.WriteLine("Dealt Card should be Ace of Clubs. " + c);

                // now let's deal them all and see what happens at the end
                for (int i = 1; i <= 51; i++)
                    c = d.Deal();
                Console.WriteLine("Dealt all 52 cards");
                Console.WriteLine("NumCards.  Expecting 0. " + d.NumCards);
                Console.WriteLine("IsEmpty.   Expecting true. " + d.IsEmpty);
                Console.WriteLine("Last Card should be King of Spades. " + c);
                Console.WriteLine("Dealing again should return null. Expecting true. " + (d.Deal() == null));

                Console.WriteLine();
            }

            static void TestCardConstuctors()
            {
                Console.WriteLine("Testing Card Constructors");
                Card c1 = new Card();
                Card c2 = new Card(4, 1);



                Console.WriteLine("Testing Default constructor: expecting a random number between 1 and 13, and Clubs,Diamonds,Hearts,Spades for this Suit");
                Console.WriteLine("Card's value as int: " + c1.Value + " Card's suit as int: " + c1.Suit);
                Console.WriteLine("Explict call to ToString for Default Constructor: " + c1.ToString());
                Console.WriteLine("Implicit call ToString ofr default Constructor: " + c1);
                Console.WriteLine();
                Console.WriteLine("Testing the overloaded constructor. Expecting Four of Clubs.");
                Console.WriteLine("Explicit call ToString for overloaded Constructor: " + c2.ToString());
                Console.WriteLine("Implicit call ToString for overloaded Constructor: " + c2);

            }
            static void TestOverloadedConstructorException()
            {
                Console.WriteLine();
                Console.WriteLine("Testing the overloaded Constructor with value that is out of range");
                Console.WriteLine("Card value set to 15 and suit is set to 1");
                try
                {
                    Card c1 = new Card(15, 1);
                }
                catch (ArgumentException argE)
                {
                    Console.WriteLine("Exception Worked!" + argE.Message);
                }
                Console.WriteLine("trying to set suit to 5 using Overloaded Constructor");
                try
                {
                    Card c1 = new Card(1, 5);
                }
                catch (ArgumentException argE)
                {
                    Console.WriteLine("Exception Worked!" + argE.Message);
                }
                Console.WriteLine("End");
            }
            static void TestGetters()
            {
                Card c1 = new Card(9, 3);
                Console.WriteLine();
                Console.WriteLine("Tesing Getters");
                Console.WriteLine("c1 value: expecting 9.");
                Console.WriteLine("Get c1 value: " + c1.Value);
                Console.WriteLine("c1 suit expecting 3");
                Console.WriteLine("Get c1 suit: " + c1.Suit);
            }
            static void TestSetter()
            {
                Card c1 = new Card(13, 2);
                Console.WriteLine();
                Console.WriteLine("Tesing Setters with valid parameters");
                Console.WriteLine("Current card is " + c1);
                Console.WriteLine("Calling value Setter. Expecting new value to be 12");
                c1.Value = 12;
                Console.WriteLine("After calling Value Setter: " + c1.Value);
                Console.WriteLine();
                Console.WriteLine("Calling Suit Setter. Expecting new suit to be 1");
                c1.Suit = 1;
                Console.WriteLine("After calling Suit Setter: " + c1.Suit);
            }
            static void TestSetterException()
            {
                Card c1 = new Card(11, 2);
                Console.WriteLine();
                Console.WriteLine("Testing Value setter with a value out of range");
                Console.WriteLine("Before test current card is : " + c1);
                Console.WriteLine("Card value set to 18");
                try
                {
                    c1.Value = 18;
                }
                catch (ArgumentException argE)
                {
                    Console.WriteLine("Exception worked! " + argE.Message);
                }
                Console.WriteLine("Trying to set suit to 0 using Suit Setter");
                try
                {
                    c1.Suit = 0;

                }
                catch (ArgumentException argE)
                {
                    Console.WriteLine("Exception worked! " + argE.Message);
                }
                Console.WriteLine("End");
            }
            static void TestHasMatching()
            {
                Card c1 = new Card(10, 2);
                Card c2 = new Card(10, 4);
                Console.WriteLine("c1 is: " + c1);
                Console.WriteLine("c2 is: " + c2);
                Console.WriteLine();
                Console.WriteLine("Does the suit of c1 match with c2? Expecting False");
                Console.WriteLine(c1.HasMatchingSuit(c2));
                Console.WriteLine("Does the value of c1 match with c2? Expecting False");
                Console.WriteLine(c1.HasMatchingValue(c2));
            }

        }
    }
}