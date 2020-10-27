using System;
using System.Collections.Generic;

namespace InterparkingTestChess
{
    public class KnightMoves
    {
        public static List<(int row, int col)> GetAllowDestinations(int row, int col)
        {
            var allowedDestinations = new List<(int, int)>();
            var deltas = new List<(int, int)> { (2, 1), (1, 2) };
            var signs = new List<int> { -1, 1 };

            foreach (var (deltaRow, deltaColumn) in deltas)
            {
                foreach (var signDeltaRow in signs)
                {
                    foreach (var signDeltaColumn in signs)
                    {
                        var dstRow = row + signDeltaRow * deltaRow;
                        var dstCol = col + signDeltaColumn * deltaColumn;
                        if(IsInRange(dstRow) && IsInRange(dstCol))
                        {
                            allowedDestinations.Add((dstRow, dstCol));
                        }
                    }
                }
            }
            return allowedDestinations;
        }

        private static bool IsInRange(int x)
        {
            return x >= 0 && x <= 7;
        }

    }
}
