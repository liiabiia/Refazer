

public class Program {
  public static int Puzzle(String s) {
	if(String.isEmpty(s))
	{
		return 0;
	}
 return s.trim().split("\\s+").length;
  }
}