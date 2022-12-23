using System;
using Xunit;
using teamcity;


namespace TestProject1
{
    public class UnitTest1
    {
        //‘јкториал тройной, если что
        [Fact]
        public void Test1()
        {
            Assert.True(Program.tripleFactorial(5) == 360);
        }

        [Fact]
        public void Test5()
        {
            Assert.True(Program.tripleFactorial(3) > 17);
        }

        [Fact]
        public void Test15()
        {
            Assert.False(Program.tripleFactorial(15) < 1000000000);
        }
    }
}
