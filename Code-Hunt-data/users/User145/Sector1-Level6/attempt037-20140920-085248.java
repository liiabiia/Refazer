

public class Program {
  public static int Puzzle(String s) {
	 for(char s1:s)
	 {
	 if(s1==" ")
	 return 0;
	 }
 return s.trim().split("\\s+").length;
  }
}