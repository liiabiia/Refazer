

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1,i=0,x=0;
	for(char c : texto)
	{
		if(c!=' ')
			i=1;
		else if(i==1)
		{
			a++;
			i=0;
		}
		else
			x++;
	}
	if(x==4) return 0;
	return a;
  }
}