

public class Program {
	private static count = 0;
  public static int Puzzle(String s) {
		for(int i=0; i<s.length; i++){
			if(s[i] == ' ' and s[i-1] != ' '){
				count++;
			}
		}
		return count;
  }
}