

public class Program {
  public static String Puzzle(String s) {
   StringBuffer sb = new StringBuffer(s.length()+1);
      int i, n = s.length()-1;
   sb.insert(0,s.charAt(0));
  
   

   sb.insert(n-1,s.charAt(n-1));
 
   return sb.toString();
  }
}