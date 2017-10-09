using System;

public class Program {
  public static string Puzzle(string s) {
    	char[] c2 = s.ToCharArray();
		String result = "";
		for(int i = 0 ; i<c2.Length;i++)
		{
			int c = (c2[i]+getFibonacci(i)-97)%26+97;
			result += (char)c;
		}
		return result;
	}

	public static int getFibonacci(int n)
	{
		return (n<=1)?1:getFibonacci(n-1)+getFibonacci(n-2);
	}
}