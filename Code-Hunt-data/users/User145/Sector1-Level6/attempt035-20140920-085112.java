

public class Program {
  public static int Puzzle(String s) {
	 if(s==" ")
	 return 0;
	 else
 return s.trim().split("\\s+").length;
  }
}