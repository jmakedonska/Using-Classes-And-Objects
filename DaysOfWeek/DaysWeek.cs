﻿//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

﻿using System;

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine("This program prints to the console which day of the week is today.\n");
        DateTime dayOfWeek = new DateTime();
        dayOfWeek = DateTime.Now;
        Console.WriteLine("Today is: {0}\n", dayOfWeek.DayOfWeek);
    }
}