using System;
public class Program {

    public static int Puzzle(int x) {
         if(x <= 1)
         {
              return x;
         }
         else
         {
              return Puzzle(x-1) + ((Puzzle(x-1) - Puzzle(x-2)) + (Puzzle(x-2) - Puzzle(x-3)));
         } 
    }
}