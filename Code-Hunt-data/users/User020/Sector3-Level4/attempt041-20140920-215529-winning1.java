

public class Program {
  private static int count = 0;
  public static Boolean Puzzle(char c) {
	String goodChars = "apg neimcu";
	for(char x : goodChars){
		if(c == x){
			return true;
		}
	}
	return false;
  }
}