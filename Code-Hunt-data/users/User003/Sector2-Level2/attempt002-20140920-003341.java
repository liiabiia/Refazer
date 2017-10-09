

public class Program {
  public static int Puzzle(String s) {
    char[] chars = s.toCharArray();
	int opened = 0;
	int closed = 0;
	int overall = 0;
	int maxOverall = 0;
	boolean lastOpened = false;
	boolean lastClosed = false;
	for(char c : chars)
	{
		if(c=='(')
		{
			if(lastOpened)opened++;
			else
			{
				lastOpened = true;
				opened = 1;
			}
		}
		if(c==')')
		{
			if(lastClosed)closed++;
			else
			{
				lastClosed=true;
				closed =1;
			}
		}
	}
  }
}