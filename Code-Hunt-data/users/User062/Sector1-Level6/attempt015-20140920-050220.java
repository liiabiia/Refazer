

public class Program {
  public static int Puzzle(String s) {
	  if(s==null) return 0;
	  int count=0;
	  if(s.charAt(i)!=' ') count++;
	  for(int i=1;i<s.length();i++)
	   if(s.charAt(i)==' ')
	    for(;i<s.length();i++)
		 if(s.charAt(i)!=' ')
	      count++;
	  	
    return count;
  }
}