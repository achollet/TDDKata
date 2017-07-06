using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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

    }
}
