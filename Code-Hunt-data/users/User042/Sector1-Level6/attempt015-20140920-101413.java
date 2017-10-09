

public class Program {
  public static int Puzzle(String s) {
    int oldlen = s.lenght();
	s = s.replace(" ","");
	return oldlen - s.length();
  }
}