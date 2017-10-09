using System;

public class Program {
  public static int Puzzle(int a, int b) {
    if(a==0 || b==0) return 0; if(a==1 || b==1) return 1; int c = 2; for(;;) { if(c%a==0 && c%b==0) return c; c++; }
    
  }
}