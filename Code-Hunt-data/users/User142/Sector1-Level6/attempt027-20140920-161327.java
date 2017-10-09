


public class Program {
  public static int Puzzle(String s) {
	  int count=0;
	  int i=0;
	  boolean ch=false;
	  while (i<s.length()-1)
	  {
		  while(s.charAt(i)==' ' && i<s.length()-1)
		  {
			   ch=false;
		       i++;
		  }
		   while(s.charAt(i)!=' ' && i<s.length()-1)
		   {
			   ch=true;
		       i++;
		   }
		   
		   if (ch)
		      count++;
           if (i==s.length()-1 && s.charAt(i-1)==' ' &&  s.charAt(i)==' ')	  
		      count++;
		        
	  }
	 
    return count;
  }
}