using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoughtsAndCrossesGame;
using NoughtsAndCrossesProject.TicTacToe;

namespace NoughtsAndCrossesGame
{
    class Program
    {
        private static Game g = new Game();
        static void Main(string[] args)
        {
            Console.WriteLine(GetOutputState());

            while (g.GetWinner() == Winner.Incomplete )
            {
                int index = int.Parse(Console.ReadLine());
                g.AddCounter(index);

                Console.WriteLine();
                Console.WriteLine(GetOutputState());
            }

            Console.WriteLine($"Result: {g.GetWinner()}");
            Console.ReadLine();
        }

        private static string GetOutputState()
        {
            var sb = new StringBuilder();

            for (int i = 1; i <= 7; i++)
            {
                sb.AppendLine("     |     |     ")
                                   .AppendLine(
                                       $"  {GetOutputChar(i)}  |  {GetOutputChar(i + 1)}  |  {GetOutputChar(i + 2)}  ")
                                   .AppendLine("_____|_____|_____|");
            }

            return sb.ToString();
        }

            private static string GetOutputChar(int index)
            {
                State state = g.GetState(index);
                if (state == State.Unset)
                    return index.ToString();
                return state == State.Cross ? "X" : "O";
            }
    }
}
