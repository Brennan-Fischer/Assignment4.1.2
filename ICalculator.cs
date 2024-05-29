using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1._2
{
    public interface ICalculator
    {
        public void Add(string userInput1, string userInput2)
        {
            double sum = Convert.ToDouble(userInput1) + Convert.ToDouble(userInput2);
        }
        public void Subtract()
        {

        }
        public void Multiply()
        {

        }
        public void Divide()
        {

        }
    }
}
