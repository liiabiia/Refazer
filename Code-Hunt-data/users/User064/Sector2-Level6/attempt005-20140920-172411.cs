using System;

public class Program {
  public static string Puzzle(int n) {
  char[] b = new char[32];
	int pos = 4;
	int i = 0;

	while (i < pos)
	{
	    if ((n & (1 << i)) != 0)
	    {
		b[pos] = '1';
	    }
	    else
	    {
		b[pos] = '0';
	    }
	    pos--;
	    i++;
	}
	return new string(b);
  }
}