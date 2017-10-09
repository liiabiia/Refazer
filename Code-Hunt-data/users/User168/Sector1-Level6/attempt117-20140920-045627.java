

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=0,i=0,longitud=s.length();
	for(char c : texto)
	{
		/*
		if(c==' ')
			a++;
		else
			i++;
		*/
		if(c!=' ')
			i=1;
		if(i==1)
		{
			a++;
			i=0;
		}
	}
	return a;
  }
}