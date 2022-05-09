using System;

namespace CardClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();

        private int value;
        private int suit;

        public Card()
        {
            value = 1;
            suit = 1;
        }

        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (this.value <= 13 || this.value >= 1)
                    this.value = value;
                else
                    throw new ArgumentException("Value must be between 1 and 13");

            }
        }

        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                if (value <= 4 || value >= 1)
                    this.suit = value;
                else
                    throw new ArgumentException("Value must be between 1 and 4");
            }
        }
        public bool HasMatchingSuit(Card other)
        {
            if (this.suit == other.suit)
                return true;
            else
                return false;
        }
        public bool HasMatchingValue(Card other)
        {
            if (this.value == other.suit)
                return true;
            else
                return false;
        }
        public bool IsAce()
        {
            if (value == 1)
                return true;

            else
                return false;
        }
        public bool IsBlack()
        {
            bool black;
            if (suit == 1)
            {
                black = true;
                return black;
            }
            else
                return false;
        }
        public bool IsClub()
        {
            if (suit == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsDiamond()
        {
            if (suit == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsFaceCard()
        {
            if (suit == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsHeart()
        {
            if (suit == 1)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsRed()
        {
            bool red;
            if (suit == 1)
            {
                red = true;
                return red;
            }
            else
                return false;
        }
        public bool IsSpade()
        {
            if (suit == 1)
            {
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
    }
}