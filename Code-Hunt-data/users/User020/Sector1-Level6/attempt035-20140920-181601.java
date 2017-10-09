
public class Program {
  public static int Puzzle(String s) {
	  private static int count = 0;
	for(int i=0; i<s.length(); i++){
		if(Character.isWhitespace(s.charAt(i))){
			count++;			
		}
	}
	return count;
  }
}