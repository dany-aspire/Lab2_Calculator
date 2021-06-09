using NUnit.Framework;
using Lab2_Calculator;

namespace CalcTest
{
    [TestFixture]
    public class UnitTestDivision1
    {

        Calc calc = new Calc();

        [Test]
        public void Division_of_two_integers1()
        {
            double a = 6, b = 2;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 3); //assert
        }



    }
}

