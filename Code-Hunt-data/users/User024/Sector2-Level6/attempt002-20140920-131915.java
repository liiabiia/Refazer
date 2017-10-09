

public class Program {
  public static String Puzzle(int n) {
    String out = "";
        
        while(n > 1){
            out = n % 2 + out;
            n /= 2;
        }
        if( n == 1)
            out = 1 + out;
		return out;
  }
}