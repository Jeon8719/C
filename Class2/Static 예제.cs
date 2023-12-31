﻿using System;
class Program
{
    static int Square(int x)
    {
        int square = x * x;
        return square;
    }
    //================================================================
    static string GetString(int y)
    {
        string str = $"{y} 번째 반환값입니다.";
        return str;
    }
    //================================================================
    static double Sum_double(double a, double b)
    {
        return a + b;
    }
    //================================================================
    static void Log(string msg, int level, double z)
    {
        Console.WriteLine($"{msg}, {level}, {z}");
    }
    //================================================================
    static int max(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    //================================================================
    static int min(int a, int b)
    {
        if (a <= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    //================================================================
    static void SUM(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    //================================================================
    static void Print(int x)
    {
        Console.WriteLine($"int32={x}");
    }
    //================================================================
    static void Print(long x)
    {
        Console.WriteLine($"int64={x}");
    }
    //================================================================
    static void Print(double x)
    {
        Console.WriteLine($"double={x}");
    }
    //================================================================
    static void Hi()
    {
        Console.WriteLine("안녕하세요");
    }
    //================================================================
    static void Hi(string x)
    {
        Console.WriteLine(x);
    }
    //================================================================
    static void Multi()
    {
        Console.WriteLine("안녕하세요");
    }
    //================================================================
    static void Multi(string x)
    {
        Console.WriteLine(x);
    }
    //================================================================
    static void Multi(string y, int z)
    {
        for (int i = 0; i < z; i++)
        {
            Console.WriteLine(y);
        }
    }
    //================================================================
    static int Multi(int a, int b) => a * b;
    //================================================================
    static int Factorial_For(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    //================================================================
    static int Factorial_Self(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial_Self(n - 1);
        }
    }
    //================================================================
    static void Main()
    {
        Console.WriteLine($"4의 제곱은 {Square(4)}");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(GetString(i));
        }

        double Return_sum = Sum_double(3.0, 2.7);
        Console.WriteLine("입력값은 3.0, 2.7입니다.");
        Console.WriteLine($"두 수의 합은 {Return_sum}");

        Log("디버그", 1, 1.5);
        Log("디버깅", 23, 294.291);

        Console.WriteLine("첫 번째 정수를 입력");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("두 번째 정수를 입력");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"입력하신 정수값은 {a},{b}");
        Console.WriteLine($"최대값은 {max(a, b)},최소값은 {min(a, b)}");
        
        SUM(a, b);

        Print(314);
        Print(3.14);
        Print(35094829390239042);

        Multi();
        Multi("반갑습니다.");
        Multi("또 만나요.", 3);
        Hi();
        Hi("아무개씨 반갑습니다.");

        Console.WriteLine(Factorial_For(3));

        Console.WriteLine(Factorial_Self(3));

        Console.WriteLine(Multi(5, 3));


    }
}

 