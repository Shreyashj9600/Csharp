﻿namespace MULTI_CAST_DELEGATES
{
    public delegate void Calculation(int a , int b);
    internal class Program
    {
        public static void Addation(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addation result is " + result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is " + result);
        }
        public static void Multiplaction(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplaction result is " + result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is " + result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addation);
            obj += Subtraction;
            obj += Multiplaction;
            obj += Division;
            obj(20, 10);


            Console.ReadLine();
        }
    }
}
