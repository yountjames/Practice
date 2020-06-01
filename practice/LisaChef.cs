using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class LisaChef : Chef  //adding the : Chef makes it so LisaChef can do everything that Chef class can do plus whatever LisaChef does
    {
        public void MakePasta()
        {
            Console.WriteLine("Lisa makes pasta");
        }

        public override void MakeFish()  //added virtual so I can override it in LisaChef()
        {
            Console.WriteLine("Lisa makes tilapia");
        }
    }
}
