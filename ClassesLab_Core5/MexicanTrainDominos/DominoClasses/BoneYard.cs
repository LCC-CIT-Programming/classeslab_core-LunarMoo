using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DominoClasses
{
    public class BoneYard
    { 
        private List<Domino> dominos = new List<Domino>();

        public BoneYard(int maxDots)
        {
            for (int side1 = 0; side1 <= 6; side1++)
                for (int side2 = 1; side2 <= 6; side2++)
                    dominos.Add(new Domino(side1, side2));
        }

        public Domino this[int index]
        {
            get
            {
                return dominos[index];
            }
            set
            {
                dominos[index] = value;
            }
        }
        

        public int DominosRemaining
        {
            get
            {
                return dominos.Count;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return (dominos.Count == 0);
            }
        }

        public Domino Draw()
        {
            if (!IsEmpty)
            {
                Domino c = dominos[0];
                dominos.Remove(c);
                return c;
            }
            return null;
        }

        public void Shuffle()
        {
            Random gen = new Random();
            for (int i = 0; i < DominosRemaining; i++)
            {
                int rnd = gen.Next(0, DominosRemaining);
                Domino c = dominos[rnd];
                dominos[rnd] = dominos[i];
                dominos[i] = c;
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach (Domino c in dominos)
                output += (c.ToString() + "\n");
            return output;
        }
    }
    
}
