

public class Program {
  public static String Puzzle(String s) {
	 String reverse = "";
	 int length = s.length();
	 for ( int i = length - 2 ; i >= 1 ; i-- )
         reverse = reverse + s.charAt(i);
    return s.charAt(0)+reverse+s.charAt(s.length-1);
  }
}