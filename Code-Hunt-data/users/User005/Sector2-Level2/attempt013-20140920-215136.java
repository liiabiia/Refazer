public class Program {
	public static int Puzzle(String s) {
		int opened = 0;
		int res = 0;
		
		for (int i = 0; i < s.length(); ++i) {
			char c = s.charAt(i);
			if (c == '(') {
				if (opened > 0) res = 0;
				++opened;
			}
			
			if (c == ')' && opened > 0) {
				--opened;
				++res;
			}
		}
		
		//if (s.equals("((()))")) return 3;
		return res;
	}
}