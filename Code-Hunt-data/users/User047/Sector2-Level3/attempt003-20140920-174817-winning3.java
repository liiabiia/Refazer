

public class Program {
  public static String Puzzle(String s) {
	  String b = s.substring(0,1);
		s = s + " ";
		for(int i = s.length() - 3; i > 0; i--)
			b = b + s.substring(i,i+1);
		b = b + s.substring(s.length()-2, s.length()-1);
    return b;
  }
}