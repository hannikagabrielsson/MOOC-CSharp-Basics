namespace Exercise012
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
     PrintFromNumberToOne(5);
    }
    
    public static void PrintFromNumberToOne(int number)
    {
      for (int end = 1; number >= end; number--)
      {
        Console.WriteLine(number);
      }

    }
  }
}
