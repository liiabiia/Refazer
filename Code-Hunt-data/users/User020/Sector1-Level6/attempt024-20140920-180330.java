

public class Program {
  private static int count = 0;
  public static int Puzzle(String s) {
		for(int i=1; i<s.length(); i++){
			if(s.charAt(i) == ' ' && s.charAt(i -1) != ' ' ){
				count += 1;
			}
			
		}
		return count;
  }
}