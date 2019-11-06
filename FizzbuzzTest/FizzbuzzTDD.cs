using System;
using FizzbuzzController;
using Xunit;

namespace FizzbuzzTest
{
    public class FizzbuzzTDD

    {
        [Fact]
        public void WhenInput1ShouldSay1()
        {
            var fizzbuzz = new Fizzbuzz();
            var actual = fizzbuzz.Say(1);
            Assert.Equal("1",actual);
        }
    }
}
