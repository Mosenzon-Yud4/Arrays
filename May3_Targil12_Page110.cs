using System;
//page 110   targil 12

class MainClass
{
    public static void Main(string[] args)
    {
        int n = 4;
        int r = 3;   //  number of songs
        int[,] a; //  int [,,,] m ;  m[]
        a = new int[n, r]; //2,
        int[] sum = new int[r];

        int[] talmid_sum = new int[n];

        string[] songs = new string[r];
        songs[0] = "Toy";
        songs[1] = "Ez Tamar";
        //  songs[2] = "BasaSababa";
        //songs[3] = "Malkat Hashshanim";

        /*   0 1 2 3 4
             * % &                   *-  Toy  % - tzel Ez Tamar       &BasaSababa
         0   x x x x x   talmid 0
         1   x x x x x   talmid 1

         a[0,1]   Talmid 0 - Toy
         a[1,1]   Talmid 1 - tzel Ez Tamar 


         a[0,'Toy'] << Python   assoative array / map /hash /dict
        */


        Random rand = new Random();
        for (int i = 0; i < a.GetLength(0) ; i++) // 0 ,1 
        {
            for (int j = 0; j < a.GetLength(1); j++)  // 0,1,2,3,4
                a[i, j] = rand.Next(2);
        }

        for (int i = 0; i < n; i++) // 0 ,1 
        {
            Console.Write("Talmid " + (i + 1) + " :");
            for (int j = 0; j < r; j++)  // 0,1,2,3,4
                Console.Write(a[i, j] + " ");
            Console.WriteLine();

        }

        for (int i = 0; i < n; i++) // 0 ,1 
        {
            for (int j = 0; j < r; j++)  // 0,1,2,3,4
                sum[j] = sum[j] + a[i, j];

        }

        int max = sum[0];
        int max_pos = 0;

        for (int j = 0; j < r; j++) Console.Write(sum[j] + " ");

        for (int j = 0; j < r; j++)  // Console.Write(sum[j]+" ");
        {
            if (sum[j] > max)
            {
                max = sum[j];
                max_pos = j;
            }
        }
        Console.WriteLine();
        Console.WriteLine((max_pos + 1) + songs[max_pos] + " " + max);



        for (int i = 0; i < n; i++) // 0 ,1 
        {
            for (int j = 0; j < r; j++)  // 0,1,2,3,4
                talmid_sum[i] = talmid_sum[i] + a[i, j];
        }

        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            if (talmid_sum[i] == r)
                counter++;
        }
        Console.WriteLine("All songs owned: " + counter);
        //Console.ReadLine();
    }
}






