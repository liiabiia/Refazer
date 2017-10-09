

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	int a=0,i=0;
	for(char c : texto)
	{
		if(c!=' ')
			i=1;
		else if(i==1)
		{
			if(a==0)
				a++;
			a++;
			i=0;		
		}		
	}
	return a;
  }
}