using System;

public class Program {
  public static string Puzzle(string s) {
	  char[] arr = s.ToCharArray();
	  uint fibim2 = 0, fibim1 = 0, fibi = 1;
	  for(int i=0;i<arr.Length;++i)
	  {
		  arr[i] = (char)(arr[i] + fibi);
		  fibim2 = fibim1;
		  fibim1 = fibi;
		  fibi = fibim1 + fibim2;
	  }
    return new string(arr);
  }
}