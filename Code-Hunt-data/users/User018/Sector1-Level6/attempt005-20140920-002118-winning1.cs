using System;

public class Program {
  public static int Puzzle(string s) {
    char[] input = s.Trim().ToCharArray();
	int count = 0;
	bool onSpace = true;
	for(int i = 0; i<input.Length;i++)
	{
		if((input[i]!=' ')&&onSpace)
			{
				count++;
				onSpace=false;
			}
			else if(input[i]==' ')
			{
			onSpace=true;
			}
	}
	return count;
  }
}