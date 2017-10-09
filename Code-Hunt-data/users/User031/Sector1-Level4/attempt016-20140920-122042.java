

public class Program {
  public static Boolean Puzzle(int x, int y) {
    if (x+y <= 2) {
            return (x+y == 2);
        }
        for (long i = 2; i * i <= x+y; i++) {
            if (x+y % i == 0) {
                return false;
            }
        }
        return true; 
  }
}