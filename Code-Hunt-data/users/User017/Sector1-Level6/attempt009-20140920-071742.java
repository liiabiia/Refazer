

public class Program {
  public static int Puzzle(String s) {
	  int count = 0;
	  char[] c = new char[s.length()];
	  for(int i = 0; i < c.length - 1; i++) {
		  if(!Character.isWhitespace(c[i]) && Character.isWhitespace(c[i+1])) count++;
	  }
	  return count;
  }
}