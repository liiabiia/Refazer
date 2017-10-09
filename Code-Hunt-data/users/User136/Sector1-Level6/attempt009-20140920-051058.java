

public class Program {
  public static int Puzzle(String s) {
	  int totalSpaces = 0;
	  s = s.trim();
	  
	  while (s.length() != 0) {
		  totalSpaces++;
		  if (s.indexOf(" ") != null) {
			  s = s.substring(s.indexOf(" "), s.length() - 1);
		  } else {
			  s = "";
		  }
		  s = s.trim();
	  }
	  
    return totalSpaces;
  }
}