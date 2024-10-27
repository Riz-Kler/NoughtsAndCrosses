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
    }

    public class Game
    {
        public int AddCounter
            { get; private set; }

        public void YourMove(int index)
        {
            if (index < 1 || index > 9)
                throw new ArgumentOutOfRangeException();
            AddCounter++;
        }
    }
}
