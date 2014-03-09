using System;

class AgeAfter10Years
{
    //* Write a program to read your age from the console and print how old you will be after 10 years.
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your birthday(try yyyy.m.d)");
        DateTime birthDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthDay.Year;
        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine("After 10 years you will be {0} years old", age + 10);
    }
}

