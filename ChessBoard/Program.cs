using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '#';
            int chessCage = 8;

            for (int i = 0; i <= chessCage; i++)
            {
               
                for (int j = 0; j <= chessCage; j++)
                {
                    Console.Write($"{ch}");

                    //if(i == ch && j == ch)
                    //{
                    //    ch = ' ';
                    //    Console.Write($"{ch}");
                    //}
                }

                Console.WriteLine();
            }

            Console.SetCursorPosition(10, 10);
        }
    }
}
