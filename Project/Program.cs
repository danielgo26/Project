﻿using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Ivan Ivanov",
                Age = 23,
            };
            person.IndroduceYourself();
            Console.WriteLine();
        }
    }
}
