

public class Program {
  public static String Puzzle(String s) {
   StringBuilder sb = new StringBuilder(s.length()+1);
      int i, n = s.length()-1;

   for (i=1; i<n; i++){
	   sb.append(s.charAt(n-i));
	   
   }
   return sb.toString();
  }
}