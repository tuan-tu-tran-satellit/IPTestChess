using FluentAssertions;
using InterparkingTestChess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using MoveList = System.Collections.Generic.List<(int, int)>;
namespace Tests
{
    [TestClass]
    public class KnightMovesTest
    {
        [TestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void TestAllowedDestinations((int, int) start, List<(int, int)> expectedAllowedDestinations)
        {
            var (row, col) = start;
            var result = KnightMoves.GetAllowDestinations(row, col);
            result.Should().BeEquivalentTo(expectedAllowedDestinations);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[]
            {
                (4,4), new List<(int,int)> { (3,2), (2,3), (2,5), (3,6), (5,6), (6,5), (6,3), (5,2)}
            };
            yield return new object[]
            {
                (0,0), new MoveList { (1,2),(2,1) }
            };
            yield return new object[]
            {
                (0,1), new MoveList{(1,3), (2,2) , (2,0) }
            };
            yield return new object[]
            {
                (0,3), new MoveList{ (1,5), (2,4), (2,2), (1,1) }

            };
            yield return new object[]
            {
                (0,6), new MoveList{ (2,7), (2,5), (1,4) }
            };
            yield return new object[]
            {
                (0,7), new MoveList { (2,6), (1,5) }
            };
            yield return new object[]
            {
                (1,7), new MoveList { (3,6), (2,5), (0,5) }
            };
            yield return new object[]
            {
                (4,7), new MoveList { (6,6), (5,5), (3,5), (2,6) }
            };
            yield return new object[]
            {
                (4,6), new MoveList { (2,5), (2,7), (6,7), (6,5), (5,4), (3,4) }
            };
            yield return new object[]
            {
                (7,3), new MoveList { (6,1), (5,2), (5,4), (6,5) }
            };
            yield return new object[]
            {
                (4,1), new MoveList { (2,0), (2,2), (3,3), (5,3), (6,2), (6,0) }
            };
        }
    }
}
