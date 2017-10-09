

public class Program {
  public static String Puzzle(int n) {
    if(n == 0) return "0";
	String s = "";
	while(n > 0) {
		s += n%2;
		n /= 2;
	}
	return new StringBuilder(s).reverse().toString();
  }
}