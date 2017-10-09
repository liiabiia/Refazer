

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    if(x==true || (y==true && z==true && y==z) )
return true;
else
return false;
  }
}