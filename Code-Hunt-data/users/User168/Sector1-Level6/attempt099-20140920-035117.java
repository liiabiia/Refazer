

public class Program {
  public static int Puzzle(String s) {
    char espacio = ' ';
	
	int a=1;
	for(int i=0; i<=s.length(); i++)
	{
		if(s.contentEquals(espacio) == true)
			a++;
	}
	return a;
  }
}