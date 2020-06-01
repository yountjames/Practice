using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Pet2
    {
        public string aka;
        public string gender;
        public int age;
        public string personality;
        public string diet;
        private string access;

        public Pet2(string aAka, string aGender, int aAge, string aPersonality, string aDiet, string aAccess) //Constructor
        {
            aka = aAka;
            gender = aGender;
            age = aAge;
            personality = aPersonality;
            diet = aDiet;
            Access = aAccess;

        }

        public string Access
        {
            get { return access; }
            set {
                if (value == "true" || value == "false") { access = value; }
                else
                {
                    
                    Console.WriteLine("Improper response, access unchanged");
                }
            }
        }
    }
}
