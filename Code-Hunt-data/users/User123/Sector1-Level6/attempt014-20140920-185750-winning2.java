

public class Program {
  public static int Puzzle(String s) {
	  s = s.trim();
	String[] abc = s.split("\\s+");
	int cd = abc.length;
	if(abc[0] == "") cd--;
	return cd;
  }
}