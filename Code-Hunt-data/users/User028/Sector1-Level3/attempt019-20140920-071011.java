

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   if (x==false) {
     if (y==true&&z==true) {
         if (x|z==true)
           return true;
         else
           return false;
       }
     else
       return false;
     } 
   if ((y==true&&z==true)||x==true)
      return true;
    return false;
  }
}