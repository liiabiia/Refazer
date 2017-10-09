

public class Program {
  public static Boolean Puzzle(Boolean x, Boolean y, Boolean z) {
    return x and y and z or z and y or x and y or x;
  }
}