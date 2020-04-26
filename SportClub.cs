using System;

    class SportClub
    {
        string [] members;
        int next;
        public string name;

        public SportClub()
        {
            this.members = new string[50];
            this.next = 0;
        }

       public void  Register ( string name  )
        {
            this.members[ this.next ] = name;
            this.next++;

            if (this.next >=   this.members.Length  )
            {
                Console.WriteLine  ("No space left.");
            }

        }

        public void ShowMembers()
        {
            for ( int i =0; i < next; i++)
            {
                Console.WriteLine(this.members[i]);
            }
        }

    }


    class  AllClubs
    {
        SportClub[] clubs;
        int next;
        public AllClubs()
        {
            clubs = new SportClub[10];
            next = 0;
        }

        public void AddClub( SportClub sc)
        {
            this.clubs[next] = sc;
            next++;
        }

        public void ShowClubs()
        {
            for (int i=0; i< next; i++)
            {
                Console.WriteLine(this.clubs[i].name);
                clubs[i].ShowMembers();
               
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SportClub sportan;      //    1##### -  first pointer to SportClub 
            sportan= new ();         
            sportan.name = "sportan";
            SportClub s2;           //     2#### -  second pointer to SportClub  
            s2 = new SportClub();     
            s2.name = "pudiim";

// ######################################   ?????
//  How  to have only one  pointer to  SportClub ?????  
// ######################################    ????  


            s2.Register("Shir");
            s2.Register("Maya");
            sportan.Register("Kevin");
            sportan.Register("Ray");


            //Console.WriteLine(sportan.name );
            // sportan.ShowMembers();

            AllClubs allsc;
            allsc = new AllClubs();
            allsc.AddClub(sportan);
            allsc.AddClub(s2);

            allsc.ShowClubs();


        }
    }
