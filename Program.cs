using System;

namespace NewOne
{
    class Program
    {

        //constant are imutable
        const double SI = 3.1516;
        const int weeks = 52, months =  21;
        const int  days = 365;

        // create a constant of string of bithday
        const string birthday = "05.12.1996";
        const string bithday2 = "02-5-98";
        static void Main(string[] args)
        {
           
          
        //  string myname = "Raju haasan";
        //  string message = "My name is " + myname ;
        //  string UPmessage = message.ToUpper();
        //  string lowerCase = UPmessage.ToLower();
        // double myDouble = 16.65;
        // int myInt;
         //exPlicit conversion
        //cast double to int
        // myInt = (int)myDouble;
        //  Console.WriteLine(myInt);

        // string myString = "25";
        // string myString2 = "25";
        // string result = myString + myString2 ;

        // int num = Int32.Parse(myString);
        // int num2 = Int32.Parse(myString2);
        // int resultNum = num + num2;
        // impiciti => big data type to small type
        int num = 38784;
        long myname = num;

        //expiciti small data type to big
        double myDouble = 13.875;
        int myInt;
        myInt = (int)myDouble; 

        // type conversion
        // string myString = myInt.ToString();
        // string huinbjk = num.ToString();

        // byte myByte = 35;
        // Console.WriteLine(myByte);
        // sbyte mysByte = 35;
        // Console.WriteLine(mysByte);
        // int myNum = 35558;
        // Console.WriteLine(myNum);
        // uint myUnit = 12306;
        // Console.WriteLine(myUnit);

        writeSomethinf();
        writeSomethinnew("Iam called from a method  classs");
        Console.WriteLine(add(23,36));
        Console.WriteLine(add(add(3,6) , add(3,6)));
        

         Console.WriteLine("My Birthday always going to be: {0}", birthday);
         string friend = "Rakib";
         string friend2 = "Rakin";
         GrretFriend(friend);
         GrretFriend(friend2);
            Console.ReadKey();
        }

        // access modifier (static) return type method name (parameter1 , parameter2 )
       public static void writeSomethinf(){
           Console.WriteLine("Iam called from a method");
       } 
       public static void writeSomethinnew(string myText){
           Console.WriteLine(myText);
       }
       public static int add(int a , int b ){
           return a + b;
       }
       public static void GrretFriend(string myFriend){
           Console.WriteLine("Hi, " + myFriend +  "My Friend");
       }

    }
} 