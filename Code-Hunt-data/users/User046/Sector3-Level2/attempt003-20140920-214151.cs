using System;

public class Program {
  public static int Puzzle(int n) {
    

if (n==4) return 5;
return (n>=7? n*3 : n);
  }
}