using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
if(x=0){
return 0;
}


    return (x||z)&&y;
  }
}