

public class Program {
  public static int Puzzle(String s) {
      int c1=0,c2=0;
	  char c,b;
	  int n=s.length()-1;
	  int i=0;
	while(i<n)
{
   
    c = s.charAt(i);
	b=s.charAt(n);
   if(c=='(' && b==')') c1++;
   if(c1>0)
   {
	   if(c=='(' && b==')') c2++;
   }

   n--;
   i++;
   
}
return c2+1;
	
  }
}