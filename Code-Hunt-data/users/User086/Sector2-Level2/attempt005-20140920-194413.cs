using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	int x=0,y=0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                    x++;
                if (arr[i] == ')')
                    y++;
            }
            if (x == y)
                return x;
            else
               return 0;
  }
}