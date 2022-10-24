using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Class1
    {
        public float a;
        public bool znak;
        public float b;
        public Class1(float A, float B)
        {
            this.a = A;
            this.b = B;
        }
       
        public float sum()
        {
            return a + b;   
        }
        public float minus()
        {
            return a-b;
        }
        public float multiplicationt()
        {
            return a * b;
        }
        public float division()
        {
            return a / b;
        }
        

    }
}
