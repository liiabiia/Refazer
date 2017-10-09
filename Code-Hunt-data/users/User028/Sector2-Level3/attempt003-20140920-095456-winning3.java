

public class Program {
  public static String Puzzle(String s) {
            StringBuffer reverse=new StringBuffer(s.length());
            reverse.append(s.charAt(0));
         for (int i=s.length()-2;i>=1;i--){
            reverse.append(s.charAt(i));
         }
         reverse.append(s.charAt(s.length()-1));
	return reverse.toString();
  }
}