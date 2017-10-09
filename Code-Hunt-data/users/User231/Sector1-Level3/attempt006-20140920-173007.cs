using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    return x==false?(y==false||z==false?false:true):(y==false&&z==false?false:true);
  }
}