﻿class Program
{
    static void Main(string[] args)
    {
        int iter = 0;
        int a = 0;
        while (iter < 101)
        {

            a += iter;
            iter++;

        }
        Console.WriteLine(a);

        //피보나치 수열 = n + n2 = n3
        Console.WriteLine("원하는 토끼 쌍을 입력");
        int q = Convert.ToInt32(Console.ReadLine());
        int p = 0;//세대
        int n = 0;
        int n2 = 1;
        Console.WriteLine($"{n2},\t 0");
        while (n2 <= q)
        {
            p++;
            int n3 = n + n2;
            n = n2;
            n2 = n3;

            Console.WriteLine($"{n3},\t {p}");
        }


    }
}

