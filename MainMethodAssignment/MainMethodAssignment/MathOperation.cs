using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOperation
    {
        public int addNum(int num1)
        {
            int result = num1 + 5;
            return result;
        }

        public int addNum(decimal dec1)
        {
            decimal result2 = dec1 / 2;
            return Convert.ToInt32(result2);
        }

        public string addNum(string str1)
        {
            int int1 = Convert.ToInt32(str1);
            int result3 = int1 * 2;
            string convertedString = result3.ToString();
            return convertedString;
        }
    }
}
