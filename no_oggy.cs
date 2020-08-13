using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    foreach (var name in names.Reverse<string>())
    {
        if(name.StartsWith("oggy")) {
            Console.WriteLine($"Need to remove {name}!");
            names.Remove(name);
             //break; you can stop once you have found first oggy , this crash is due to iterator modification
        }
    }
      
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}
