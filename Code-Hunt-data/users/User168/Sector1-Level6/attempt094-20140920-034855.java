

public class Program {
  public static int Puzzle(String s) {
    String espacio = ' ';
	
	int a=1;
	for(int i=0; i<=s.length(); i++)
	{
		if(s.compareTo(espacio)==' ')
			a++;
	}
	return a;
  }
}