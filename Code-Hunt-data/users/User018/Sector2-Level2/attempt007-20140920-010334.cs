using System;

public class Program {
  public static int Puzzle(string s) {
	  char[] temp = s.ToCharArray()
	  if(temp.Length%2!=0)
	  	return 0;
	  Array.Reverse(temp);
	  int x = 0;
	  for(int i=0;i<temp.Length;i++)
	  {
		  if(temp[i]==')')
		  {
			  x++;
		  }
		  else
		  break;
	  }
	  return x;
  }
}