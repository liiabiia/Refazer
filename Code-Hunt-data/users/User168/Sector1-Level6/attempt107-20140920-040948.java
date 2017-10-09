

public class Program {
  public static int Puzzle(String s) {
	char[] texto = new char[20];
	int a=1,i=0;
	for(String ss:s)
	{
		texto[i]=ss;
		if(texto[i]==' ')
			a++;
	}
	return a;
  }
}