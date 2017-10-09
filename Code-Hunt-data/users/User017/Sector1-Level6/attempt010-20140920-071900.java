

public class Program {
  public static int Puzzle(String s) {
	  int count = 0;
	  char[] c = s.trim().toCharArray();
	  for(int i = 0; i < c.length - 1; i++) {
		  if(!Character.isWhitespace(c[i]) && Character.isWhitespace(c[i+1])) count++;
	  }
	  return count;
  }
}