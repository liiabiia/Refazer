

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=0,i=0,var=0;
	for(char c : texto)
	{
		if(c!=' ')
			i=1;
		else if(i==1)
		{	
			a++;
			i=0;
			if(a==1)
			var++;
			else if(var==1)
				a++;
		}		
	}
	return a;
  }
}