

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=0,i=0;
	for(char c : texto)
	{
		if(c==' ')
			i=0;
		else
			i=1;
		if(i==0)
		{
			a++;
			i=1;
		}
	}
	return a;
  }
}