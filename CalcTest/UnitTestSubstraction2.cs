using NUnit.Framework;
using Lab2_Calculator;

namespace CalcTest
{
    [TestFixture]
    public class UnitTestSubstraction2
    {

        Calc calc = new Calc();

        [Test]
        public void Substraction_of_two_integers2()
        {
            double a = -5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, -9); //assert
        }



    }
}

