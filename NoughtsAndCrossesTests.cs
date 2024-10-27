using NUnit.Framework;

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
    }

    public class Game
    {
        public int AddCounter
            { get; private set; }
    }
}
