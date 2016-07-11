using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FizzBuzzGame;
using Shouldly;

namespace TestFizzBuzzGame
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void TestFirstTwoNumbers()
        {
            var expectedList = new List<String> { "1", "2" };
            var actualList = FizzBuzz.GetFizzBuzzList(2);

            actualList.ShouldBe(expecteddList);
        }

        [Test]
        public void TestThrees()
        {
            var expectedList = new List<String> { "1", "2", "Fizz" };
            var actualList = FizzBuzz.GetFizzBuzzList(3);

            actualList.ShouldBe(expectedList);
        }

        [Test]
        public void TestFives()
        {
            var expectedList = new List<String> { "1", "2", "Fizz", "4", "Buzz" };
            var actualList = FizzBuzz.GetFizzBuzzList(5);

            actualList.ShouldBe(expectedList);
        }

        [Test]
        public void TestThreeandFive()
        {
            var testElement = 15;

            var expectedValue = "FizzBuzz";
            var actualList = FizzBuzz.GetFizzBuzzList(testElement);
            var actualValue = actualList.ElementAt(testElement - 1);

            actualValue.ShouldBe(expectedValue);
        }
    }
}


