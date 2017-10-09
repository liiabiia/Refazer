

public class Program {
  	public static String Puzzle(String s) {
		char t, st[]=s.toCharArray();
		for(int i=1;i<s.length()/2;i++)
		{
			t = st[i];
			st[i] = st[s.length()-i-1];
			st[s.length()-i-1] = t;
		}
    	return String(st);
  	}
}