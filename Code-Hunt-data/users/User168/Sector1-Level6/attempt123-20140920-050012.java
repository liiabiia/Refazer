

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1,i=0,longitud=s.length();
	for(char c : texto)
	{
		if(c!=' ')
			i=1;
		else if(i==1)
		{
			a++;
			i=0;
		}
	}
	if(a==1 && c==' ') return a=0;
	return a;
  }
}