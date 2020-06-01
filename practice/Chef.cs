using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Chef
    {
        public void MakePizza()
        {
            Console.WriteLine("The Chef makes pizza");
        }

        public void MakeTacos()
        {
            Console.WriteLine("The Chef makes tacos");
        }

        public virtual void MakeFish()  //added virtual so I can override it in LisaChef()
        {
            Console.WriteLine("The Chef makes tuna");
        }
    }
}


