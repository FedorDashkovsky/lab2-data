﻿using System;

namespace Task1
{
    class Program
    {
       
       static void Main(string[] args)
     
        {
            string fullFormat = DateTime.Now.ToString("F");
            string shortFormat = DateTime.Now.ToString("g");
            Console.WriteLine("Полный вид: " + fullFormat);
            Date(fullFormat);
            Console.WriteLine("\nКраткий вид: " + shortFormat);
            Date(shortFormat);

        }
        static void Calculator(string str, char x)
        {
            
            int score = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == x) 
                    score++;
            }
            Console.WriteLine("Количество чисел " + x + ": " + score);
        }

        static void Date(string str)
            {
                for (char i = '0'; i < '9'; i++)
                {
                    Calculator(str, i);
                }
            }
        }
    }

