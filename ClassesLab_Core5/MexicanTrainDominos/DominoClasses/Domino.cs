using System;

namespace DominoClasses
{
    public class Domino
    {
        private int side1;
        private int side2;

        public int Side1
        {
            get
            {
                return side1;
            }
            // If there's a setter, it MUST make sure that the value for side1 is correct!
            // When it's not, the correct approach is to throw an exception
            set
            {
                if (value >= 0 && value <= 12)
                    side1 = value;
                else
                    throw new ArgumentException("Value must be between 0 and 12.");
            }
        }

        public int Side2
        {
            get
            {
                return side2;
            }
            set
            {
                if (value >= 0 && value <= 12)
                    side2 = value;
                else
                    throw new ArgumentException("Value must be between 0 and 12.");
            }
        }

        // notice that I'm calling setters here because of validation
        public Domino()
        {
            Side1 = 0;
            Side2 = 0;
        }

        // calling setters here too
        public Domino(int p1, int p2)
        {
            Side1 = p1;
            Side2 = p2;
        }

        public void Flip()
        {
            int temp = side1;
            side1 = side2;
            side2 = temp;
        }

        // this is a READ-ONLY property
        public int Score
        {
            get
            {
                return side1 + side2;
            }
        }

        // this method could also have been a read-only property
        public bool IsDouble()
        {
            if (side1 == side2)
                return true;
            else
                return false;
        }
        /*
        public bool IsDouble
        {
            get
            {
                if (side1 == side2)
                    return true;
                else
                    return false;
            }
        }
        */

        public override string ToString()
        {
            return String.Format("Side 1: {0}  Side 2: {1}", side1, side2);
        }
    }
}
