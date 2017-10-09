

public class Program {
  public static int Puzzle(String s) {
      int c1=0,c2=0;
	  char c;
	  for(int i = 0; i < s.length(); i++)
{
    c = s.charAt(i);
   if(c=='(')c1++;
   if(c==')')c2++;
   
}
if(c1==c2)retrun c2;
else return 0;
	
  }
}