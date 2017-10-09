

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
if((x && z) ||((y && z) || x) || (x && y) || (!y && !z && x) )
return true;

if (y&&z)
return false;

else
    return false;
  }
}