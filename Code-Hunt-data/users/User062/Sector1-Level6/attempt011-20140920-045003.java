

public class Program {
  public static int Puzzle(String s) {
	  if(s.charAt(0)==' '||s==null) return 0;
	  int count=1;
	  for(int i=0;i<s.length();i++)
	   if(s.charAt(i)==' '&&s.charAt(++i)!=' ') count++;
	  	
    return count;
  }
}