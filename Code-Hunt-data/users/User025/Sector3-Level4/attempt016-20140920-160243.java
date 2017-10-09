

public class Program {
  public static Boolean Puzzle(char c) {
	  //if(c == 'b'|| c == 'j' || c == 'q' || c == 's' || c == 'w') return false;
	  if(c == ' ') return true;
	  int b = c >> 4;
	  if(c % 2 == b % 2)
    	return false;
	return true;
  }
}