

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
	   if(n == 0) return 1;
	   if(n == 1) return 1;
	   if(knownFib[n] != 0){
		   return knownFib[n];
	   } else {
		   knownFib[n] = Fib(n-1) % 26 + Fib(n-2) % 26;
		   return knownFib[n];
	   }
  }
}