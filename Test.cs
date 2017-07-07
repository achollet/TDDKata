using NUnit.Framework;

namespace TDDKata
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void ShouldReturn20WhenScoring20_1()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            bowlingGame.Frames = new Frame[10] { frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(20, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn21WhenScoring19_1And1_2()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frame1_2 = new Frame()
            {
                Rolls = new int[] { 1, 2 }
            };

            bowlingGame.Frames = new Frame[10] { frame1_2, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(21, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn30WhenScoring18_1And1_Strike()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frameStrike = new Frame()
            {
                Rolls = new int[] { 10 }
            };
            bowlingGame.Frames = new Frame[10] { frameStrike, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(30, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn30WhenScoring18_1And1_Strike2nd()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frameStrike = new Frame()
            {
                Rolls = new int[] { 10 }
            };
            bowlingGame.Frames = new Frame[10] { frame1_1, frameStrike, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(30, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn40WhenScoring16_1And2_Strike()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frameStrike = new Frame()
            {
                Rolls = new int[] { 10 }
            };
            bowlingGame.Frames = new Frame[10] { frame1_1, frameStrike, frame1_1, frameStrike, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(40, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn29WhenScoring18_1AndOneSpare()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frameSpare = new Frame()
            {
                Rolls = new int[] { 5, 5 }
            };
            bowlingGame.Frames = new Frame[10] { frame1_1, frameSpare, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(29, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn37WhenScoring17_1AndOneSpareAnd1_1()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frame5_1 = new Frame()
            {
                Rolls = new int[] { 5, 1 }
            };

            var frameSpare = new Frame()
            {
                Rolls = new int[] { 5, 5 }
            };
            bowlingGame.Frames = new Frame[10] { frameSpare, frame5_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(37, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn28WhenScoring18_1And2_5()
        {
            var bowlingGame = new BowlingGame();
            var frame1_1 = new Frame()
            {
                Rolls = new int[] { 1, 1 }
            };

            var frame2 = new Frame()
            {
                Rolls = new int[] { 1, 5 }
            };

            var frame3 = new Frame()
            {
                Rolls = new int[] { 5, 1 }
            };


            bowlingGame.Frames = new Frame[10] { frame1_1, frame2, frame3, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1, frame1_1 };

            Assert.AreEqual(28, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn30WhenScoringStikeAtLastFrame()
        {
            var bowlingGame = new BowlingGame();
            var frame1_0 = new Frame()
            {
                Rolls = new int[] { 1, 0 }
            };

            var frame1_2 = new Frame()
            {
                Rolls = new int[] { 1, 2 }
            };

            var strikeFrame = new Frame()
            {
                Rolls = new int[] { 10 }
            };

            var extraFrame = new Frame()
            {
                Rolls = new int[] { 5, 4 }
            };


            bowlingGame.Frames = new Frame[11] { frame1_0, frame1_0, frame1_0, frame1_0, frame1_0, frame1_2, frame1_0, frame1_0, frame1_0, strikeFrame, extraFrame };

            Assert.AreEqual(30, bowlingGame.Score());
        }

        [Test()]
        public void ShouldReturn26WhenScoringSpareAtLastFrame()
        {
            var bowlingGame = new BowlingGame();
            var frame1_0 = new Frame()
            {
                Rolls = new int[] { 1, 0 }
            };

            var frame1_2 = new Frame()
            {
                Rolls = new int[] { 1, 2 }
            };

            var spareFrame = new Frame()
            {
                Rolls = new int[] { 9, 1 }
            };

            var extraFrame = new Frame()
            {
                Rolls = new int[] { 5 }
            };


            bowlingGame.Frames = new Frame[11] { frame1_0, frame1_0, frame1_0, frame1_0, frame1_0, frame1_2, frame1_0, frame1_0, frame1_0, spareFrame, extraFrame };

            Assert.AreEqual(26, bowlingGame.Score());
        }
    }
}
