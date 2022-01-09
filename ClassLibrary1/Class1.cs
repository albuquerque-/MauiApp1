using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IImcCalc
    {
        int getValue10(int i);
    }
    public class Class1:IImcCalc
    {
        public int getValue10(int i)
        {
            return i * 10;
        }
    }
}
