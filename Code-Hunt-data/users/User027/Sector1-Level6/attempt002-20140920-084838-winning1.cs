using System;

public class Program {
  public static int Puzzle(string s) {
		string[] a = s.Trim().Split(' ');
	    int count = 0;
	    for (int i = 0; i < a.Length;i++ )
	    {
	        if (!a[i].Trim().Equals(""))
	            count++;
	    }
		return count;
  }
}