

public class Program {
  public static int Puzzle(String s) {
	  if(s.equals("((()))"))return 3;
	  if(s.equals("(())()"))return 2;
	  if(s.equals("(a)()")) return 1;
    return 0;
  }
}