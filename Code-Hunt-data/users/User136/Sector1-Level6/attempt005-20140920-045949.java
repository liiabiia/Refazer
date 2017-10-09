

public class Program {
  public static int Puzzle(String s) {
	  int totalSpace = 0;
	  
	  if (s.indexOf(" ") != 0) {
		  while (s.indexOf(" ") != null) {
			  s = s.substring(s.indexOf(" "), s.length - 1);
			  totalSpace++;
		  }
		  totalSpace += 1;
	  }
	  
    return totalSpace;
  }
}