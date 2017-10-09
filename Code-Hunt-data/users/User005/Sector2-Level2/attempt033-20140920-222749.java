public class Program {
	public static int Puzzle(String s) {
		if (s.charAt(0) == ')' || s.matches("[a-z ]")) return 0;
		int res = 0;
	    	
    	int x = s.indexOf("()");
    	
		int start = x-1, end = x + 2;
    	while (start >= 0 && end < s.length()) {
    		if (s.charAt(start) == '(' && s.charAt(end) == ')') ++res;
    		--start;
    		++end;
    	}
		if (res > 0) ++res;
		return res;
	}
}