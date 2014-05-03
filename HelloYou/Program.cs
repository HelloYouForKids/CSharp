using System;
using System.Collections.Generic;
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
      Say("What is your name?");
      //Listen
      var name = Listen();
      while (true)
      {
        //Say
        Say("Hello {0}!", name);
        //Wait
        Wait(50);
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
