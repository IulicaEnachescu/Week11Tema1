using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GenericCalculator;

namespace GenericCalculatorTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(85, 418, 503)]
        [TestCase(85, 418, 503)]
        [TestCase(55587, 89478, 145065)]
        [TestCase(879.2, 5843.2, 6722.4)]

        public void Should_Add_Two_Numbers<T>(T input1, T input2, double expected)
        {   //arrange
            //act
            double actual = Calculator.Calculate("a", input1, input2);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [Test]
        [TestCase(1114579, 8574, 1106005)]
        [TestCase(254, 657, -403)]
        [TestCase(214.5, 987.2547, -772.755)]
        [TestCase(0.574, 0.547, 0.027)]
        public void Should_Substract_Two_Numbers<T>(T input1, T input2, double expected)
        {
            double actual = Calculator.Calculate("s", input1, input2);
            Assert.AreEqual(actual, expected);
        }
        [Test]
        [TestCase(3, 3, 9)]
        [TestCase(1247, 8574, 10691778)]
        [TestCase(254.5, 587.5, 149518.75)]
        [TestCase(149518.75, 8, 1196150)]
        public void Should_Multiply_Two_Numbers<T>(T input1, T input2, double expected)
        {
            double actual = Calculator.Calculate("m", input1, input2);
            Assert.AreEqual(actual, expected);
        }


        [Test]
        [TestCase(9, 3, 3)]
        [TestCase(9, 2, 4.5)]
        [TestCase(254.5, 58, 4.3879)]
        [TestCase(78, 9, 8.6669)]

        
        public void Should_Divide_Two_Numbers<T>(T input1, T input2, double expec)
        {
            double actual = Calculator.Calculate("d", input1, input2);
            
            Assert.That(expec, Is.EqualTo(actual).Within(.0005));

        }
        [Test]
        public void Should_Throw_DivideByZeroException()
        {
            int input1 = 1;
           // int input2 = 0;
            //assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Calculate("d", input1, 0));
        }
        [Test]
        public void Should_Throw_InvalidOperationException()
        {
            //int input1 = 1;
            // int input2 = 0;
            //assert
            Assert.Throws<InvalidOperationException>(() => Calculator.Calculate("d", 0, 0));
        }
    }
}
