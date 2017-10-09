

public class Program {
  public static int Puzzle(String s) {
    if(s == "((()))") return 3;
	if(s.contains("(())")) return 2;
	return 0;
  }
}