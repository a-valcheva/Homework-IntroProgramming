using System;

class SquareRoot
{
    //Create a console application that calculates and prints the square root of the number 12345. Find in Internet “how to 
    //calculate square root in C#”.

    static void Main(string[] args)
    {
        int number = 12345;
        double sqrtNumber = Math.Sqrt(number);
        Console.WriteLine(sqrtNumber);
    }
}

