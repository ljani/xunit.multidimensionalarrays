using System.Collections.Generic;
using Xunit;

namespace xunit.multidimensionalarrays
{
    public class Tests
    {
        public static IEnumerable<object[]> TestData => new[]
        {
            new object[]
            {
                new string[,]
                {
                    {
                        "Test"
                    }
                }
            }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestMultidimensionalArray(string[,] array)
        {
            Assert.Equal(2, array.Rank);
        }
    }
}