

public class Program {
  public static String Puzzle(String s1) {
	  	StringBuilder s = new StringBuilder(s1);
		char c1;
		for(int i=1; i<s.length()/2; i++){
			c1 = s.charAt(i);
			s.replace(i, i+1, s.substring(s.length()-1-i, 1));
			s.replace(s.length()-1-i, s.length()-i, c1+"");
		}
    return s.toString();
  }
}