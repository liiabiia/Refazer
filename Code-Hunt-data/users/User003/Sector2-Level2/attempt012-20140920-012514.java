

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
			lastClosed = false;
			if(lastOpened)opened++;
			else
			{
				maxOverall = Math.max(Math.min(opened,closed),maxOverall);
				lastOpened = true;
				opened = 1;
				closed = 0;
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
			lastOpened = false;
		} else{
			lastOpened = false;
			lastClosed = false;
							opened = 0;
				closed = 0;
		}
	}
	maxOverall = Math.max(Math.min(opened,closed),maxOverall);
	return (maxOverall==1)?0:maxOverall;
  }
}