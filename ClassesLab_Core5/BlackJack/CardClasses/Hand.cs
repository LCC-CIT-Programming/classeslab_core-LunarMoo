using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class Hand
    {

        protected List<Card> cards = new List<Card>();

        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }

        public Card Discard(int index)
        {
            Card c = cards[index];
            cards.Remove(c);
            return c;
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public Hand() { }

        public Hand(Deck d, int numCards)
        {
            for (int i = 1; i <= numCards; i++)
                cards.Add(d.Deal());
        }

        public bool HasCard(Card c)
        {
            return cards.Contains(c);
        }

        public bool HasCard(int value)
        {
            return IndexOf(value) != -1;
        }

        public bool HasCard(int value, int suit)
        {
            return IndexOf(value, suit) != -1;
        }

        public int IndexOf(Card c)
        {
            return cards.IndexOf(c);
        }

        public int IndexOf(int value)
        {
            int i = 0;
            foreach (Card c in cards)
            {
                if (c.Value == value)
                    return 1;
            }
            return -1;
        }

        public int IndexOf(int value, int suit)
        {
            int i = 0;
            foreach(Card c in cards)
            {
                if (c.Value == value && c.Suit == suit)
                    return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            string output = "";
            foreach (Card c in cards)
                output += (c.ToString() + "\n");
            return output;
        }
    }
}

