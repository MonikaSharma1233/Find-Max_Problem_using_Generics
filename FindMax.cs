using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class FindMax
    {
        public static int Find_max_int(int fvalue, int svalue, int tvalue)
        {
            if (fvalue.CompareTo(svalue) > 0 && fvalue.CompareTo(tvalue) > 0)
            {
                return fvalue;
            }
            if (svalue.CompareTo(fvalue) > 0 && svalue.CompareTo(tvalue) > 0)
            {
                return svalue;
            }
            else if (tvalue.CompareTo(fvalue) > 0 && tvalue.CompareTo(svalue) > 0)
            {
                return tvalue;
            }
            throw new Exception("FirstNumber,SecondNumber,ThirdNumber are Same");
        }

    }

}

