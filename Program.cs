using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LettersChangeNumbers
{
    class MainClass
    {
        public static double Multiply(char leter, double number)
        {
            double result = 0;
            if (char.IsLetter(leter))
            {
                result = ((int)leter - 96) * number;
            }

            return result;
        }
        public static double Divide(char leter, double number)
        {
            double result = 0;

            if (char.IsLetter(leter))
            {
                result = number / ((int)leter - 64);
            }
            return result;
        }
        public static double Subtract(char leter, double number)
        {
            double result = 0;

            if (char.IsLetter(leter))
            {
                result = (int)leter - 64;
            }
            return result;
        }
        public static double Add(char leter, double number)
        {
            double result = 0;

            if (char.IsLetter(leter))
            {
                result = (int)leter - 96;
            }
            return result;
        }
        public static int ReturnNumberFromString(string tempString)
        {
            int result = 0;

            if (char.IsLetter(tempString.FirstOrDefault()))
            {
                tempString = tempString.Remove(0, 1);
            }
            if (char.IsLetter(tempString.LastOrDefault()))
            {
                tempString = tempString.Remove(tempString.Length - 1, 1);
            }
            result = int.Parse(tempString);
            return result;
        }
        public static void Main(string[] args)
        {
            List<string> inputStringList = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            double sumAll = 0;
            foreach (var item in inputStringList)
            {
                
                
                double sum = 0;
                if (char.IsLower(item.FirstOrDefault()))
                {
                    sum+=Multiply(item.FirstOrDefault(),ReturnNumberFromString(item));
                }else 
                {
                    sum+=Divide(item.FirstOrDefault(),ReturnNumberFromString(item));
                }

                if (char.IsLower(item.LastOrDefault()))
                {
                    sum+=Add(item.LastOrDefault(),ReturnNumberFromString(item));
                }
                else
                {
                    sum-=Subtract(item.LastOrDefault(),ReturnNumberFromString(item));
                }
                sumAll += sum;
            }
            Console.WriteLine("{0:f2}",Math.Round(sumAll,2,MidpointRounding.AwayFromZero));
        }
    }
}
