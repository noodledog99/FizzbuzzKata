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

        [Fact]
        public void WhenInput1ShouldSay1()
        {
            var actual = fizzbuzz.Say(1);
            Assert.Equal("1",actual);
        }

        [Fact]
        public void WhenInput2ShouldSay2()
        {
            var actual = fizzbuzz.Say(2);
            Assert.Equal("2",actual);
        }

        [Fact]
        public void WhenInput3ShouldSayFizz()
        {
            var actual = fizzbuzz.Say(3);
            Assert.Equal("Fizz",actual);
        }
    }
}
