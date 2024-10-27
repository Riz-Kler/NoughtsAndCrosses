using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

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

            [Test]
            
            public void  YourMoves_SetCorrectState()
            {
                Game game = new Game();

               YourMoves(game, 1, 2, 3, 4);

              Assert.AreEqual(State.Cross, game.GetState(1));
              Assert.AreEqual(State.Nought, game.GetState(2));
              Assert.AreEqual(State.Cross, game.GetState(3));
              Assert.AreEqual(State.Nought, game.GetState(4));
        }

        private void YourMoves(Game game, params int[] indexes)
        {
            foreach (var index in indexes)
                game.YourMove(index);
        }
        
    }
}
