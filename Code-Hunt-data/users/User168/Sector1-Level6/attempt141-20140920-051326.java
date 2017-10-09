

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=0,i=0;
	for(char c : texto)
	{
		if(c!=' ')
			i=1;
		else
		{
			a++;
			i=0;
		}
	}
	return a;
  }
}