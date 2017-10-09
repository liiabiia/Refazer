

public class Program {
  public static Boolean Puzzle(char c) {
	String forbiddenChars = "bjqswh";
	for(char x : forbiddenChars){
		if(c == x){
			return false;
		}
	}
	return true;
  }
}