

public class Program {
  public static int Puzzle(String s) {
	  int totalSpaces = 0;
	  s = s.trim();
	  
	  while (s.length() != 0) {
		  totalSpaces++;
		  if (s.indexOf(" ") != null) {
			  int start = s.indexOf(" ");
			  int end = s.length() - 1;
			  s = s.substring(start, end);
		  } else {
			  s = "";
		  }
		  s = s.trim();
	  }
	  
    return totalSpaces;
  }
}