using System;
using System.Linq;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int[] nNumbers { get; set; }

        public string[] operation { get; set; }

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

        public string AddN()
        {
            int res = 0;
            foreach (int number in nNumbers)
            {
                res += number;
            }
            return res.ToString();
        }

        public string MultiplyN()
        {
            int res = 1;
            foreach (int number in nNumbers)
            {
                res *= number;
            }
            return res.ToString();
        }

        public string DivideN()
        {
            int res = nNumbers.First();

            foreach (int number in nNumbers.Skip(1).ToArray())
            {
                if(number == 0)
                {
                    return "You cannot divide by zero.";
                }
                res /= number;

            }
            return res.ToString();
        }

        public string CalculateOperation()
        {
            int res = Int32.Parse(operation.First());
            string operat = "";

            foreach (string element in operation.Skip(1).ToArray())
            {
                switch (operat)
                {
                    case "+":
                        res += Int32.Parse(element);
                        break;
                    case "-":
                        res -= Int32.Parse(element);
                        break;
                    case "*":
                        res *= Int32.Parse(element);
                        break;
                    case "/":
                        if(element == "0")
                        {
                            return "You cannot divide by zero.";
                        }
                        res /= Int32.Parse(element);
                        break;
                    default:
                        break;
                }

                switch (element)
                {
                    case "+":
                        operat = element;
                        break;
                    case "-":
                        operat = element;
                        break;
                    case "*":
                        operat = element;
                        break;
                    case "/":
                        operat = element;
                        break;
                    default:
                        operat = "";
                        break;
                }
            }
            return res.ToString();
        }
    }
}
