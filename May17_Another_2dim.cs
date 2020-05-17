using System;
//        0 1 2
//  _____________
//  0|    2 4 7
//  1|    1 3 8
//
class MainClass {
  public static void Main (string[] args) {

    int[]   sums;
    int[,]  b;
    

    b = new int [5,5];
    sums = new int  [b.GetLength(0)];
    
    Random r = new Random();
    for ( int i =0 ; i< b.GetLength(0)  ;i++ ) 
    {
      for ( int j =0 ; j< b.GetLength(1)  ;j++ )
      {
        b[i,j] = r.Next(5);
      } 
    }

for ( int i =0 ; i< b.GetLength(0)  ;i++ ) 
    {
      for ( int j =0 ; j< b.GetLength(1)  ;j++ )
      {
        Console.Write (b[i,j] + " ");
      }
      Console.WriteLine(); 
    }
      Console.WriteLine(b[0,4]);
   Console.WriteLine("*************");
   for ( int i =0 ; i< b.GetLength(0)  ;i++ ) 
    {
      for ( int j =0 ; j< b.GetLength(1)  ;j++ )
      {
        sums[i] +=   b[i,j] ;
      }
      Console.WriteLine(sums[i]); 
    }

 for ( int i =0 ; i< b.GetLength(0)  ;i++ ) 
    {
      for ( int j =0 ; j< b.GetLength(1)  ;j++ )
      {
         if ( i>= j ) b[i,j] = 1;
         else b[i,j] = 0;

      } 
    }

for ( int i =0 ; i< b.GetLength(0)  ;i++ ) 
    {
      for ( int j =0 ; j< b.GetLength(1)  ;j++ )
      {
        Console.Write (b[i,j] + " ");
      }
      Console.WriteLine(); 
    }

 Console.WriteLine("*************");


    //Console.WriteLine(b[1,2]);


   
  }
}
