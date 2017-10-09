public class Program {
	public static int Puzzle(String s) {
		if (s.indexOf('\0') > 0 ) return 0;
		int x = s.indexOf("()");

    	
		int start = x-1, end = x + 2;
    	while (start >= 0 && end < s.length()) {
    		if (s.charAt(start) == '(' && s.charAt(end) == ')') ++res;
    		--start;
    		++end;
    	}
		
		return res;
	}
}