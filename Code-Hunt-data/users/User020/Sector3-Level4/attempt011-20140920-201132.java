

public class Program {
  public static Boolean Puzzle(char c) {
	String forbiddenChars = "bjqswhxr";
	for(char x : forbiddenChars){
		if(c == x){
			return false;
		}
	}
	return true;
  }
}