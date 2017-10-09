

public class Program {
  public static int Puzzle(String s) {
	  s = s.trim();
		int counter = 0;
		while(s.indexOf(" ") != -1) {
			s = s.substring(s.indexOf(" "));
			s = s.trim();
			s = s + ((s.length()!=0)?" ":"");
			counter++;
		}
    return counter;
  }
}