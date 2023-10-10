using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLibrary
{
    public interface IAdd
    {
        int AddNumber(int firstNumber, int secondNumber);
    }

    public class Add : IAdd
    {
        public int AddNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }

    public class SubAdd : IAdd
    {
        public int AddNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
