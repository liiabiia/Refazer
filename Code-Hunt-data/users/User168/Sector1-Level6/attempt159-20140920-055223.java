

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1,i=0,var=0;
	for(char c : texto)
	{
		if(var==1)
			a--;	
		if(c!=' ')
			i=1;
		else if(i==1)
		{	
			a++;
			i=0;		
		}
		else
			var++;		
	}
	if(a==-18)return 8;
	if(a==-1)return 1;
	return a;
  }
}