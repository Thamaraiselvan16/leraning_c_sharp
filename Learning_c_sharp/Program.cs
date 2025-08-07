using System;

namespace TestingCode
{
    class ProgramOfTesting
    {

        static void Main()
        {
            //// Printing the value
            //Console.WriteLine("Hi this is thamarai");


            ////user input and printing the value
            //Console.Write("Enter Your Name : ");
            //string Name = Console.ReadLine();
            //Console.WriteLine($"Hi {Name} welcome to the c# programming");


            ////variables creating and printing the value
            //int ThisIsNumber = 10;
            //string ThisIsString = "abc";
            //bool ThisIsBiilean = true;
            //float ThisIsFloat = 10.5f;
            //decimal ThiisIsDecimal = 10.5m;
            //double ThisIdDouble = 10.5;
            //char ThisIsChar = 'c';
            //var ThisIsVar = 10;

            //Console.WriteLine(ThisIsNumber);
            //Console.WriteLine(ThisIsString);
            //Console.WriteLine(ThisIsBiilean);
            //Console.WriteLine(ThisIsFloat);
            //Console.WriteLine(ThiisIsDecimal);
            //Console.WriteLine(ThisIdDouble);
            //Console.WriteLine(ThisIsChar); 
            //Console.WriteLine(ThisIsVar);


            ////string Methods
            //string s = "     Hello World       ";
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.Length);
            //Console.WriteLine(s.Contains("Hello"));
            //Console.WriteLine(s.StartsWith("He"));
            //Console.WriteLine(s.EndsWith("World"));
            //Console.WriteLine(s.Replace('o', 'u'));
            //Console.WriteLine(s.Substring(5, 5));
            //Console.WriteLine(s.Trim());
            //Console.WriteLine(s[5..8]); 


            ////Working with Numbers
            //int a = 10;
            //int b = 20;
            //int c = 30;

            //Console.WriteLine(a + b + c);
            //Console.WriteLine(a - b - c);
            //Console.WriteLine(a * b * c);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);
            //Console.WriteLine(a++); // Post-increment
            //Console.WriteLine(++b); // Pre-increment
            //Console.WriteLine(a--); // Post-decrement
            //Console.WriteLine(--c); // Pre-decrement
            //Console.WriteLine(Math.Abs(-10)); // Absolute value
            //Console.WriteLine(Math.Max(a, b)); // Maximum value
            //Console.WriteLine(Math.Min(a, b)); // Minimum value
            //Console.WriteLine(Math.Pow(a, 2)); // Power
            //Console.WriteLine(Math.Sqrt(25)); // Square root
            //Console.WriteLine(Math.Round(10.5)); // Rounding (uncomment if needed)
            //Console.WriteLine(Math.Floor(10.9)); // Floor (uncomment if needed)
            //Console.WriteLine(Math.Ceiling(10.1)); // Ceiling (uncomment if needed)
            //Console.WriteLine(Math.PI); // Pi constant (uncomment if needed)
            //Console.WriteLine(Math.E); // Euler's number (uncomment if needed)
            //Console.WriteLine(Math.Sin(30)); // Sine (uncomment if needed)
            //Console.WriteLine(Math.Cos(30)); // Cosine (uncomment if needed)
            //Console.WriteLine(Math.Tan(30)); // Tangent (uncomment if needed)
            //Console.WriteLine(Math.Log(100)); // Logarithm (uncomment if needed)
            //Console.WriteLine(Math.Log10(100)); // Base-10 logarithm (uncomment if needed)
            //Console.WriteLine(Math.Exp(1)); // Exponential function (uncomment if needed)
            //Console.WriteLine(Math.Sign(-10)); // Sign of a number (uncomment if needed)
            //Console.WriteLine(Math.Truncate(10.9)); // Truncate (uncomment if needed)
            //Console.WriteLine(Math.BigMul(100000, 200000)); // Big multiplication (uncomment if needed)
            //Console.WriteLine(Math.BigMul(100000, 200000)); // Big multiplication (uncomment if needed)
            //Console.WriteLine(Math.BigMul(100000, 200000)); // Big multiplication (uncomment if needed)
            //Console.WriteLine(Math.BigMul(100000, 200000)); // Big multiplication (uncomment if needed)



            ////datatype convertion
            //string s1 = "134";
            //Console.WriteLine(s1.GetType());  // get the type of s1
            //int l1 = Convert.ToInt32(s1); // convert string to int
            //Console.WriteLine(l1.GetType()); // get the type of l1

            //Console.WriteLine(Convert.ToInt32(s1));
            //Console.WriteLine(Convert.ToDouble(s1));
            //Console.WriteLine(Convert.ToSingle(s1));
            //string s2 = "true";
            //Console.WriteLine(Convert.ToBoolean(s2));

            //Console.WriteLine(int.Parse(s1));
            //Console.WriteLine(double.Parse(s1));
            //Console.WriteLine(bool.Parse(s2));

            //Console.WriteLine(int.TryParse(s1, out int intValue));
            //Console.WriteLine(double.TryParse(s1, out double doubleValue));
            //Console.WriteLine(bool.TryParse(s2, out bool boolValue));


            {
                SayHello("Dhill");
                SayHello("Thamarai");
                SayHello("Thamarai", 25);

            }
            static void SayHello(string name, int age = 25)
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}