using System;
namespace DominoClasses
{
    public class MexicanTrain : Train
    {
        public override bool IsPlayable(Hand h, Domino d, out bool mustFlip)
        {
            return base.IsPlayable(d, out mustFlip);
        }

        public MexicanTrain() : base() { }

        public MexicanTrain(int engineValue) : base(engineValue) { }
    }
}
