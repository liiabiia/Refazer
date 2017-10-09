

public class Program {
  public static int Puzzle(String s) {
    char[] texto = s.toCharArray();
	
	int a=1,i=0;
	while(i<=s.length())//for(int i=0; i<=s.length(); i++)
	{
		if(texto[i]==' ')
			a++;
		i++;
	}
	return a;
  }
}