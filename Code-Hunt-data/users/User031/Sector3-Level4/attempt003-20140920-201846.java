

public class Program {
  public static Boolean Puzzle(char c) {
	 int ascii = (int) c;
	 if(ascii%2==0 || ascii==35){
		 return false;
	 }
    return true;
  }
}