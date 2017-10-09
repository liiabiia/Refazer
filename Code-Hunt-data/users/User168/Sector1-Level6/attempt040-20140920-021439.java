

public class Program {
  public static int Puzzle(String s) {
    char[] texto= new char[500];
	int a=0;
	for (int i=0; i<=s.length(); i++)
	{ 
		if(texto[i]==' ')
			a++;
	}
	return a; 
  }
}