

public class Program {
  public static int Puzzle(String s) {
    int open = 0, close = 0;
	for(int i = 0; i < s.length(); i++) {
		if(s.charAt(i) == '(') open++;
		if(s.charAt(i) == ')') {
			if(open > close) close++;
			else return 0;
		} 
	}
	if(open == close) return open;
	return 0;
  }
}