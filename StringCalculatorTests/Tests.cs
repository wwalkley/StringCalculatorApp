using System;
using StringCalculatorApp;
using Xunit;

namespace StringCalculatorTests
{
    public class Tests
    {
        [Fact]
        public void Add_EmptyString_ShouldReturnZero()
        {
            int actual = StringCalculator.Add("");
            int expected = 0;
            
            Assert.Equal(expected, actual );
        }

        [Fact]
        public void Add_MoreThanTwoNumbers_ShouldThrowError()
        {
            Assert.Throws<Exception>(() => StringCalculator.Add("1,2,3")) ;
        }

        [Fact]
        public void Add_TwoNumbers_ShouldReturnSum()
        {
            int actual = StringCalculator.Add("1,2");
            int expected = 3;
            
            Assert.Equal(expected, actual);
        }
        
    }
}