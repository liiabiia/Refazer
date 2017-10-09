using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	int x=0,y=0;
            char[] arr = s.ToCharArray();
			int i;
            for ( i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                    x++;
               else
			   break;
            }
			i++;
			while(i<arr.Length)
			{
				if(arr[i]==')')
				y++;
				else
				break;
			}
            if (x == y)
                return x;
            else
               return 0;
  }
}