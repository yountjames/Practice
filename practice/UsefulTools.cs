using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    static class UsefulTools  //can remove static if I want to be able to create objects of this class.  Static makes it so I can't make object, only call class methods, ie SayHi()
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
