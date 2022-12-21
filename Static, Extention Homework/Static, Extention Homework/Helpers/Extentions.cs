using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Static__Extention_Homework.Helpers
{
    internal static class Extentions
    {
        public static int GetNum(this int num)
        {
            return  num;
        }


         public static bool CheckDigitInString(this string text)
         {

            return Regex.IsMatch(text, @"\d");

         }
         
         public static bool ChechString(this string text,string pattren)
        {
            return Regex.IsMatch(text, pattren);

          }

        //Tasks: 1) int ucun faktoriali hesablayan extention yazin


        public static int Faktorial(this int num)
        {

            int res = 1;
            while (num != 1)
            {
                res = res * num;
                num = num - 1;
            }

            return res;
        }

        public static double GetPower(this int num, int pow)
        {



            var result = Math.Pow(num, pow);

            return result;

        }




    }
}
