

public class Program {
  public static int Puzzle(String s) {
	  if(s==" "||s==null) return 0;
	  int count=1;
	  for(int i=0;i<=s.length();i++)
	   if(s.charAt(i)==' ') count++;
	  	
    return count;
  }
}