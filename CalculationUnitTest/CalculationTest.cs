using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest;

namespace CalculationUnitTest
{
    public class CalculationTest
    {
        [Fact]
       public void SumTwoNumber()
        {
            var n1 = 3.3;
            var n2 = 2.2;
            var expectedResult = 5.5;
            
            var sum = Calculation.Sum(n1, n2);  

            Assert.Equal(expectedResult, sum);
        }

        [Fact]
        public void SubtractionTwoNumber()
        {
            var n1 = 5;
            var n2 = 5;
            var expectedResult = 0;

            var subtraction = Calculation.Subtraction(n1, n2);

            Assert.Equal(expectedResult, subtraction);
        }

        [Fact]
        public void MultiplicationTwoNumber()
        {
            var n1 = 5;
            var n2 = 9;
            var expectedResult = 45;
            var multiplication = Calculation.Multiplication(n1, n2);

            Assert.Equal(expectedResult, multiplication);
        }

        [Fact]
        public void DivisionTwoNumber()
        {
            var n1 = 20;
            var n2 = 4;
            var expectedResult = 5;

            var division = Calculation.Division(n1, n2);
            Assert.Equal(expectedResult, division);
        }

        [Fact]
        public void ModuleTwoNumber() 
        {
            var n1 = 5;
            var n2 = 5;
            var expectedResult = 0;

            var module = Calculation.Module(n1, n2);
            Assert.Equal(expectedResult, module);
        }
    }
}
