

public class Program {
  public static int Puzzle(String s) {
    int oldlen = s.length();
	s = s.replace(" ","");
	return oldlen - s.length()+1;
	
  }
}