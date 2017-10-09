

public class Program {
  public static String Puzzle(String s) {
   StringBuffer sb = new StringBuffer(s.length());
   sb.insert(0,s.charAt(0));
  
   
   int i, n = s.length()-1;
   sb.insert(n-1,s.charAt(n-1));
   for (i=1; i<n; i++){
	   sb.insert(i, s.charAt(n-i));
	   
   }
   return sb.toString();
  }
}