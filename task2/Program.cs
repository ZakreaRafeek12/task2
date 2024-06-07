using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information

            /*
             * 21. Write a C# Sharp program to find the largest value from two positive
            integer values in the range 20..30 inclusive. Return 0 if neither is in that range.

            int input1 = Convert.ToInt32( Console.ReadLine());
            int input2 = Convert.ToInt32( Console.ReadLine());

            if ((input1 >= 20 && input1 <= 30) && (input2 >= 20 && input2 <= 30))
            {
                Console.WriteLine($"{Math.Max(input1, input2)}"); ;

            }
            else
            {
                Console.WriteLine("0");
            }
            */



            /*
             * Write a C# Sharp program to check if a given string contains between 2
            and 4 'z' characters.

            string st = Console.ReadLine();

            int countZ = 0;

            for (int i = 0; i <= st.Length -1; i++)
            {
                if (st[i] == 'z')
                {
                  countZ++;
                } 

            }

            if (countZ >= 2 && countZ <= 4)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            */

            /*
             * 23. Write a C# Sharp program to check if two given non-negative integers
            have the same last digit.



            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());


            if (input1 % 10  == input2 % 10)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

             */

            /*
             * 24. Write a C# Sharp program to convert the last 3 characters of a given string
            to uppercase. If the length of the string is less than 3, then uppercase all the
            characters.


            string st = Console.ReadLine();
            string st2 = "";


            if (st.Length >= 3)
            {
                for (int i = 0; i < st.Length ; i++)
                {
                    if (i >= st.Length -3) {
                        st2 += st[i].ToString().ToUpper();
                    }
                    else
                    {
                        st2 += st[i];
                    }   
                }

                Console.WriteLine(st2);
            }
            else
            {
                Console.WriteLine(st.ToUpper());
            }

             */


            /*
             * 25. Write a C# Sharp program to create a string which is n (non-negative
            integer) copies of a given string.



            string input = Console.ReadLine();
            int count = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                Console.Write(input);
            }
             */

            /*
             *  1. Write a C# Sharp program to accept two integers and check whether they
             are equal or not.


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
             */


            /*
             * 
             * 2. Write a C# Sharp program to check whether a given number is even or odd.

            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is even");
            }
            else
            {
                Console.WriteLine($"{num1} is odd");
            }
             */


            /*
             * 
             * 3. Write a C# Sharp program to check whether a given number is positive or
             negative.

            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine($"{num1} is positive");
            }
            else
            {
                Console.WriteLine($"{num1} is negative");
            }
             */


            /*
             * 4. Write a C# Sharp program to find out whether a given year is a leap year or
            not.

            int yearLeap = Convert.ToInt32(Console.ReadLine());

            if (yearLeap %4 == 0)
            {
                Console.Write($"{yearLeap} is a leap year.");
            }
            else
            {
                Console.Write($"{yearLeap} is not a leap year.");
            }
             */

            /*
             * 
             5. Write a C# Sharp program to read the age of a candidate and determine
             whether it is eligible for casting his/her own vote.

            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 18)
            {
                Console.WriteLine(" Congratulation! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine(" You are not eligible for casting your vote");
            }
             */


            /*
             * 
            6. Write a C# Sharp program to read the value of an integer m and display the
             value of n is 1 when m is larger than 0, 0 when m is 0 and-1 when m is less
             than 0.

            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("1");
            }
            else if (num1 < 0)
            {
                Console.WriteLine ("-1");
            }
            else
            {
                Console.WriteLine("0");
            }
             */


            /*
             *
             *8. Write a C# Sharp program to find the largest of three numbers.

            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int input3 = Convert.ToInt32(Console.ReadLine());

            var max =  Math.Max(input1, input2);
                max = Math.Max(max, input3);

            if (input1 == max)
            {
                Console.WriteLine("The 1nd Number is the greatest among three");
            }
            else if (input2 == max)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3nd Number is the greatest among three");
            }

             */


            /*
             * Write a C# Sharp program to read roll no, name and marks of three
            subjects and calculate the total, percentage and division.
             * 



            Student student1 = new Student(675, "jinan1", new Subjects(72, 93, 75));
            Console.WriteLine($"Total Marks = {student1._subjects.TotalMarks()}");

            Student student2 = new Student(22, "jinan2", new Subjects(92, 63, 55));
            Console.WriteLine($"Total Marks = {student2._subjects.TotalMarks()}");

            Student student3 = new Student(222, "jinan3", new Subjects(52, 83, 95));
            Console.WriteLine($"Total Marks = {student3._subjects.TotalMarks()}");

            public class Subjects
            {
                // Physics, Chemistry and Computer
                public int _physics { get; set; }
                public int _chemistry { get; set; }
                public int _computer { get; set; }
                public Subjects(int physics , int chemistry , int computer)
                {
                    _physics = physics ;
                    _chemistry = chemistry;
                    _computer = computer;
                }

                public int TotalMarks() {  return _chemistry + _physics + _computer; }

                public double Percentage()
                {
                    return Convert.ToDouble(TotalMarks() / 3) ;
                }
            }


            public class Student 
            {
                public int _id { get; set; }
                public string _name { get; set; }
                public Subjects _subjects { get; set; }

                public Student(int id, string name , Subjects subjects)
                {
                    _id = id ;
                    _name = name ;
                    _subjects = subjects ;
                }
            }

             */

            /*
             * 13. Write a C# Sharp program to read temperature in centigrade and display a
             suitable message according to the temperature state below:

            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature > 0 && temperature < 10)
            {
                Console.WriteLine(" Very Cold weather");
            }
            else if (temperature > 10 && temperature < 20)
            {
                Console.WriteLine(" Cold weather");
            }
            else if (temperature > 20 && temperature < 30)
            {
                Console.WriteLine(" Normal in Temp");
            }
            else if (temperature > 30 && temperature < 40)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("Its Very Hot");
            }
             */


            /*
             * 16. Write a C# Sharp program to check whether an alphabet letter is a vowel
             or a consonant.


            var letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || 
                letter == 'o' || 
                letter == 'i' || 
                letter == 'e' || 
                letter == 'u' 
                )
            {
                Console.WriteLine("The alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant.");
            }
             */

            /*
             * 1.WriteaC#Sharpprogramtocomputethesumof thetwonumericalvalues.
             If thetwovaluesarethesame,returntripletheirsum



            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{(num1+num2)*3}");
            }
            else
            {
                Console.WriteLine($"{(num1 + num2)}");
            }

             */

            /*
             *  2.WriteaC#Sharpprogramtoget theabsolutedifferencebetweennand51.
             Ifnisbroaderthan51returntripletheabsolutedifference.


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 51;

            if (num1 > num2)
            {
                Console.WriteLine($"{(num1 - num2) * 3}");
            }
            else
            {
                Console.WriteLine($"{(num1 - num2)}");
            }

            */

            /*
             *  3.WriteaC#Sharpprogramtochecktwogivenintegers,andreturntrueif
             oneof themis30or if theirsumis30.


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if ((num1 == 30 || num2 == 30)  || num1+num2 ==30 )
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

             */



            /*
             * 5.WriteaC#Sharpprogramtocreateastringwhere'if' isaddedtothefront
             ofagivenstring. If thestringalreadybeginswith'if',returnitunchanged.

            string input = Console.ReadLine();

            if ((input[0] == 'i' && input[1] == 'f') )
            {
                Console.WriteLine($"{input}");
            }
            else
            {
                Console.WriteLine($"if {input}");
            }
            */


            /*
             * 6.WriteaC#Sharpprogramtoremovethecharacteratagivenpositioninthe
             string.Thegivenpositionwillbeintherange0..(stringlength-1) inclusive.

            string input = Console.ReadLine();
            int position = Convert.ToInt32(Console.ReadLine());
            string newString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == position) continue;
                newString += input[i];
            }
              Console.WriteLine($"{newString}");

            */


            /*
             * 7.WriteaC#Sharpprogramtoexchangethefirstandlastcharactersina
             * givenstringandreturnthenewstring

            using System.Collections.Generic;

            string input = Console.ReadLine();
            string newString = string.Empty;

            if (input.Length >= 2)
            {
                char first = input[0];
                char last = input[input.Length - 1];

                for (int i = 1; i < input.Length - 1; i++)
                {
                    newString += input[i];
                }
                Console.WriteLine($"{last}{newString}{first}");
            }
            else
            {
                Console.WriteLine($"{input}");
            }
             */

            /*
             * WriteaC#Sharpprogramtocreateastringwhichis4copiesof the2front
             charactersofagivenstring. If thegivenstringlengthislessthan2returnthe
             originalstring.



            string input = Console.ReadLine();
            string newString = string.Empty;

            if (input.Length >= 2)
            {
                char first = input[0];
                char last = input[1];

                for (int i = 0; i < 4; i++)
                {
                    newString += $"{first}{last}";
                }
                Console.WriteLine($"{newString}");
            }
            else
            {
                Console.WriteLine($"{input}");
            }
            */




            /*
             * WriteaC#Sharpprogramtocreateastringwiththelastcharaddedat the
             frontandbackofagivenstringof length1ormore.


            string input = Console.ReadLine();

            char last = input[input.Length - 1];
            Console.WriteLine($"{last}{input}{last}");

            */


            /*
             * 
             * WriteaC#Sharpprogramtocheckifagivenpositivenumber isamultiple
             of3or7.


            using System.Collections.Generic;

            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 7 == 0 || num % 3 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            */



            /*
             * 11.WriteaC#Sharpprogramtocreateastringtakingthefirst3charactersof
             agivenstring.Returnthestringwiththe3charactersaddedatboththefront
             andback. If thegivenstringlengthislessthan3,usewhatevercharactersare
             there.
             * 


            string input = Console.ReadLine();
            int countChar = 3;
            string newString = string.Empty;

            for (int i = 0; i < countChar ; i++)
            {
                if (i < input.Length)
                newString += input[i];
            }
            Console.WriteLine($"{newString}{input}{newString}");
             */


            /*
             *  12. Write a C# Sharp program to check if a given string starts with 'C#' or not.



            string input = Console.ReadLine();

            if (input[0] == 'C' && input[1] == '#')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
             */


            /*
             *  13. Write a C# Sharp program that checks whether one temperature is less
             than 0 and another is greater than 100.



            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            var maxTemperature = Math.Max(num1, num2);
            var minTemperature = Math.Min(num1, num2);

            if (maxTemperature > 100 && minTemperature < 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            */


            /*
             *
             *14. Write a C# Sharp program to check two given integers whether either of
             them is in the range 100..200 inclusive.


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            var max = Math.Max(num1, num2);
            var min = Math.Min(num1, num2);

            if (max <= 200 && min >= 100)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            */


            /*
             * 15. Write a C# Sharp program to check whether three given integer values are
             in the range 20..50 inclusive. Return true if 1 or more of them are in the said
             range otherwise false.
             * 

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            var max = Math.Max(num1, num2);
             max = Math.Max(max, num3);
            var min = Math.Min(num1, num2);
             min = Math.Min(min, num3);

            if ((max <= 50 && max >= 20) || (min <= 50 && min >= 20))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
             */


            /*
             * 16. Write a C# Sharp program to check whether two given integer values are
             in the range 20..50 inclusive. Return true if 1 or other is in the range,
             otherwise false.
             * 

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (!(num1 <= 50 && num1 >= 20) && (num2 <= 50 && num2 >= 20))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
             */



            /*
             * 17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a
             given string. If it appears return a string without 'yt' otherwise return the
             original string.

            string input = Console.ReadLine();
            string newString = string.Empty;

            if (input.Length >= 3)
            {
                char first = input[1];
                char last = input[2];

                if (first == 'y' && last == 't')
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if(i == 1 || i == 2) continue;

                     newString += input[i];
                    }
                    Console.WriteLine($"{newString}");
                }
                else
                {
                    Console.WriteLine($"{input}");
                }
            }
            else
            {
                Console.WriteLine($"{input}");
            }
             */



            /*
             * 
             * 18.WriteaC#Sharpprogramtocheckthelargestnumberamongthreegiven
             integers.


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            var max = Math.Max(num1, num2);
            max = Math.Max(max, num3);

            Console.WriteLine($"{max}");

             */



            /*
             *  19.WriteaC#Sharpprogramtocheckwhichnumber isclosest to100among
             twogivenintegers.Return0if thetwonumbersareequal.

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            var max = Math.Max(num1, num2);

            if (num1 != max)
            {
                Console.WriteLine($"{max}");
            }
            else Console.WriteLine("0");

             */

            /*
            string input = (Console.ReadLine());

            List<char> list = new List<char>();
            for (int i = 0; i< input.Length; i++)
            {
                list.Add(input[i]);
            }
            foreach(char c in list.Order())
            Console.WriteLine(c);

            */


            /*
            using System.Collections.Generic;

            int count = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < count; i++)
            {
                list.Add(Console.ReadLine());
            }
            foreach (string s in list.Order())
            {
              Console.WriteLine(s);
            }

            */


            //int countCut = Convert.ToInt32(Console.ReadLine());
            //int startPos = Convert.ToInt32(Console.ReadLine());
            //string str = Console.ReadLine();


            /*
             *  Write a program in C# Sharp to check the username and password.

            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string nsername1 = "jinana";
            string password1 = "3737";


            if (username == nsername1 && password == password1)
            {
                Console.WriteLine("Password entered successfully");
            }
            else
            {
                Console.WriteLine("Password entered not success");
            }

             */

            /*
             * 
             *  17. Write a program in C# Sharp to search for the position of a substring within
             a string.


            string input = Console.ReadLine();
            string subString = Console.ReadLine();

            var postion = input.IndexOf(subString);
            Console.WriteLine($"{postion}");

            if ( postion != -1)
            {
                Console.WriteLine($"NOT FOUND {subString} IN {input}");
            }
            */


            /*
             * 18. Write a C# Sharp program to check whether a character is an alphabet
             and not and if so, check for the case.
             */
            // using System.Data.SqlTypes;

            // char input = Convert.ToChar(Console.ReadLine());

            // if (char.IsUpper(input))
            // {
            //     Console.WriteLine($"the {input} is Upper ");
            // }
            // else if (char.IsLower(input))
            // {
            //     Console.WriteLine($"the {input} is Lower ");
            // }

        
           // string mainString = Console.ReadLine();

           // string subString = Console.ReadLine();

            //string searchString = Console.ReadLine();

            //int index = mainString.IndexOf(searchString);

            //if (index != -1)
            //{
                // Insert substring before the first occurrence of the search string
                //Console.WriteLine(mainString.Insert(index, subString));
           // }
           // else
           // {
                // If search string not found, return the original string
               // Console.WriteLine(mainString);
           // }

            //Console.WriteLine("Result: ");



           // Console.ReadKey();
        }

        
        
       


    }
    
    
}
