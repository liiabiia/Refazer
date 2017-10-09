

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1,i=0;
	for(char c : texto)
	{
		if(c==' ')
			a++;
	}
	return a;
  }
}