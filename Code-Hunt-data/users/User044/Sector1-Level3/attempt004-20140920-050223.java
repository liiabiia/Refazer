

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   if(x*y && y*z && x*z)
return true;
else
return false;
  }
}