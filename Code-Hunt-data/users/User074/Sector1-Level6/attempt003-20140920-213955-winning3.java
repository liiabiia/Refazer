

public class Program {
  public static int Puzzle(String s) {
    	s = s.trim();
		if(s=="")
			return 0;
		else
			return s.split("\\s+").length;
  }
}