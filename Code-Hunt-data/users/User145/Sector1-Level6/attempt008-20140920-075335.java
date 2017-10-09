

public class Program {
  public static int Puzzle(String s) {
	 
	  int count=0;
	  int i;
	   for(i=0;i<s.length();i++)
        {
			if(s.matches(".*\\s+.*"))
			count++;
	
  }
  return count;
  }
}