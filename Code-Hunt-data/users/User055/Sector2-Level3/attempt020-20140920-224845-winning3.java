

public class Program {
  public static String Puzzle(String s) {
   StringBuilder sb = new StringBuilder();
      int i, n = s.length()-1;
sb.append(s.charAt(0));
   for (i=1; i<n; i++){
	   sb.append(s.charAt(n-i));
	   
   }
   sb.append(s.charAt(n));
   return sb.toString();
  }
}