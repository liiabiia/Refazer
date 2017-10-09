

public class Program {
	public static int[] knownFib = new int[100];
  public static String Puzzle(String s) {
	  char[] c = s.toCharArray();
      for (int i = 0; i < c.length; i++){
		 c[i] = (char)(((c[i] + Fib(i)) -97) % 26 + 97);
	  }
	  return new String(c);
  }
   public static int Fib(int n) {
	   if(n < 2) return 1;
	   if(knownFib[n] != 0) return knownFib[n];
	   knownFib[n] = Fib(n-1) + Fib(n-2);
	   return knownFib[n];
  }
}