using NUnit.Framework;
using Lab2_Calculator;

namespace CalcTest
{
    [TestFixture]
    public class UnitTestAddition1
    {

        Calc calc = new Calc();

        [Test]
        public void Addition_of_two_integers1()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 9); //assert
        }

    }
}

