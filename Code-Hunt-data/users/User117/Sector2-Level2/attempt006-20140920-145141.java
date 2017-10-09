

public class Program {
  public static int Puzzle(String s) {
      int c1=0;
	  char c,b;
	  int n=s.length();
	while(i<=n)
{
   
    c = s.charAt(i);
	b=s.charAt(n);
   if(b==c) c1++;
   n--;
   i++;
   
}
return c1;
	
  }
}