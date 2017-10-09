

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   if(x==y || x==z && x==true)
return true;
if((y==z && y==true)|| x==true) return true;
else
return false;
  }
}