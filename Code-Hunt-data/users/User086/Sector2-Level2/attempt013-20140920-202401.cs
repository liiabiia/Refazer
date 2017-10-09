using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	int x=0,y=0;
	
            char[] arr = s.ToCharArray();
			if(arr[0]==')')
	return 0;
			for(int i=0;i<arr.Length;i++)
			{
				if(arr[i]=='(')
				x++;
				if(arr[i]==')')
				{
					y+=x;
					x--;
				}
			}
			if(x==0)
			return y;
			else
			return 0;
			
}