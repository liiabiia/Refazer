

public class Program {
  private static int count = 0;
  public static Boolean Puzzle(char c) {
	count = 1 - count;
	int ord = 0;
	String chars = "abcdefghijklmnopqrstuvwxyz";
	for(char x : chars){
		ord = 1 - ord;
		if(c == x){
			return(ord == 1 || count == 1);
		}
	}
	return true;
  }
}