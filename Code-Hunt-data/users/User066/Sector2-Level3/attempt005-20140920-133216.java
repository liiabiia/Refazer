

public class Program {
  public static String Puzzle(String s) {
    int l, i;
	String n="";
	l=s.length();
	for(i=(l/2)-1;i>0;i++)
	{
		n= n+s.charAt(i);
		n=s.charAt(l-1-i)+n;
	}
	n= s.charAt(0)+n+s.charAt(l-1);
	return n;	
		
  }
}