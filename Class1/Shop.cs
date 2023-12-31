﻿using System;
class Program
{

    // 반복문, 배열을 사용하는 이유
    // 불필요한 중복 작업 방지
    static void Main(string[] args)
    {
        string[] items = new string[] { "사과", "딸기", "바나나", "키위", "망고" };
        int[] prices = new int[] { 1000, 2000, 3000, 4000, 5000 };
        int Gold = 2000;
        Console.WriteLine("------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{items[i]} : {prices[i]: #,000} 원");
        }
        Console.WriteLine("------------------");
        Console.WriteLine($"소지금 : {Gold} 원");
        Console.WriteLine("------------------");
        Console.Write("구매하실 물건을 입력해주세요 >>");
        string? input_name = Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            if (input_name == items[i])
            {
                if (Gold >= prices[i])
                {
                    Console.WriteLine("구매완료.");

                }
                else
                {
                    Console.WriteLine("잔액이 부족합니다");
                }
            }
        }
    }
}