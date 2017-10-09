

public class Program {
  public static String Puzzle(String s) {
	  char[] c = s.toCharArray();
      for (int i = 0; i < c.length; i++){
		 c[i] = (char)(c[i] + Puzzle(i));
	  }
	  return new String(c);
  }
   public static int Puzzle(int n) {
	if(n == 0) return 1;
	if(n == 1) return 1;
    return Puzzle(n-1) + Puzzle(n-2);
  }
}