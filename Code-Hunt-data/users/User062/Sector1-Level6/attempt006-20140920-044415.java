

public class Program {
  public static int Puzzle(String s) {
	  if(s==" "||s==0) return 0;
	  int count=1;
	  for(int i=0;i<=s.length();i++)
	   if(s.charAt(i)==" ") i++;
	  	
    return count;
  }
}