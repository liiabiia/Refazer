

public class Program {
  public static int Puzzle(String s) {
	if(s.contains("(("))
    return 2;
	else if(s.contains("((("))
	return 3;
	else if(s.contains("("))
	return 1;
	else return 0;
  }
}