

class MainClass {
  public static void Main (string[] args) {
    
    
    int[,]   a;
    
    a= new int[2,5];  
    //   0 1 2 3 4
    // 0   x x x x x
    // 1   x x x x x
    ////
   
      a[0,0] ..  a[0,4]
      a[1,0] ..  a[1,4]
    
    a[0,0] = 1 ;
    a[1,4] = 8;
    for(int i=0; i < 2;i++) // 0 ,1 
    {  
      for ( int j=0;j<5 ; j++)  // 0,1,2,3,4
        Console.Write(a[i,j]+" ");
       Console.WriteLine();
    }

    Console.WriteLine ("Shachar The Melech");



  }
}
