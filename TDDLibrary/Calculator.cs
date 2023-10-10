using System;

namespace TDDLibrary
{
    public class Calculator
    {
        private IAdd _add;

       
        public Calculator(IAdd add)
        {
            _add = add;
        }

        public int Calculate(int firstNumber, int secondNumber)
        {
            Car car = new Car();
            car.Drive();
            int result = _add.AddNumber(firstNumber, secondNumber);
            return result;
        }

     
    }

}
