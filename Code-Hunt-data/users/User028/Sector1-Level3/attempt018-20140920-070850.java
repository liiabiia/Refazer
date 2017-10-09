

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   if (x==false) {
     if (x|z==true)
       return true;
     else
       return false;
     } 
   if ((y==true&&z==true)||x==true)
      return true;
    return false;
  }
}