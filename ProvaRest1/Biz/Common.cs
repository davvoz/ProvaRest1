using ProvaRest1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Web;

namespace ProvaRest1.Biz
{
    public class Common
    {
        public static String SearchIntoFibonacciSequence(int numeroCaratteri)
        {
           
            Boolean trovato = false;
            int counter = 0;
            String output = null;
            while (!trovato)
            {
                BigInteger fibo = Fibonacci(counter);
                int numberOfCharters = Fibonacci(counter).ToString().Length;
                if (numberOfCharters == numeroCaratteri)
                {
                    trovato = true;
                    output = fibo.ToString();
                }
                counter++;
            }
            return output;
        }
        private static BigInteger Fibonacci(int num)
        {
            BigInteger a = new BigInteger(1), b = new BigInteger(0), temp;
            while (num >= 0)
            {
                temp = a;
                a += b;
                b = temp;
                num--;
            }
            return b;
        
        }
    }
}