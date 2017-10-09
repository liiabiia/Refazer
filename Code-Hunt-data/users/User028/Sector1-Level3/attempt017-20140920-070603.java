

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   if (x==false&&y&z)
     return false; 
   if ((y==true&&z==true)||x==true)
      return true;
    return false;
  }
}