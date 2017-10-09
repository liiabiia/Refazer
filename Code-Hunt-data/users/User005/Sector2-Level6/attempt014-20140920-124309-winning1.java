

public class Program {
  public static String Puzzle(int n) {
	
        if (n == 0) return "0";
 
   	StringBuilder sb = new StringBuilder();
        while (n != 1) {
            sb.append(n % 2); 
            n /= 2;
        }
        sb.append(1);
        return sb.reverse().toString();
  }
}