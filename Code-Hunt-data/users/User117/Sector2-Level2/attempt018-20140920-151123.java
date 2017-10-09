

public class Program {
  public static int Puzzle(String s) {
      int c1=0,c2=0;
	  char c,b;
	  int n=s.length()-1;
	  int i=0;
	if(s.charAt(0)=='(' &&s.charAt(n)==')')
	{  
		 i++;n--;
		while(i<n)
{
   
    c = s.charAt(i);
	b=s.charAt(n);
   if(c=='(' && b==')') c1++;
   n--;
   i++;
   
}
if(c1==s.length/2){c1++;}

}
return c1;
	
  }
}