

public class Program {
  public static int Puzzle(String s) {
	String str=s.trim();
    if(str.isEmpty())
		return 0;
	return str.split("\\s+").length;
  }
}