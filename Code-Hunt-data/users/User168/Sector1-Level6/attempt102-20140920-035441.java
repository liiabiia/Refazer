

public class Program {
  public static int Puzzle(String s) {
    char[] texto = new char[500];
	s.getChars(0,s.length(),texto,0);
	int a=1;
	for(int i=0; i<=s.length(); i++)
	{
		if(texto[i]==' ')
			a++;
	}
	return a;
  }
}