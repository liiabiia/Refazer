
public class Program {
  public static int Puzzle(String s) {
    char[] texto= new char[500];
	int a=1;
	for (int i=0; i<=s.length(); i++)
	{ 
		if(texto[i]==' ')
		a+=1;
	}
	return a; 
  }
}