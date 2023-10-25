﻿using System;

class Program
{
    static void Main(string[] args)
    {
        //BMI Program
        //필요한 변수 : 몸무게(kg),키(cm) / (m), BMi 수치
        float kg, cm, m, BMI;
        //비만도 결과
        string result = null;

        Console.Write("키(cm)를 입력해주세요. >>");
        cm = float.Parse(Console.ReadLine());
        Console.Write("몸무게(kg)를 입력해주세요. >>");
        kg = float.Parse(Console.ReadLine());

        m = cm * 0.01f;
        BMI = kg / (m * m);

        //조건에 따른 비만도 결과 처리

        if (BMI < 18.5)
        {
            result = "저체중";
        }
        else if (BMI >= 18.5 && BMI <= 23)
        {
            result = "정상";
        }
        else if (BMI > 23 && BMI <= 25)
        {
            result = "과체중";
        }
        else
        {
            result = "비만";
        }

        Console.WriteLine($"비만도 결과 : {result}");
        Console.WriteLine($"BMI 지수 : {BMI:F2}");//F2 : 소수점 2자리까지 표시
                                                //문자열 보간 기능
                                                //$"문장 {데이터}"




        //BMI의 공식 : kg / m*m
        //1cm = 0.01m (logic)
        //비만도 결과에 대한 조건
        //BMI < 18.5 저체중
        //BMI >=  18.5 && BMI <= 23 정상
        //BMI > 23 && BMI <= 25 과체중
        //BMI > 25 : 비만


    }
}