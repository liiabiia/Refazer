

public class Program {
  private static int count = 1;
  public static Boolean Puzzle(char c) {
	count = 1 - count;
	int ord = 1;
	String chars = "abcdefghijklmnopqrstuvwxyz";
	for(char x : chars){
		ord = 1 - ord;
		if(c == x){
			return( (ord && !count) || (!ord && count) )
		}
	}
	return true;
  }
}