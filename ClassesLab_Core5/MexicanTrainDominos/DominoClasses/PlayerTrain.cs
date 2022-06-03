using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DominoClasses
{
    public class PlayerTrain : Train
    {

        protected Hand hand;
        protected bool isOpen = false;

        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
        }

        public void Open()
        {
            isOpen = true;
        }

        public void Close()
        {
            isOpen = false;
        }
       
        public override bool IsPlayable(Hand h, Domino d, out bool mustflip)
        {
            if (IsOpen)
                return IsPlayable(d, out mustflip);
            else if (h == hand)
                return IsPlayable(d, out mustflip);
            else
                mustflip = false;
            return false;
        }
        public PlayerTrain(Hand h): base()
        {
            hand = h;
        }
        public PlayerTrain(Hand h, int engineValue) : base(engineValue)
        {
            hand = h;
        }

    }
}
