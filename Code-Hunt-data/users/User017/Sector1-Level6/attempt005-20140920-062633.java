

public class Program {
  public static int Puzzle(String s) {
	  int count = 0;
	  char[] c = new char[s.trim().length()];
	  for(int i = 0; i < c.length - 1; i++) {
		  if(c[i] != ' ' && c[i+1] == ' ') count++;
	  }
	  return count;
  }
}