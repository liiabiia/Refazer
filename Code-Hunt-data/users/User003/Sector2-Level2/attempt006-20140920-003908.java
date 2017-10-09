

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
				maxOverall = Math.max(Math.min(opened,closed),maxOverall);
				lastOpened = true;
				opened = 1;
			}
		}
		else if(c==')')
		{
			if(lastClosed)closed++;
			else
			{
				lastClosed=true;
				if(lastOpened)closed =1;
			}
		} else{
			lastOpened = false;
			lastClosed = false;
		}
	}
	maxOverall = Math.max(Math.min(opened,closed),maxOverall);
	return maxOverall;
  }
}