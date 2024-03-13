using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Delegates_practice
{
    internal class DelegatesPractices
    {
        //public delegate bool ChechNums(int a);

        //public delegate void ChangeStr(string str);

        public delegate int CalculateLenght(string str,int num);

        //public bool ChechOddNums(int num)
        //{
        //    return num % 2 != 0;
        //}
        public bool ChechEvenNums(int num)
        {
            return num % 2 == 0;
        }

        public void StrToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public void StrToLower(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public int GetLenght(string str,int num)
        {
            return str.Length + num;
        }

        public bool CheckNums(int num1,int num2,int num3)
        {
            return num1>5 && num2>5 && num3>5;
        }


        public void Execute()
        {
            //List<int> list = new List<int> { 1, 4, 5, 7, 8, 9 };
            //list.Where(m => m > 100)
            //SumOfNumsByCondision(list, m => m % 2 != 0);
            //SumOfNumsByCondision(list, m => m % 2 == 0);

            //ShowText("Salam", StrToUpper);
            //ShowText("Salam", StrToLower);

            //GetLengthOfStr("salam", GetLenght);

            //Func<string, int, int> func = GetLenght;

            //var t = func("hello", 100);
            //Console.WriteLine(t);

            //SumOfNumsByCondition(1, 11, 12, CheckNums);

            Predicate<int> test = ChechEvenNums;
            Console.WriteLine(test(10));
        }

     public void SumOfNumsByCondition(int num1,int num2,int num3, Func<int,int,int,bool>expression)
        {
            if (expression(num1,num2,num3))
            {
                Console.WriteLine(num1+num2 + num3);
            }
        }

        //public void GetLengthOfStr(string str,Func<string,int,int> func)
        //{
        //    int count = func(str,10);
        //    Console.WriteLine(count);
        //}

        //public void ShowText(string text,Action<string> func)
        //{
        //    func(text);
        //}

        //public void SumOfNumsByCondision(List<int> nums,Predicate<int> func)
        //{
        //    int sum = 0;
        //    foreach(var item  in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}


    }
}
