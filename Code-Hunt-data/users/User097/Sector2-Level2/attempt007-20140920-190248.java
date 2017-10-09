

public class Program {
  public static int Puzzle(String s) {
	  char[] str=s.toCharArray();
	  int c1=0,c2=0;
	  for(int i=0;i<str.length;i++)
	  	{
			  if(str[i]==')')
			  	return 0;
			  else if(str[i]=='(')
		  		{
					  c1++;
					  for(int j=i+1;j<str.length;j++)
					  	if(str[j]==')')
						  {
							  c2++;
							  str[j]='a';
							  break;
						  }
				  }
		}
	if(c1==c2)
    	return c1;
	return 0;
  }
}