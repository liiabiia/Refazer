

public class Program {
  public static Boolean Puzzle(char c) {
	  //if(c == 'b'|| c == 'j' || c == 'q' || c == 's' || c == 'w') return false;
	  if(c == ' ') return true;
	  if(c % 2 == c % 32)
    	return false;
	return true;
  }
}