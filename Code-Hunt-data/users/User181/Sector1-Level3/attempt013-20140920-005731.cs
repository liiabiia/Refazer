using System;

public class Program {
  public static bool Puzzle(bool x, bool y, bool z) {
if(!x&&!y&&!z){return false;}else
if(!x&&!y&&z){
    return false;
  } else
 if(!x&&!y){
    return true;
  }
else if(!x&&y&&z){return true;}
  }

}