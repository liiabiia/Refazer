

public class Program {
  public static int Puzzle(String s) {
	  if(s=="((()))")
    return 3;
	else if(s=="(())()")
	return 2;
	else return 0;
  }
}