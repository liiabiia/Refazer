using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
    if(x!=false) return true;
else if(x==false&&y==false&&z==false) return false;
else if((y==true)&&(z==true)||(y==z)) return true;
else if((y==true)&&(y!=z)) return false;
else return false;
  }
}