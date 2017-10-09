

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	int a=0,i=0, val=0;
	for(char c : texto)
	{
		if(c!=' ')
		{
			if(i!=0)
				a++;
			i=1;
		}
		else if(i==1)
		{
			a++;
			i=0;		
		}		
	}
	return a;
  }
}