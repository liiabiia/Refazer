

public class Program {
  public static int Puzzle(String s) {
      int c1=0,c2=0;
	  char c,b;
	  int n=s.length()-1;
	  int i=0;
	if(s.charAt(0)=='(' &&s.charAt(n)==')')
	{  c1=1;
		 i++;n--;
		while(i<n)
{
   
    c = s.charAt(i);
	b=s.charAt(n);
   if(c=='(' && b==')') c1++;
   n--;
   i++;
   
}}
return c1;
	
  }
}