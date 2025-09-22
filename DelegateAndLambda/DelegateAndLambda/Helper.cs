using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndLambda
{
    public static class Helper
    {
      //  public delegate bool Criteria(int number);
        public static int[] Filter(int[] numbers, Func<int,bool> criteria)
        {
            List<int> output = new List<int>();
            foreach (var item in numbers)
            {
                if (criteria(item))
                {
                    output.Add(item);
                }
            }

            return output.ToArray();
        }
    }
}
