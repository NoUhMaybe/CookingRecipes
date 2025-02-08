using System;

namespace ProjectTemplate
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MethodTemplate();

            ClassTemplate.Today();

            Console.ReadKey();

        }


        static void MethodTemplate()
        {
            Console.WriteLine("Hello AGAIN World!");
        }


        public class ClassTemplate
        {
            public int Num1 { get; set; }
            public int Num2 { get; init; } //Can only be set inside an object initializer after construction
            public int Num3 { get; private set; } //Can only be set inside the class methods

            public int Sum()
            {
                return Num1 + Num2 + Num3;
            }

            public static void Today() //"static" - Has to be called by the class itself not on an instance
            {
                Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}! I cant wait for {DateTime.Now.AddDays(3).DayOfWeek}, I have lunch planned!");
            }
        }
    }
}



