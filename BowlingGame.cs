using System;
namespace TDDKata
{
    public class BowlingGame
    {
        protected int _score;

        public Frame[] Frames { get; set; }

        public int Score()
        {
            for (int f = 0; f < Frames.Length; f++)
            {
                _score += Frames[f].FrameScore();

                if (Frames[f].IsStrike)
                    _score += Frames[f + 1].FrameScore();

                if (Frames[f].IsSpare)
                    _score += Frames[f + 1].Rolls[1];
            }

            return _score;
        }
    }
}
