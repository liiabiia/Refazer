

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {

   if(y == true && z == true && y == z){
        return z;
    }
    return x;
  }
}