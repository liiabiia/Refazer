

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   if (x==false&&y==true&&z==true)
     return false; 
   if ((y==true&&z==true)||x==true)
      return true;
    return false;
  }
}