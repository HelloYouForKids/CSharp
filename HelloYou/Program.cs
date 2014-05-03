using System;
using System.Threading;

namespace HelloYou
{
  /// <summary>
  /// HelloYou: A program that knows who you are!
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      //Say
      
      //Listen

      while (true)
      {
        //Say
        
        //Wait

      }
    }

    #region Helpers

    private static void Say(string whatToSay, object args0 = null)
    {
      if (args0 != null)
        Console.WriteLine(whatToSay, args0);
      else
        Console.WriteLine(whatToSay);
    }

    private static string Listen()
    {
      return Console.ReadLine();
    }

    private static void Wait(int miliseconds)
    {
      Thread.Sleep(miliseconds);
    }

    #endregion

  }
}
