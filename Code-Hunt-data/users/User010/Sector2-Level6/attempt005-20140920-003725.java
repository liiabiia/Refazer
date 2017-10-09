

public class Program {
  public static String Puzzle(int n) {
    String result = "";
	while (n > 0) {
		result = n % 2 + result;
		n /= 2;
	}
	return result;
  }
}