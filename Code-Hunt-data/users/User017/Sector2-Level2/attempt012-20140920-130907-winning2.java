

public class Program {
  public static int Puzzle(String s) {
    int open = 0, close = 0, count = 1;
	for(int i = 0; i < s.length(); i++) {
		if(s.charAt(i) == '(') {
			open++;
			if(i < s.length() - 1 && s.charAt(i+1) == '(') count++;
		}
		if(s.charAt(i) == ')') {
			if(open > close) close++;
			else return 0;
		} 
	}
	if(open == close) return count;
	return 0;
  }
}