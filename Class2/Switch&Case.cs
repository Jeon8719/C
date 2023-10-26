﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("좋아하는 프로그램 언어를 선택하시오.");
        Console.WriteLine("1.C#\t 2.C++\t 3.Python\t 4.Java");
        int input_num = Convert.ToInt32(Console.ReadLine());


        if (input_num == 1) Console.WriteLine("선택하신 언어는 C#입니다.");
        else if (input_num == 2) Console.WriteLine("선택하신 언어는 C++입니다.");
        else if (input_num == 3) Console.WriteLine("선택하신 언어는 Python입니다.");
        else Console.WriteLine("선택하신 언어는 Java입니다.");

        switch (input_num)
        {
            case 1:
                {
                    Console.WriteLine("선택한 언어는 C#");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("선택한 언어는 C++");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("선택한 언어는 Python");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("선택한 언어는 Java");
                    break;
                }
            default:
                {
                    Console.WriteLine("없는 항목.");
                    break;

                }
        }
        Console.WriteLine("1~3 사이의 숫자를 입력하세요.");
        int input_num2 = Convert.ToInt32(Console.ReadLine());
        switch (input_num2)
        {
            case 1:
                {
                    Console.WriteLine("운세 좋다");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("운세 나쁘다");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("운세 매우 좋다");
                    break;
                }
            default:
                {
                    Console.WriteLine("1~3 사이의 숫자를 입력하세요.");
                    break;

                }
        }

        Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비)");
        string? input = Console.ReadLine();
        switch (input)
        {
            case "맑음":
                {
                    Console.WriteLine("날씨가 맑으니 소풍가자.");
                    break;
                }
            case "흐림":
                {
                    Console.WriteLine("날씨가 흐리니 집에 있자.");
                    break;
                }
            case "비":
                {
                    Console.WriteLine("비가 오니 우산을 챙기자.");
                    break;
                }
            default:
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력하세요.");
                    break;

                }
        }
                Console.WriteLine("첫번째 값을 입력하세요");
                bool bool1 = int.TryParse(Console.ReadLine(), out int answer);
                Console.WriteLine("두번째 값을 입력하세요");
                bool bool2 = int.TryParse(Console.ReadLine(), out int answer2);
                Console.WriteLine("연산자를 입력하세요. :+,-,*");
                string? c = Console.ReadLine();
                bool bool3 = (c == "+") || (c == "-") || (c == "*");
                if (bool1 && bool2 && bool3)
                {
                    switch (c)
                    {
                        case "+":
                            {
                                Console.WriteLine($"{answer + answer2}");
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine($"{answer - answer2}");
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine($"{answer * answer2}");
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("잘못 입력");
                }
        }
    }


 