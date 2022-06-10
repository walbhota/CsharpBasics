using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{


    namespace Helloword
    {
        class program
        {


            /*//To print out with a line gap
          Console.WriteLine("Good morning boss!");
          Console.WriteLine("I will print on a new line");

            //To print out without no line gap or space
          Console.Write("Good morning able chair");
          Console.Write("Suppose to be on another line");

            //Just to create a gap 
          Console.WriteLine("---------------------------------------------------------------------------------------------");

            //To assign a value(John) to a variable type(string)
          string name = "John";
          Console.WriteLine(name);

            //To assign a value(45) to a variable type(int)
          int mynum = 45;
          Console.WriteLine(mynum);

            //Another method of asssigning a value to a variable type
          int mynum1;
          mynum1 = 17;
          Console.WriteLine(mynum1);

          //To change the value of a variable 
          int mynum2 = 25;
          mynum2 =48;
          Console.WriteLine(mynum2);

          //Const is used to cancel out overwriting, meaning you can't assign another value to a const variable,it will give an error when tried.
          const int mynum3 =  87;
          Console.WriteLine(mynum3);

          //Other types of variables
          int num = 9;
          double myDoubleNum = 5.99D;//Use to store fractional numbers ,the value can be ended with a "D" but not necessaary.
          char myLetter = 'D';//For single Alphabet,must be a single quote
          bool myBool = true;//For boolean True or False
          string myText = "Hello";
          long mynum4 = 1500000000000000L; //use to store large numbers, it must end with a "L".
          //scientific numbers
          float f1 = 35e3F;
          double d1 = 12E4D;
          Console.WriteLine(f1);
          Console.WriteLine(d1);

          //Boolean
          bool isCsharpFun = true;
          bool isFishTasty = false;
          Console.WriteLine(isCsharpFun);
          Console.WriteLine(isFishTasty);

          //char variable type is used to store a single character and must be surrounded by a single quote. eg 'A' ,'B'.
          char grade = 'A';
          Console.WriteLine(grade);

          //using + to combine a text and a variable and also a variable and a variable
          Console.WriteLine("Hello " + name);

            //Combining variables using +
          string firstName = "James ";
          string secondName = "Thomas";
          string fullName =  firstName + secondName;
          Console.WriteLine(fullName);

            //Using + as a num
          Console.WriteLine(mynum + mynum2);

          // comma(,) is used to declare many variables, just put a comma between each variable.
          int x = 7, y = 79, z = 7;
          Console.WriteLine(x+y+z);

          int k = 26;
          k +=10;
          int j = --k;
          Console.WriteLine(k);
          Console.WriteLine(j);

          int r = 4;
          int w = 6;

          w = r ++;
          Console.WriteLine(++w);


        int r1 = 15;
        int r2 = 6;
        r1 %= r2;
        Console.WriteLine(r1);

        const double pi = 3.14;
        double radius;
        double area;

        radius = Convert.ToDouble(Console.ReadLine());
        area = pi * Math.Pow(radius, 2);
        Console.WriteLine(area); 



        //Using switch and break
        int num = 3;
        switch (num)
        {
            case 1:
            Console.WriteLine("one");
            break;
            case 2:
            Console.WriteLine("two");
            break;
            case 3:
            Console.WriteLine("three");
            break;

        }

            
        int x = 33;
        switch (x){
            case 8:
            Console.WriteLine("value is 8");
            break;

            case 18:
            Console.WriteLine("value is 18");
            break;

            case 33:
            Console.WriteLine("value is 33");
            break;
        }

            int age = 88;
            switch (age){
                case 16:
                Console.WriteLine("Too young");
                break;

                case 42:
                Console.WriteLine("Adult");
                break;

                case 70:
                Console.WriteLine("Old");
                break;

                default:
                Console.WriteLine("The default case");
                break;
            }

            

            //
            int x = Int32.Parse (Console.ReadLine());
            Console.WriteLine("This is your selected number: {0}",x);

            int num2 = 1;
            while (num2 <1000000)
            {
                Console.WriteLine(num2);
                num2 *=2;
            }









            int num = 1;
            while(num < 6)
            {
                Console.WriteLine(num);
                num++;
                
                
            }

            int x = 42;
            int num =0;
            while (num < 3){
                Console.WriteLine(x);
                num++;

            int num =2;
            while (num < 100)
            {
                Console.WriteLine(num);
                num+=num;
            }

            int num = 0;
            int num2 = 2;
            while (num < 100){
                Console.WriteLine(num);
                num +=num2;
            }
            

            int num = 0;
            while (num < 100){
                Console.WriteLine(num);
                num+=2;
            
      }

       int num = 0;
       while(++num < 6)
       Console.WriteLine(num);   

          
      int num = 0;
      while(num++ < 6)
      Console.WriteLine(num); 




      int x =1;
      while(x++ < 5)
      {
        if(x % 2 == 0)
        x+=2;
      }

      for (int x =2;x< 15; x++)
      {
        Console.WriteLine("Value of x: {0}",x);
      }

      for (int x = 0; x< 10;x+=3)
      {
        Console.WriteLine(x);
      }

      for(int x =10;x>0;x-=2)
      {
        Console.WriteLine(x);
      }

      for (int x = 0;x<=100;x+=2)
      {
        Console.WriteLine(x);
      }

      int x = 10;
      for (;x>0;x-=3)
      {
        Console.WriteLine(x);
      }

      int x = 0;
      do {
        Console.WriteLine(x);
        x ++;
      } while( x < 5);
      return Task.CompletedTask;

      int x = 10;
      for (;x>0;x-=3)
      {
        Console.WriteLine(x);
      }
            int a = 0;
            do {
                Console.WriteLine(a);
                a++;
            } while(a < 5);

      int x = 0;
      do {
        Console.WriteLine(x);
        x+=2;
      
      }while (x<10);

      int x = 42;
      do{
        Console.WriteLine(x);
        x++;
      }while (x<10);

      int a = 2;//The do runs at least once as we have read, so when it runs, it evaluates a+=3 to 5(2+3).now while th while checks the condition(a<5)
      do{       //and see that it false, it breaks and continue to the next line which is the console line and then it prints 5
      
        a += 3;
      } while (a <4);
      Console.WriteLine(a);

      int num = 0;
      while (num < 20)
      {
        if (num ==5)
        break;        // Using break to break out from the code block of the while loop

        Console.WriteLine(num);
        num++;
      }

      for (int x=1; x <8; x++){
        if (x>5) //the loop breaks here because 6>5, so it doesn't printout 6 .So the largest num is 5.
        break;
        Console.WriteLine(x);
      }

      for (int i =0;i<10;i++){
        if (i==5)
        continue;

        Console.WriteLine(i);
      }

      for (int i =0;i <99;i++){
        if (i%2!=0)
        continue;

        Console.WriteLine(i);
      }


      int age =42;
      double money = 540;
      while (age>18 && money >100){
        Console.WriteLine("welcome");
        if (money ==541 && age ==43)
        break;
      }  

      static int Area(int h, int w)
      {
        return h * w;
      }

      static void Main(string[] args)
      {
        int res = Area(w: 5, h: 8 );
        Console.WriteLine(res);
      }

      static int Calc(int from, int to, int step = 1)
      {
        int res = 0;
        for(int i = from; i < to; i +=step){
          res += i;
        }
        return res;
      }
      static void Main(String [] args){

        int res = Calc(step: 2,to: 99,from: 5);
        Console.WriteLine(res);
      }
      static void Sqr(int x)
      {
        x = x *x;
      }
      static void Main()
      {
        int a =3;
        Sqr(a);
        Console.WriteLine(a);
      }

      static void Sqr(ref int x)
      {
        x = x * x;
      }
      static void Main()
      {
        int a = 3;
        Sqr(ref a);
        Console.WriteLine(a);
      }
     void Swap(ref int x,ref int y)
      {
        int temp;
        temp =x;
        x=y;
        y=temp;
      }

      static void GetValues(out int x,out int y){

        x =5;
        y = 42;
      }
      static void Main(string[] args)
      {
        int a,b;
        GetValues(out a,out b);
        Console.WriteLine("the value of a is {0} and the new value of b is {1}",a,b);
      }

      static void Ask(out string name)
      {
        name = Console.ReadLine();
      }
      static void Main(string[] args)
      {
        string nm;
        Ask(out nm);
        Console.WriteLine(nm);

      }

    static void Print(int a){
      Console.WriteLine("value integer: "+ a);
    }
    static void Print(double a){
      Console.WriteLine("Value double: "+a);
    }

    static void Print(string a){
      Console.WriteLine("Value string: "+a);
    }

    static void Main(string[] args){

      Print(3);
      Print(1.23);
      Print("A string");
      Console.WriteLine(5*4*3*2*1);
    }

    static int Fact(int num){
      if (num == 1){
        return 1;
      }
      return num * Fact(num - 1);
    }

    static void Main(string[] args)
    {
      Console.WriteLine(Fact(6));
    }



   //drawing a pyramid
    static void DrawPyramid(int n)
    {
      for (int i = 1;i <= n;i ++)
      {
        for(int j = i;j <= n;j++)
        {
          Console.Write("  ");
        }
        for(int k = 1;k <= 2*i-1;k++)
        {
          Console.Write("*" + " ");
        }
        Console.WriteLine();
      }
    }
    static void Main(string[] args)
    {
      DrawPyramid(13);
    }
    
    class Person
    {
      public int age;
      public string? name;

    
      public void SayHi()
      {
        Console.WriteLine("Hi");
        
      }
    }
    static void Main(string[] args){

    Person p1 = new Person();
    p1.SayHi();
    p1.name = "paul";
    p1.age = 45;

    Console.WriteLine(p1.name);
    Console.WriteLine(p1.age);    
    
    
    }

    class Person
    {
    
      public void SayHi(out int a, out string b)
      {
        a = 20;
        b = "Richard";
        Console.WriteLine("====================================");
        
      }
    }
    static void Main(string[] args){
    int d;
    string c;
    Person p1 = new Person();
    p1.SayHi(out d, out c);

    Console.WriteLine("name is {0},{0} brown and i am {1} ",c,d);    
    
    
    }
    class Dog{
      public int age;
      public string? name;
    }

    static void Main(string[] args){

      Dog bob = new Dog();
      bob.age = 3;
      bob.name = "Bobby";

      Console.WriteLine(bob.age+" "+bob.name);
      
    }

    class Dog{

      private int age;
      private string? name;

      public void Bark(){
        Console.WriteLine("woof!!!");
      }
      public int GetAge(){
        return age;
      }

      public string GetName(){
        return name;
      }

      public void SetAge(int newAge){
        age = newAge;

      }
      public void SetName(string newName){
        name = newName;

      }

    }
    static void Main(string[] args){

      Dog bob = new Dog();
      bob.SetAge(3);
      bob.SetName("Bobby");
      Console.WriteLine(bob.GetAge());
      Console.WriteLine(bob.GetName());
      bob.Bark();
    }
      // Bank Account Module
    class BankAccount{
      private double _balance = 0;
      public void Deposit(double n){
        _balance += n ;
      }
      public void Withdraw(double n){
        _balance -= n;
      }
      public double GetBalance(){
        return _balance;
      }
      static void Main(string[] args){
        BankAccount account = new BankAccount();
        Console.WriteLine("Oga how much do you want to deposit");
        Console.WriteLine("------------------------------------");
        double depo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You sure say na that amount you wan withdraw");
        Console.WriteLine("--------------------------------------------");
        double with = Convert.ToDouble(Console.ReadLine());
        account.Deposit(depo);
        account.Withdraw(with);
        Console.WriteLine("===============================");
        Console.WriteLine("Your available balance is: ");
        Console.WriteLine(account.GetBalance());
        Console.WriteLine("===============================");

      }
    }

    //Constructors
    class Person{

      private int age = 45;

      public int GetAge(){
        return age;
      }
      public Person(){
        Console.WriteLine("Hi there");
      }
    }
    static void Main(string [] args){

      Person p = new Person();
      Console.WriteLine(p.GetAge());
    }*/


            class Person
            {

                private int age;
                private string? name;
                public Person(string nm)
                {
                    name = nm;
                }
                public string GetName()
                {
                    return name;
                }
            }

            static void Main(string[] args)
            {
                Person p = new Person("David");
                Console.WriteLine(p.GetName());
            }




        }


    }

}
