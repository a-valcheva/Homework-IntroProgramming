using System;

class AgeAfter10Years
{
    //Old
    //* Write a program to read your age from the console and print how old you will be after 10 years.

    //New
    //Write a program to read your birthday from the console and print how old you are now and how old you will be after 
    //10 years.
    static void Main(string[] args)
    {
        //Old
        //Console.WriteLine("Enter your age");
        //int ageOld = int.Parse(Console.ReadLine());
        //Console.WriteLine("After 10 years you will be {0} years old", ageOld + 10);

        //New
        Console.WriteLine("Enter your birthday(try yyyy.m.d)");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthDay.Year;
        if ((birthDay.Month <= today.Month && birthDay.Day <= today.Day) ^ (birthDay.Month < today.Month && birthDay.Day > today.Day))
        {
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("After 10 years you will be {0} years old", age + 10);
        }
        else
        {
            Console.WriteLine("You are {0} years old.", age - 1);
            Console.WriteLine("After 10 years you will be {0} years old", age + 9);
        }
        
    }
}

