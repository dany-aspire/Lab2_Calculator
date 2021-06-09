using NUnit.Framework;
using Lab2_Calculator;

namespace CalcTest
{
    [TestFixture]
    public class UnitTestMultiplication2
    {

        Calc calc = new Calc();

        [Test]
        public void Multiplication_of_two_integers2()
        {
            double a = -5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, -20); //assert
        }



    }
}

