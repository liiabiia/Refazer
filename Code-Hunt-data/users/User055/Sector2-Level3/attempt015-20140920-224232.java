

public class Program {
  public static String Puzzle(String s) {
   StringBuffer sb = new StringBuffer(s.length()+1);
      int i, n = s.length()-1;

   for (i=1; i<n; i++){
	   sb.insert(i, s.charAt(n-i));
	   
   }
   return sb.toString();
  }
}