

public class Program {
  public static int Puzzle(String s) {
     
        s.trim();
 	String []words=s.trim().split("\\s+");
	return (words.length);
  }
}