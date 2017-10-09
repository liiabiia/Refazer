

public class Program {
  public static String Puzzle(int n) {
    if( n == 0)
		return "0";
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