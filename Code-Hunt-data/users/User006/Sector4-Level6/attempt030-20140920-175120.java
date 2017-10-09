

public class Program {
	public static int fib(int n) {
        return (n <= 1) ? n : (fib(n - 1) + fib(n - 2));
    }
  public static String Puzzle(String s) {
	  String tmp = "";
	 for(int i = 0; i < s.length(); i++)
	 {
		 tmp += 'a' + (s.charAt(i) + fib(i+1) - 'a')%'{';
	 }
    return tmp;
  }
}