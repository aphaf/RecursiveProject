using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveLibrary
{
    public class TowerOfHanoi
    {
        public List<string> FindMovesForToH(int n, string start, string middle, string end, List<string> moves)
        {
            //ryans solution 
            if (n > 0)
            {
                FindMovesForToH(n - 1, start, end, middle, moves);
                moves.Add($"Move disk from {start} to {end}");
                FindMovesForToH(n - 1, middle, start, end, moves);
            }
            return moves;
        }
    }
}