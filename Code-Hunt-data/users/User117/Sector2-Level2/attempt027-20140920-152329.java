

public class Program {
  public static int Puzzle(String s) {
     	 
 int c1=0,c2=0;
	  char c;
	  int n=s.length()-1;
	  int i=0;int sum=0;
	 
	for(i=0;i<n;i++)
	{
		
		c=s.charAt(i);
		sum+=c;
	   if(c=='(')c1++;
	   if(c==')')c2++;
	   
	
	}

	
	return sum/81;
  }
}