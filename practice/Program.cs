using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
//usless comment
namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray= new int[4];

            //WriteReadExample();  
            //mainArray = ArrayExample(2, 4, 6, 8); //set mainArray equal to array from method
            //Console.WriteLine(mainArray[0] +" "+ mainArray[1] + " " + mainArray[2] + " " + mainArray[3]); //print out values of mainArray to verify it matches
            //IfExample(); 
            //SwitchExample(); 
            //WhileExample(); 
            //ForLoopExample(); 
            //TwoDimensionalArrayExample(); 
            //ClassExample(); 
            //ClasswithConstructorExample(); 
            //StaticClassExample();
            //StaticMethodsAndClassesExample();
            //InheritanceExample();

            //this code for GUI////////////////
            Form1 frm = new Form1();
            frm.ShowDialog();
            //////////////////////////////////

            //writetotextfile();


            Console.ReadLine();
        }

        static void WriteReadExample() 
        {
            string statement = "How old are you? ";
            Int16 age = 0;
            Console.Write(statement);  //write out without newline at end

            age = Convert.ToInt16(Console.ReadLine());  //Convert user input string to int16 and store in age

            Console.WriteLine("You are " + age);  //write out then add newline to end
        }

        static int[] ArrayExample(int a, int b, int c, int d)
        {
            int[] Array = new int[4];
            Array[0] = a;
            Array[1] = b;
            Array[2] = c;
            Array[3] = d;
            Console.WriteLine(Array[0] + " " + Array[1] + " " + Array[2] + " " + Array[3]);
            return Array;
        }

        static void TwoDimensionalArrayExample()
        {
            int number;
            Console.Write("There is a predefined 3x5 array, which row do you want to read out? (1,2,3): ");
            number = Convert.ToInt16(Console.ReadLine());

            int[,] Array =
            {
                {1,2,3,4,5},
                {2,4,6,8,10},
                {3,6,9,12,15}
            };

            while(number<0 || number>3)
            {
                Console.WriteLine("Outside of parameter");
                Console.Write("Try again... ");
                number = Convert.ToInt16(Console.ReadLine());
            }

            for(int i=0; i<5; i++)
            {
                Console.Write(Array[number-1,i] + " ");
            }

            Console.WriteLine(" ");
        }

        static void IfExample()
        {
            int number;
            Console.Write("Enter a number between 1 and 9: ");
            number = Convert.ToInt16(Console.ReadLine());

            

            if (number>0 && number <10 & number%2==0)
            {
                Console.WriteLine("Your number is even");
            }
            else if (number > 0 && number < 10 & number%2!=0)
            {
                Console.WriteLine("Your number is odd");
            }
            else
            {
                Console.WriteLine("Outside of parameter");
            }

        }

        static void SwitchExample()
        {
            int daynumber;
            Console.Write("Enter daynumber (1-7): ");
            daynumber = Convert.ToInt16(Console.ReadLine());

            switch(daynumber)
            {
                case 0:
                    Console.WriteLine("Outside of parameter");
                    break;
                case 1:
                    Console.WriteLine("Day is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Day is Monday");
                    break;
                case 3:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Day is Friday");
                    break;
                case 7:
                    Console.WriteLine("Day is Saturday");
                    break;
                default:
                    Console.WriteLine("Outside of parameter");
                    break;
            }
        }

        static void WhileExample()
        {
            int number;
            Console.Write("Enter a number between 0 and 100: ");
            number = Convert.ToInt16(Console.ReadLine());

            while(number<0 || number>100)
            {
                Console.WriteLine("Outside of parameter");
                Console.Write("Enter a number between 0 and 100: ");
                number = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Good job.");
        }

        static void ForLoopExample ()
        {
            int count;
            Console.Write("What number do you want to count to? ");
            count = Convert.ToInt16(Console.ReadLine());

            for (int i=1; i<count+1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }

        static void ClassExample()
        {



            Pet Lisa = new Pet();
            Lisa.aka = "Girlfriend";
            Lisa.gender = "Female";
            Lisa.age = 30;
            Lisa.personality = "Awesome";
            Lisa.diet = "Tacos";
            Lisa.access = true;

            Pet Lex = new Pet();
            Lex.aka = "Chatterbox";
            Lex.gender = "Female";
            Lex.age = 10;
            Lex.personality = "The Questioner";
            Lex.diet = "Brocolli and Cupcakes";
            Lex.access = false;

            Pet Odin = new Pet();
            Odin.aka = "Monkey Face";
            Odin.gender = "Male";
            Odin.age = 6;
            Odin.personality = "The Spaz";
            Odin.diet = "Farts";
            Odin.access = false;


            string user;

            Console.Write("What user do you wish to access? ");
            user = Convert.ToString(Console.ReadLine());

            if (user == "Lisa")
            {
                Console.WriteLine(Lisa.aka);
            }
        }

        static void ClasswithConstructorExample()  //also uses private getter and setter for access bool.  See Pet2.cs
        {
            Pet2 Lisa = new Pet2("Girlfriend", "Female", 30, "Awesome", "Tacos", "true");
            Pet2 Lex = new Pet2("Chatterbox", "Female", 10, "The Questioner", "Brocolli and Cupcakes", "false");
            Pet2 Odin = new Pet2("Monkey Face", "Male", 6, "The Spaz", "Farts", "false");


            string user;
            string input;

            Console.Write("What user do you wish to access? ");
            user = Convert.ToString(Console.ReadLine());

            if (user == "Lisa")
            {
                Console.WriteLine(Lisa.aka);
                Console.WriteLine(Lisa.Access);
            }

            Console.Write("Change access (true or false):  ");
            input = Convert.ToString(Console.ReadLine());

            Lisa.Access = input;

          
            Console.WriteLine("Lisa's access level is " + Lisa.Access);

        }

        static void StaticClassExample()
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount);  //songCount is a static variable of the Song class, not individual Song objects, ie holiday or kashmir.  

        }

        static void StaticMethodsAndClassesExample()
        {
            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("James");

        }

        static void InheritanceExample()
        {
            Chef chef = new Chef();
            chef.MakeTacos();

            LisaChef lisachef = new LisaChef();  //LisaChef() is a subclass because it inherits attributes from Chef(), the superclass
            lisachef.MakeTacos();
            lisachef.MakePasta();

            chef.MakeFish();
            lisachef.MakeFish(); //overridden so Lisa makes tilapia
        }

        static void play()  // future function to play sound
        {
        //    private SoundPlayer _soundPlayer;
        //play("Hey There Delilah Lyrics.mp3");
        }

        static void writetotextfile()
        {

            float [] data = new float[100];
            string datastring;
            string filePath = @"E:\c# projects\practice\text files\whatever.txt";
            //string[] lines = File.ReadAllLines(filePath);
            
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                Console.WriteLine(line);

            }

            for(int i=0; i<100; i++)
            {
                data[i] = i * 3;
                datastring = data[i].ToString();
                lines.Add(datastring);

            }

            lines.Add("Extra Line");
            



            File.WriteAllLines(filePath, lines);

            

        }
    }
}
