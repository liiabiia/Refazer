

public class Program {
  public static String Puzzle(String s1) {
	  	StringBuilder s = new StringBuilder(s1);
		
		for(int i=1; i<s.length()/2; i++){
			char c1 = s.charAt(i);
			char c2 = s.charAt(s.length()-1-i);
			s.replace(i, i+1, c2+"");
			s.replace(s.length()-1-i, s.length()-i, c1+"");
		}

    return s;
  }
}