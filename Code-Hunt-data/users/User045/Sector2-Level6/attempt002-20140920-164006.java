

public class Program {
  public static String Puzzle(int n) {
	  String s="",r="";
    while(n<=1)	int rem=n%2;s=s+(char)rem;s=s+(char)n;
	for(int i=s.length-1;i>=0;i--) r=r+s.charAt(i);
	return r
  }
}