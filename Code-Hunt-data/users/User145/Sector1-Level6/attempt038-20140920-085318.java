

public class Program {
  public static int Puzzle(String s) {
	 for(String s1:s)
	 {
	 if((char)s1==" ")
	 return 0;
	 }
 return s.trim().split("\\s+").length;
  }
}