﻿using System;

namespace MethExercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello - Waht is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a very popular color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} is an adorable creature! Who is your favorite musician?");
            var musician = Console.ReadLine();

            Console.WriteLine($"Really !!! I love {musician} songs");

            Console.WriteLine($"Here are your favorite things {userName}");

            Console.WriteLine($"Your favorite color: {color}");
            Console.WriteLine($"Your favorite animal: {animal}");
            Console.WriteLine($"Your favorite musician: {musician}");

            

            Console.WriteLine("Give me a number please");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number please");
            var num2 = int.Parse(Console.ReadLine());

            var something = Add(num1, num2);
        }
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;

        }
   
        



    }
}
