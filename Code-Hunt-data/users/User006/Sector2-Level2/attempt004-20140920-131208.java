

public class Program {
  public static int Puzzle(String s) {
	  if(s.matches("\\(+\\)+"))
    	return StringUtils.countMatches(s, '(');
  }
}