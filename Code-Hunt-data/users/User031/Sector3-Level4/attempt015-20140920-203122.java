

public class Program {
  public static Boolean Puzzle(char c) {
	 int ascii = (int) c;

	 if(!(Character.isWhitespace(c)) || ascii == 106 || ascii == 98 || ascii == 121)
	 {
		 return false;
	 }
    return true;
  }
}