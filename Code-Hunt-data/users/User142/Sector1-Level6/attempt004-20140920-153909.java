

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
	  int i=0;
	  boolean ch=false;
	  while (i<s.length())
	  {
		  while(s.charAt(i)==" ")
		  {
			   ch=false;
		       i++;
		  }
		   while(s.charAt(i)!=" ")
		   {
			   ch=true;
		       i++;
		   }
		   if (ch)
		      count++;
		  
		  
	  }
	 
    return count;
  }
}