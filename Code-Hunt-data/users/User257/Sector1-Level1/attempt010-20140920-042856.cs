using System;
public class Program {
 public static int Puzzle(int x) {
      switch(x)
      {
           case 0:
           case 1:
           default:
                return x;
           case 2:
                return x + 1;
           case 3:
                return x * 2;
           case 7:
                return x * x + x;
     } 
 }
}