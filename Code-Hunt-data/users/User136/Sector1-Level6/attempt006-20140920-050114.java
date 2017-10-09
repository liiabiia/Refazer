

public class Program {
  public static int Puzzle(String s) {
	  int totalSpace = 0;
	  
	  if (s.indexOf(" ") != 0) {
		  while (s.indexOf(" ") != null) {
			  int start = s.indexOf(" ");
			  int end = s.length - 1;
			  s = s.substring(start, end);
			  totalSpace++;
		  }
		  totalSpace += 1;
	  }
	  
    return totalSpace;
  }
}