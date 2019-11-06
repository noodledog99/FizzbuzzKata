using System;
using FizzbuzzController;
using Xunit;

namespace FizzbuzzTest
{
    public class FizzbuzzTDD
    {
        private Fizzbuzz fizzbuzz;
        public FizzbuzzTDD(){
            this.fizzbuzz = new Fizzbuzz();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void NormalCase(int number, string expected)
        {
            var actual = fizzbuzz.Say(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenInput3ShouldSayFizz()
        {
            var actual = fizzbuzz.Say(3);
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void WhenInput5ShouldSayBuzz()
        {
            var actual = fizzbuzz.Say(5);
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void WhenInput6ShouldSayFizz()
        {
            var actual = fizzbuzz.Say(6);
            Assert.Equal("Fizz", actual);
        }
    }
}
