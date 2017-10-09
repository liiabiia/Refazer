

public class Program {
  public static String Puzzle(int n) {
    String out = "";
        
        while( n>1 ){
            out = n % 2 + out;
            n = n / 2;        
        }
        
        if( n >= 0)
            out = n + out;
		
		return out;
  }
}