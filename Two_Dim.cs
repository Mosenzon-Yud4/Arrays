using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]   oneDim; 
            int[,]  a;  //  a  2 dimentions array !!

            a = new int[3, 4];
  
            a[0, 0] = 5;
            a[2, 0] = 6;
            //a[3, 0] = 9; //  error !!

            a[0, 3] = 8;  //  good !
  
            //  0   5 x x 8
            //  1   x x x x
            //  2   6 x x x

            
            //  print  table with   raw  per line

            for ( int i=0; i< a.GetLength(0); i++)  ///  a.GetLength(0) is 3
            {
                for ( int j=0;  j< a.GetLength(1); j++)  ///  a.GetLength(1) is 4
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }


            //  print  table with colomn per line
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
