using System;
using System.IO;

public class Program {
  public static int Puzzle(string s) {
    
	int i,lenght=0;
	for(i=0;s[i]!='\0';i++)
	{
		lenght++;
	}
	return lenght;
	 }
}