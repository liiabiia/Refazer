

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
if(x==false && y==false && z==false) return false;
   if((x==y || x==z) && x==false)
return false;
if((y==z && y==false)) return false;
else
return true;
  }
}