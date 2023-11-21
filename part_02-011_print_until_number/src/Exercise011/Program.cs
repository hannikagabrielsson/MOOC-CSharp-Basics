namespace Exercise011
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      
      
        PrintUntilNumber(5);
    }
    
    public static void PrintUntilNumber(int number){
      for (int start = 1; start <= number; start++){
        Console.WriteLine(start);
      }
    }
  }
}
