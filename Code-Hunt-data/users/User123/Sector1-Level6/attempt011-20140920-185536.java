

public class Program {
  public static int Puzzle(String s) {
	String[] abc = s.trim().split("\\s+");
	int cd = abc.length;
	if(abc[0] == "") cd;
	return cd;
  }
}