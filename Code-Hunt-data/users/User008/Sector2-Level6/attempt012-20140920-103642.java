

public class Program {
  public static String Puzzle(int n) {
	  	if (n == 0) return null;
    	StringBuilder sb = new StringBuilder();
		while (n != 1) {
			if ((n % 2 == 1)) sb.append(1); 
			else sb.append(0);
			n /= 2;
		}
		sb.append(1);
		
		return sb.reverse().toString();
  }
}