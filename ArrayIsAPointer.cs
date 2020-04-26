using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] a1;
            int[] a2;
            //  a1 null
            int[] zz;

            a1 = new int[3];
            a1[0] = 13423;      
                                                          //a1 ->    13423    0    0      (  page 17) 
                                                          //         0        1    2


            a2 = new int[5];
            a2[0] = 222;
            //a2 ->    222    0    0  0 0     (  page 20) 
            //         0      1    2  3 4 



            //a1 = new int[10];   ==>   good idea Yonatan ->  now lets try harder .lets do not use new!

            zz = a1;
            //a1 , zz  ->   13423    0    0      (  page 17) 
            //               0       1    2




            a1 = a2;   //  ==>  good ideas Maya   (  page 20)
                       //a2,a1 ->    222    0    0  0 0 
                       //            0      1    2  3 4 



            //a2 = zz;


            //  ..code ...

            a1[4] = 5;
            //a2,a1 ->    222    0    0  0 5 (  page 20)
            //            0      1    2  3 4 


            ///a1[0]    ///  how much ?  --->  2        ( bcz a1 is page 20) 
            //zz  [0] //   ??==> 13423                  ( bcz zz is page 17) 

            int x = 3, y = 5 ,z;
            z = x; //  z=3
            x= y;  //  x=5  and y =5 
            y = z;  
            //   we can no longer access  '3'



        }
    }
}
