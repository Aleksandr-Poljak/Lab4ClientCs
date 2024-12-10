using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Lb34Task2ServerATLFNLib;
using static System.Console;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Lab4ClientCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyFn();
            IMyFn pIMyFn = obj;

            int num1 = 1;
            int num2 = 2;
            double result141;
            result141 = pIMyFn.Fun141(num1, num2);
            WriteLine($"Результат вызова функции Fun141: {result141}");

            int num3 = 3;
            int result142 = pIMyFn.Fun142(num1, num2, num3);
            WriteLine($"Результат вызова функции Fun142: {result142}");

            double result143 = pIMyFn.Fun143(result141);
            WriteLine($"Результат вызова функции Fun143: {result143}");

            Marshal.ReleaseComObject(pIMyFn);
        }

    }
}
