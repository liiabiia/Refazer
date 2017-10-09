

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1;
	for(int i=0; i<=s.length(); i++)
	{
		if(texto[i]==' ')
			return a++;
	}
	return a;
  }
}