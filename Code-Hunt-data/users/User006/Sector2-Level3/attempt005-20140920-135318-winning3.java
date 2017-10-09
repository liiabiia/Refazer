

public class Program {
  public static String Puzzle(String s) {
	 String reverse = ""+s.charAt(0);
	  for ( int i = s.length() - 2 ; i > 0 ; i-- )
         reverse = reverse + s.charAt(i);
	 return reverse + s.charAt(s.length()-1);
  }
}