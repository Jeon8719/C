﻿using System;

class program
{
    static void Main(string[] args)
    {
        //while
        /*초기식;
        while(조건식)
        {조건식이 만족하는 동안 실행할 명령문;}*/
        while (true)
        {
            Console.Title = "내가 만든 프로그램";
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH : mm : ss"));
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(5000);
            Console.ResetColor();
            Console.Clear();
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
                Thread.Sleep(500);

            }
            Console.WriteLine("BOOM!");

        }


    }
}