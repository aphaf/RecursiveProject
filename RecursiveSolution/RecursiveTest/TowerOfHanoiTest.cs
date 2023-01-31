using RecursiveLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveTest
{
    public class TowerOfHanoiTest
    {
        [Fact]
        public void ShouldFindMovesForToH()
        {
            TowerOfHanoi toh = new TowerOfHanoi();
            List<string> moves = toh.FindMovesForToH(3, "Start", "Middle", "End", new List<string>());

            int expectedNumOfMoves = 7;
            int actualNumOfMoves = moves.Count;

            Assert.Equal(expectedNumOfMoves, actualNumOfMoves);
        }
    }
}
