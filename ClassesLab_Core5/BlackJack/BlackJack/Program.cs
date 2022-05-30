using System;
using CardClasses;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            d.Shuffle();

            BJHand player = new BJHand(d, 2);
            BJHand dealer = new BJHand(d, 2);

            player.AddCard(d.Deal());


            Console.WriteLine(player.ToString());
            Console.WriteLine();
        }
    }
}
