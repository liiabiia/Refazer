

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {

    if(x == true){
        return x;
    }else if(y == true || z == true){
        return z;
    }
    return false
  }
}