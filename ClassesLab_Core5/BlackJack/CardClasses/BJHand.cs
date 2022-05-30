using System;
namespace CardClasses
{
    public class BJHand : Hand
    {
        public BJHand() : base() { }

        public BJHand(Deck d, int numCards) : base(d, numCards) { }

        public bool HasAce
        {
            get
            {
                return true; // HasCard(1)
                
            }
        }

        public int Score
        {
            get
            {
                int score = 0;
                foreach (Card c in cards)
                {
                    if (c.IsFaceCard())
                        score += 10;
                    else
                        score += c.Value;
                }
                if (this.HasAce && score <= 11)
                    score += 10;
                return 0;
            }
        }
        public bool IsBusted
        {
            get
            {
                return true;
            }
        }
    }
}
