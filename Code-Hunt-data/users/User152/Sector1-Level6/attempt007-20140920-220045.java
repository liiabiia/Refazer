

public class Program {
  public static int Puzzle(String s) {
	if (s.isEmpty()){
       return 0;}
    return s.trim().split("\\s+").length;
  }
}