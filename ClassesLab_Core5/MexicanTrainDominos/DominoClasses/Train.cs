using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DominoClasses
{
    public abstract class Train : IEnumerable<Domino>
    {
        protected List<Domino> dominos;
        protected int engineValue;

        public abstract bool IsPlayable(Hand h, Domino d, out bool mustFlip);

        public Train()
        {
            engineValue = 12;
            dominos = new List<Domino>();
        }

        public Train(int engValue)
        {
            engineValue = engValue;
            dominos = new List<Domino>();
        }

        public int Count
        {
            get
            {
                return dominos.Count;
            }
        }

        public int EngineValue
        {
            get
            {
                return engineValue;
            }
            set
            {
                engineValue = value;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return dominos.Count == 0;
            }
        }

        public Domino LastDomino
        {
            get
            {
                if (IsEmpty)
                    return null;
                else
                    return dominos[dominos.Count - 1];
            }
        }

        public int PlayableValue
        {
            get
            {
                if (IsEmpty)
                    return engineValue;
                else
                    return LastDomino.Side2;
            }

        }

        public void Add(Domino d)
        {
            dominos.Add(d);
        }

        public Domino this[int index]
        {
            get
            {
                return dominos[index];
            }
        }

        protected bool IsPlayable(Domino d, out bool mustFlip)
        {
            if (PlayableValue == d.Side1)
            {
                mustFlip = false;
                return true;
            }
            else if (PlayableValue == d.Side2)
            {
                mustFlip = true;
                return true;
            }
            else
            {
                mustFlip = false;
                return false;
            }
        }

        // assumes the domino has already been removed from the hand
        public void Play(Hand h, Domino d)
        {
            bool mustFlip = false;
            if (IsPlayable(h, d, out mustFlip))
            {
                if (mustFlip)
                    d.Flip();
                Add(d);
            }
            else
                throw new Exception("Domino " + d.ToString() + " does not match last domino in the train and cannot be played.");
        }

        public override string ToString()
        {
            string output = "";
            foreach (Domino d in dominos)
                output += d.ToString() + "\t";
            output += "\n";
            return output;
        }

        public IEnumerator<Domino> GetEnumerator()
        {
            return ((IEnumerable<Domino>)dominos).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)dominos).GetEnumerator();
        }
    }
}
