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
        public void Add_MoreThanTwoNumbers_ShouldReturnSum()
        {
            int actual = StringCalculator.Add("5, 60, 10, 20, 100") ;
            int expected = 195;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_TwoNumbers_ShouldReturnSum()
        {
            int actual = StringCalculator.Add("1,2");
            int expected = 3;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_WhenGivenStringWithLineBreaksAndCommas_ShouldReturnSum()
        {
            int actual = StringCalculator.Add("1, 5, \n5 ,5 \n2");
            int expected = 18;
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Add_WhenGivenMultipleDelimiters_ShouldReturnSum()
        {
            int actual = StringCalculator.Add("\\;\n1;2");
            int expected = 3;
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Add_WhenGivenNegativeNumbers_ShouldReturnException()
        {
            string actual = Assert.Throws<Exception>(() =>StringCalculator.Add("\\;\n1;-2")).Message;
            string expected = "Negatives not allowed : -2";
            
            Assert.Equal(expected, actual);
   
            
        }
        
        [Fact]
        public void Add_WhenGivenMultipleNegativeNumbers_ShouldReturnException()
        {
            string actual = Assert.Throws<Exception>(() =>StringCalculator.Add("\\;\n1;-2, -4")).Message;
            string expected = "Negatives not allowed : -2 -4";
            
            Assert.Equal(expected, actual);
   
            
        }
        
        
        
    }
}