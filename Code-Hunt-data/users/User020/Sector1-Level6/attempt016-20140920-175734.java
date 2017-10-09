

public class Program {
  private static int count = 0;
  public static int Puzzle(String s) {
		for(int i=0; i<s.length; i++){
			if(s[i] == 'a' ){
				count += 1;
			}
		}
		return count;
  }
}