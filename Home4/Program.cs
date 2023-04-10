using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задать строку содержащую внутри цифры и несколько повторений слова test,
            /// Заменить в строке все вхождения 'test' на 'testing'.
            Task1();

            ///Создайте переменные, которые будут хранить следующие слова: 
            ///(Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
            ///  Каждое слово должно быть записано отдельно и взято в кавычки, 
            ///  например "Welcome".Не забывайте о пробелах после каждого слова
            Task2();

            ///Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
            ///Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart. 
            ///Результат вывести в консоль. 
           Task3();

            ///Дана строка: Good day 
            /// Необходимо с помощью метода substring удалить слово "Good".
            /// После чего необходимо используя команду insert создать строку со значением: 
            /// The best day!!!!!!!!!.
            ///Заменить последний "!" на "?" и вывести результат на консоль.
            Task4();

            ///Введите с консоли строку, которая будет содержать буквы и цифры. 
            ///Удалите из исходной строки все цифры и выведите их на экран.
            ///(Использовать метод Char.IsDigit())
           Task5();

            ///Задайте 2 предложения из консоли. 
            ///Для каждого слова первого предложения определите количество его вхождений во второе предложение
            Task6();
        }
        public static void Task1()
        {
            string initial = "859test123 43test test567";
            string result = initial.Replace("test", "testing");
            Console.WriteLine(initial);
            Console.WriteLine(result);
        }
        public static void Task2()
        {
            string word1 = "Welcome";
            string word2 = "to";
            string word3 = "the";
            string word4 = "TMS";
            string word5 = "lessons";

            string result = string.Concat("'", word1, "' ", "'", word2, "' ", "'", word3, "' ", "'", word4, "' ", "'", word5, "' ");
            string result2 = result.Replace("'", "\"");
            Console.WriteLine(result2);
        }
        public static void Task3()
        {
            string initial = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string substring = "abc";
            int firstindex = initial.IndexOf(substring);
            int index = substring.Length;
            Console.WriteLine(initial);

            string first = initial.Substring(0, firstindex);
            Console.WriteLine(first);

            string last = initial.Substring(firstindex + index);
            Console.WriteLine(last);
        }
        public static void Task4()
        {
            string initial = "Good day";
            string rem = "Good";
            int index = rem.Length;
            string initial1 = initial.Substring(index);
            Console.WriteLine(initial);
            Console.WriteLine(initial1);

            string initial2 = initial1.Insert(0, "The best");
            Console.WriteLine(initial2);

            int index1 = initial2.Length;

            string initial3 = initial2.Insert(index1, "!!!!");
            Console.WriteLine(initial3);

            int index2 = initial3.Length - 1;
            string result = initial3.Remove(index2);
            Console.WriteLine(result);

            string result2 = string.Concat(result, "?");
            Console.WriteLine(result2);
        }
        public static void Task5()
        {
            Console.Write("Input the string:");
            string initial = Console.ReadLine();
            char[] letters = initial.ToCharArray();
            foreach (char c in letters)
            {
                if (c == '1')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '2')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '3')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '4')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '5')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '6')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '7')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '8')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '9')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '0')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            Console.WriteLine(initial);
        }
        public static void Task6()
        {
            Console.Write("Input the string1:");
            string initial1 = Console.ReadLine();

            Console.Write("Input the string2:");
            string initial2 = Console.ReadLine();

            string[] words1 = initial1.Split(new char[] { ' ' });
            string[] words2 = initial2.Split(' ');

            string result = null;
            int k = 0;

            foreach (string i in words1)
            {
                foreach (string j in words2)
                {
                    if (i == j)
                    {
                        k++;
                        result = j;
                    }
                }
            }
            Console.WriteLine("Words " + result + " from string2 exist in string1 in quantity " + k);
        }
    }
}