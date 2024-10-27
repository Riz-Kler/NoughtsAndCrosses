using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    public class Game
    {
        public int AddCounter
        { get; private set; }
        private readonly State[] _board = new State[9];

        public Game()
        {
            for (var i = 0; i < _board.Length; i++ )
            {
                _board[i] = State.Unset;
            }
        }

        public void YourMove(int index)
        {
            if (index < 1 || index > 9)
                throw new ArgumentOutOfRangeException();
            if (GetState(index) != State.Unset)
                throw new InvalidOperationException();

            _board[index - 1] = AddCounter % 2 == 0 ? State.Cross : State.Nought;
           
            AddCounter++;
        }

        private State GetState(int index)
        {
           return _board[index - 1] ;
        }
    }
}
