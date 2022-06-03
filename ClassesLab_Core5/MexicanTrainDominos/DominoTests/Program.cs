using System;
using DominoClasses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DominoTests
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestDominoConstructors();
            //TestDominoToString();
            //TestDominoPropertyGetters();
            //TestDominoPropertySetters();
            //TestDominoFlip();
            //TestDominoScore();
            //TestDominoIsDouble();
            //TestDominoPropertySettersWithExceptions();


            //TestBoneYardDeal();
            //TestBoneYardConstructor();
            //TestBoneYardShuffle();

            //TestSorting();
            //TestForEach();
        }
        
        static void TestForEach()
        {
            MexicanTrain mt = new MexicanTrain();
            mt.Add(new Domino(1, 2));
            mt.Add(new Domino(1, 5));
            mt.Add(new Domino(3, 4));
            mt.Add(new Domino(6, 6));

            foreach (Domino d in mt)
            {
                Console.WriteLine(d);
            }
        }
        static void TestSorting()
        {
            BoneYard b = new BoneYard();
            b.Shuffle();
            Console.WriteLine(b);
            b.Sort();
            Console.WriteLine(b);
        }
        static void TestBoneYardConstructor()
        {
            BoneYard d = new BoneYard();

            Console.WriteLine("Testing deck of cards default constructor");
            Console.WriteLine("NumCards.  Expecting 52. " + d.DominosRemaining);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("ToString.  Expect a ton of cards in order.\n" + d.ToString());
            Console.WriteLine();
        }

        static void TestBoneYardShuffle()
        {
            BoneYard d = new BoneYard();
            d.Shuffle();
            Console.WriteLine("Testing deck of cards shuffle");
            Console.WriteLine("NumCards.  Expecting 52. " + d.DominosRemaining);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("First Card will rarely be the Ace of Clubs. " + d[0]);
            Console.WriteLine("ToString.  Expect a ton of cards in shuffled order.\n" + d.ToString());
            Console.WriteLine();
        }

        static void TestBoneYardDeal()
        {
            BoneYard d = new BoneYard();
            Domino c = d.Draw();

            Console.WriteLine("Testing deck of cards deal");
            Console.WriteLine("NumCards.  Expecting 51. " + d.DominosRemaining);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("Dealt Card should be Ace of Clubs. " + c);

            // now let's deal them all and see what happens at the end
            for (int i = 1; i <= 51; i++)
                c = d.Draw();
            Console.WriteLine("Dealt all 52 cards");
            Console.WriteLine("NumCards.  Expecting 0. " + d.DominosRemaining);
            Console.WriteLine("IsEmpty.   Expecting true. " + d.IsEmpty);
            Console.WriteLine("Last Card should be King of Spades. " + c);
            Console.WriteLine("Dealing again should return null. Expecting true. " + (d.Draw() == null));

            Console.WriteLine();
        }
        static void TestDominoConstructors()
        {
            Domino d1 = new Domino();
            Domino d2 = new Domino(12, 6);

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values (0, 0). " + d1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting 12, 6 " + d2.ToString());
            Console.WriteLine();
        }

        static void TestDominoToString()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting 12, 6 " + d1.ToString());
            Console.WriteLine("Expecting 12, 6 " + d1);
            Console.WriteLine();
        }

        static void TestDominoPropertyGetters()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing getters");
            Console.WriteLine("Side 1.  Expecting 12. " + d1.Side1);
            Console.WriteLine("Side 2.  Expecting 6. " + d1.Side2);
            Console.WriteLine();
        }

        static void TestDominoPropertySetters()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing setters");
            d1.Side1 = 4;
            d1.Side2 = 5;
            Console.WriteLine("Expecting 4, 5 " + d1);
            Console.WriteLine();
        }

        static void TestDominoPropertySettersWithExceptions()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing invalid setter values");
            try
            {
                d1.Side1 = -1;
            }
            catch
            {
                Console.WriteLine("Threw an exception when Side1 is negative");
                Console.WriteLine("Side1 should still be 12 " + d1.Side1);
            }
            try
            {
                d1.Side1 = 13;
            }
            catch
            {
                Console.WriteLine("Threw an exception when Side1 is more than 12");
                Console.WriteLine("Side1 should still be 12 " + d1.Side1);
            }
            try
            {
                d1.Side2 = -1;
            }
            catch
            {
                Console.WriteLine("Threw an exception when Side2 is negative");
                Console.WriteLine("Side2 should still be 6 " + d1.Side2);
            }
            try
            {
                d1.Side2 = 13;
            }
            catch
            {
                Console.WriteLine("Threw an exception when Side2 is more than 12");
                Console.WriteLine("Side2 should still be 6 " + d1.Side2);
            }
            try
            {
                d1 = new Domino(-1, 15);
            }
            catch
            {
                Console.WriteLine("Constructor should also throw an exception when values are invalid");
                Console.WriteLine("d1 is now " + d1);
            }
            Console.WriteLine();
        }

        static void TestDominoScore()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing Score");
            Console.WriteLine("Score.  Expecting 18. " + d1.Score);
            Console.WriteLine();
        }

        static void TestDominoIsDouble()
        {
            Domino d1 = new Domino(12, 12);
            Domino d2 = new Domino(12, 6);

            Console.WriteLine("Testing IsDouble");
            Console.WriteLine("12 and 12.  Expecting true. " + d1.IsDouble());
            Console.WriteLine("12 and 6.  Expecting false. " + d2.IsDouble());
            Console.WriteLine();
        }

        static void TestDominoFlip()
        {
            Domino d1 = new Domino(12, 6);

            Console.WriteLine("Testing Flip");
            Console.WriteLine("Before.  Expecting 12, 6. " + d1);
            d1.Flip();
            Console.WriteLine("After.  Expecting 6, 12. " + d1);
            Console.WriteLine();
        }
    }
}
