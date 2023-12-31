﻿using System;
class Program
{
    static void Main(string[] args)
    {
        //Bit_wise
        //0b = 비트로 값을 입력하겠다.
        //int = 32비트, byte = 8비트 (0~255)

        byte x = 0b1010; //10의 이진수값
        byte y = 0b1100;

        Console.WriteLine($"{Convert.ToString(x, 2)}, {x}");
        Console.WriteLine($"{Convert.ToString(y, 2)}, {y}");

        //Bit_wise and
        Console.WriteLine($"AND: {Convert.ToString(x & y, 2)} = {x & y}");
        Console.WriteLine($"OR: {Convert.ToString(x | y, 2)} = {x | y}");
        Console.WriteLine($"XOR: {Convert.ToString(x ^ y, 2).PadLeft(4, '0')} = {x ^ y}");
        Console.WriteLine($"NOT: {Convert.ToString((byte)~x, 2)} = {~x}");

        int a = Convert.ToInt32("0101", 2);
        int b = Convert.ToInt32("0110", 2);

        int number = 2;
        Console.WriteLine($"{Convert.ToString(number, 2).PadLeft(4, '0')}");
        Console.WriteLine(number << 1);// 왼쪽으로 1을 1칸 움직임 
        Console.WriteLine(number << 2);// 왼쪽으로 1을 2칸 움직임
        Console.WriteLine(number >> 1);// 오른쪽으로 1을 1칸 움직임

    }
}

 