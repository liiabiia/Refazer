

public class Program {
  public static int Puzzle(String s) {
    int len = s.length();
	int count = 0;
	while(len>=0)
	{
		if(s.charAt(len)==" ")
			count++;
	}
	count++;
	return count;
  }
}