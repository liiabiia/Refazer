using System;

public class Program {
  public static int Puzzle(int x) {
if(x==0)
    return 42;
if(x==42)
return 0;
if(x<42)
return x-42;
if(x>42)
return (-x)-42;
  }
}