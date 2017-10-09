using System;

public class Program {
  public static int Puzzle(string s) {
    int count = 0, i = 0;
	while(s[i] != '\0')
	{
		if(s[i] == ' ')
		   count++;
		i++;
	}
	return (count + 1);
  }
}