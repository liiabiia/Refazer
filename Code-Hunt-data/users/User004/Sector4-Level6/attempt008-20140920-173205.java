

public class Program {
  public static String Puzzle(String s) {
	  char[] c = s.toCharArray();
      for (int i = 0; i < c.length; i++){
		 c[i] = (char)(c[i] + Fib(i));
	  }
	  return new String(c);
  }
   public static int Fib(int n) {
	if(n == 0) return 1;
	if(n == 1) return 1;
    return Fib(n-1) + Fib(n-2);
  }
}