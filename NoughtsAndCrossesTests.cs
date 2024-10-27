using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace NoughtsAndCrosses
{
    [TestFixture]
    public class NoughtsAndCrossesTests
    {
        [Test]
        public void StartGame_NoMoves()
        {
            Game game = new Game();
            Assert.AreEqual(0, game.AddCounter);
        }

        [Test]
        public void YourMove_CounterShifts()
        {
            Game game = new Game();
            game.YourMove(1);

            Assert.AreEqual(1, game.AddCounter);
        }

        [Test]
        public void AnInvalidMove_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                var Game = new Game();
                Game.YourMove(0);
            });
        }

        [Test]
        public void SameSquareMove_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var Game = new Game();
                
                Game.YourMove(1);
                Game.YourMove(1);
            });
        }
    }
}
