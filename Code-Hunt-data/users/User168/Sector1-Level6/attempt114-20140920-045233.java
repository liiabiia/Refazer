

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=0,i=0,longitud=s.length();
	for(char c : texto)
	{
		if(c==' ')
			a++;
		else
			i++;
	}
	return i;
  }
}