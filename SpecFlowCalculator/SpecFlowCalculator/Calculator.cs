using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public string Add()
        {
            return (FirstNumber + SecondNumber).ToString();
        }

        public string Multiply()
        {
            return (FirstNumber * SecondNumber).ToString();
        }

        public string Divide()
        {
            if (SecondNumber != 0)
            {
                return (FirstNumber / SecondNumber).ToString();
            } else
            {
                return "You cannot divide by zero.";
            }
        }
    }
}
