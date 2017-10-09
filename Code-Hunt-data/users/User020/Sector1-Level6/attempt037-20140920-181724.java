
public class Program {
  public static int Puzzle(String s) {
	int count = 1;
	for(int i=1; i<s.length(); i++){
		if(Character.isWhitespace(s.charAt(i)) && !Character.isWhitespace(s.charAt(i-1))){
			count++;			
		}
	}
	return count;
  }
}