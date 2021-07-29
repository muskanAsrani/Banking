using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Class1
    {
        public double deposit(double x,double y)
        {
            x = x + y;
            return x;
        }
        public double withdraw(double x, double y)
        {
            if (y > x)
            {
                throw new InvalidOperationException("Less Balance");
            }
            else
            {
                x = x - y;
                return x;
            }
        }

    }
}
