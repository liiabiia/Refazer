

public class Program {
  public static int Puzzle(String s) {
    if(s.length() < 2)
	  return 0;
	if(s.charAt(0) != '(')
  	  return 0;
    if(s.charAt(s.length() -1) != ')')
	  return 0;
	if(s.length == 2)
	  return 1;
    return Puzzle(s.substring(1,s.length() - 1));
  }
}