

public class Program {
  public static int Puzzle(String s) {
    char[] texto = new char[500];
	texto=s.toCharArray();
	int a=1;
	for(int i=0; i<=s.length(); i++)
	{
		if(s.toCharArray()==' ')
			a++;
	}
	return a;
  }
}