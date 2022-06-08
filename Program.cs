using System;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Andrew";
            int myAge = 50;
            char myInitial = 'A';
            bool amIAStudent = true;
            decimal bankBalance = 56.05M;

            Console.WriteLine($"My name is {myName}, and I am {myAge} years old. My first initial is {myInitial}, and it is {amIAStudent} that I am a student. Finally, my bank balance is currently {bankBalance:$0.00}");

        }
    }
}
