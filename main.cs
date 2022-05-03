// Created by: Marshall Demars
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program finds if you are eligable for student pricing at the museum
        int age;
        int day;

        // input
        Console.WriteLine("This program tells you if you are eligable for student pricing at the museum");
        Console.WriteLine("");
        Console.WriteLine("You will need to input your age and the day of the week you are going");
        Console.WriteLine("");
        Console.WriteLine("Input the day of the week, for Sunday input 1, for Monday input 2, etc:");
        day = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("");
        Console.WriteLine("Input your age:");
        age = Convert.ToInt32(Console.ReadLine());
        

        // process
        Console.WriteLine("");
        if (day == 3 || day == 5 && age >= 12 && age <= 21)
        {
            Console.WriteLine("You can get student admission at the museum!");
        }
        else
        {
            Console.WriteLine("You have to pay regular admission at the museum!");
        }
        Console.WriteLine("\nDone.");
    }
}