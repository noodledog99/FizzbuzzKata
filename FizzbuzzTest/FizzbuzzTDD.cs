using System;
using FizzbuzzController;
using Xunit;

namespace FizzbuzzTest
{
    public class FizzbuzzTDD
    {
        private Fizzbuzz fizzbuzz;
        public FizzbuzzTDD()
        {
            this.fizzbuzz = new Fizzbuzz();
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(11, "11")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        public void NormalCase(int number, string expected)
        {
            var actual = fizzbuzz.Say(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        public void WhenInputDivideBy3ShouldSayFizz(int number, string expected)
        {
            var actual = fizzbuzz.Say(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenInput5ShouldSayBuzz()
        {
            var actual = fizzbuzz.Say(5);
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void WhenInput10ShouldSayBuzz()
        {
            var actual = fizzbuzz.Say(10);
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void WhenInput15ShouldSayFizzBuzz()
        {
            var actual = fizzbuzz.Say(15);
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
