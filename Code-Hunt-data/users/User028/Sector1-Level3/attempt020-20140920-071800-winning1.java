

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
   
   if (x==true)
     return true;
   if (y==true&&z==true){
      if (y&z)
        return true;
    }
    return false;
  }
}