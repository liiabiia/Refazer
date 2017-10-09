

public class Program {
  public static int Puzzle(String s) {
	int count = 1;
    String x = "";
	String[] x1 = s.split("");
	for(int i = 0; i < x1.length; i++)
	{
		if(x1[i].equals(" "))
		{	if (!x.equals(""))
				count++;
			x = "";
		}
		else
			x+=x1[i];
	}
	return count;
  }
}