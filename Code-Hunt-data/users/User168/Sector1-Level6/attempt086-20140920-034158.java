

public class Program {
  public static int Puzzle(String s) {
    String espacio = " ";
	texto=s.toCharArray();
	
	int a=1;
	for(int i=0; i<=s.length(); i++)
	{
		if(s.compareTo(espacio) ==1)
			a++;
	}
	return a;
  }
}