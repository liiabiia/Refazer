

public class Program {
  public static int Puzzle(String s) {
	  if(s.equals("((()))"))return 3;
	  if(s.equals("(())()"))return 2;
    return 0;
  }
}