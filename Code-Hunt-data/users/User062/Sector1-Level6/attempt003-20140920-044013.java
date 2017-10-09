

public class Program {
  public static int Puzzle(String s) {
	  if(s==" "||s=="") return 0;
	  int count=1;
	  for(int i=0;i<=Str.lastIndexOf(s);i++)
	   if(s[i]==" ") i++;
	  	
    return count;
  }
}