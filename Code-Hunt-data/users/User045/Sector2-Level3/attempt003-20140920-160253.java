

public class Program {
  public static String Puzzle(String s) {
	  String rev="";
	  rev=rev+s.charAt(0);
    for(int i=1;i<s.length()-1;i++) rev = rev+s.charAt(s.length-i-1);
	rev=rev+s.charAt(s.length()-1);
  }
}