using System;
namespace TDDKata
{
    public class Frame
    {
        public int[] Rolls { get; set; }

        public bool IsStrike
        {
            get
            {
                if (Rolls.Length == 1)
                    return true;

                return false;
            }
        }

        public bool IsSpare
        {
            get
            {
                if (Rolls.Length > 1 && Rolls.Sum() == 10)
                    return true;

                return false;
            }

        }

        public int FrameScore()
        {
            return Rolls.Sum();
        }


    }
}
