using System;
using System.Numerics;
using Microsoft.VisualBasic;

class Program{

  static void Main(string[] args){
    bool run = false;
    while (!run){
      Console.WriteLine("Enter your number 1 ≤ n ≤ 50 : ");
      
      if (long.TryParse(Console.ReadLine(),out long i) && i <= 50 && i >0) {//Conversion return bool, and give it to i
        Console.WriteLine("\nFactorial of "+i+" is : "+CalculateurFactorielle(i));
        Console.WriteLine("Quit ? Y/n");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                run = Console.ReadLine().Equals("Y");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
    }
  }

  private static BigInteger CalculateurFactorielle(long n){
    if (n <= 0){
      return 0;
    }else if (n == 1)    {
      return 1*n;
    }else{
      return n * CalculateurFactorielle(n-1);
    }
  }
}
