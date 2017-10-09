

public class Program {
  public static int Puzzle(String s) {
      int c1=0;
	  char c,b;
	  int n=s.length();
	  for(int i = 0; i < s.length(); i++)
{
    c = s.charAt(i);
	b=s.charAt(n--);
   if(b==c) c1++;
   
}
return c1;
	
  }
}