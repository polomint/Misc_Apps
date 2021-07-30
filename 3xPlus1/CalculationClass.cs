using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3xPlus1
{
    public class CalculationClass
    {
        enum CalculationType
        {
            SINGLE,
            RANGE
        }

        private decimal startNumber = 1;
        private decimal endNumber = 2;
        private decimal limitCalculations = 100000;
        private CalculationType typeOfCalculation;
        public CalculationClass()
        {
            startNumber = 1;
            endNumber = 1;
            limitCalculations = 1;
            typeOfCalculation = CalculationType.SINGLE;
        }

        public void SetSingle(decimal singleValue, decimal limit)
        {
            startNumber = singleValue;
            limitCalculations = limit;
            typeOfCalculation = CalculationType.SINGLE;
        }

        public void SetRange(decimal startValue, decimal endValue, decimal limit)
        {
            startNumber = startValue;
            endNumber = endValue;
            limitCalculations = limit;
            typeOfCalculation = CalculationType.RANGE;
        }

        public (bool success, List<decimal> data) Calculate()
        {
            List<decimal> data = new List<decimal>();
            switch (typeOfCalculation)
            {
                case CalculationType.SINGLE:
                    (bool success, List<decimal> returnedData) = CalculateNumber(startNumber);
                    if (success)
                    {
                        return (true, data);
                    }
                    else
                    {
                        return (false, null);
                    }
                    // break;
                case CalculationType.RANGE:


                    return (false, null);
                    // break;
            }
            return (false, null);
        }

        private (bool success, List<decimal> data) CalculateNumber(decimal number)
        {
            List<decimal> data = new List<decimal>();
            decimal limit = limitCalculations;

            for (int i = 1; i <= limitCalculations; i++)
            {
                data.Add(number);
                if (limitCalculations == 0)
                {
                    return (true, data);
                }
                if (number == 1)
                {
                    return (true, data);
                }
                else
                {
                    if (number % 2 == 0)
                    {
                        number /= 2;
                        limitCalculations--;
                    }
                    else
                    {
                        number = (number * 3) + 1;
                        limitCalculations--;
                    }
                }
            }
            return (false, null);
        }

    }
}
