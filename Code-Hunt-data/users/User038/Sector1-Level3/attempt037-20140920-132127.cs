using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {if(y!=z)
   return x&&(y||z);
     else
    return x||y&&z;
  }
}