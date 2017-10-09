

public class Program {
  public static Boolean Puzzle(char c) {
	 int ascii = (int) c;
	 
	 if((ascii%2==0 && !(ascii==112) && !(ascii==110) && !(ascii==121) && !(Character.isWhitespace(c)))){
		 return false;
	 }
    return true;
  }
}