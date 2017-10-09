

public class Program {
  public static Boolean Puzzle(char c) {
	 int ascii = -97 + (int) c;
		
	 if((Character.isWhitespace(c)) || (ascii < 10 && ascii%2==0) || (ascii==12) ||(ascii==13) ||(ascii==15) ||(ascii==20))
	 {
		 return true;
	 }
    return false;
  }
}