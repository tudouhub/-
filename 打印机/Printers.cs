using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace 打印机
{
    class Printers
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("请输入数字选择安装打印机:");
            Console.WriteLine("1.  人事打印机 p5238");
            Console.WriteLine("2.  刷卡打印机 ");
            Console.WriteLine("3.  工程打印机 P5387");
            int index;
            Console.Write("输入数字[x]:"); 
            index = int.Parse(Console.ReadLine());
            Printers printer = new Printers();
            switch (index)
            {
                case 1:
                   
                    printer.printName("\\\\p5238\\Canon LBP2900+");
                    break;
                case 2:
                    printer.printName("\\\\printly\\刷卡打印机 2608N");
                    break;
                case 3:
                    printer.printName("\\\\P5387\\Canon LBP2900Plus");
                    break;
                default:
                    Console.WriteLine("输入错误.");
                    break;
            }
            
        }
        public void printName(string ipPrint)
        {
            Process printProcess = null;
            printProcess = new Process();
            printProcess.StartInfo.FileName = ipPrint;
            printProcess.Start();
        }
    }
}
