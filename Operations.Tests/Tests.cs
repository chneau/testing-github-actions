using Xunit;

namespace Operations.Tests
{
    public class Tests
    {
        private readonly IOperation addition = new Addition();
        [Fact]
        public void Test_Positives()
        {
            var result = addition.Of(5, 7);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Test_Negatives()
        {
            var result = addition.Of(-5, -7);
            Assert.Equal(-12, result);
        }

        [Fact]
        public void Test_Zero()
        {
            var result = addition.Of(7, -7);
            Assert.Equal(0, result);
        }
    }
}
