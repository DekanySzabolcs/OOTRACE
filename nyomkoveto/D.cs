using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nyomkoveto
{
    public class D : B
    {
        public void S8()
        {
            Console.WriteLine("D::S8");
            V2();
        }

        public void S7()
        {
            Console.WriteLine("D::S7");
            S3();
        }

        protected void _V2()
        {
            Console.WriteLine("D::_V2");
            S7();
        }
    }
}