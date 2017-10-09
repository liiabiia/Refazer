

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
	  int i=0;
	  boolean ch=false;
	  

		  while(s.charAt(i).equals(" ") && i<s.length())
		  {
			   ch=false;
		       i++;
		  }
		   while(!s.charAt(i).equals(" ") && i<s.length())
		   {
			   ch=true;
		       i++;
		   }
		   if (ch)
		      count++;

	 
    return count;
  }
}