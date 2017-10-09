using System;
using System.Text.RegularExpressions;
public class Program {
  public static int Puzzle(string s) {
	int i, x=0,y=0;
	
            char[] arr = s.ToCharArray();
			int length = arr.Length;
            if (arr[0] == ')' || arr[length - 1] == '(' || arr[0]!='(' ||arr[length-1]!=')')
               return 0;
            else
            {

                for (i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '(')
                    {
                        x++;
                        y++;
                    }
                    if (arr[i] == ')')
                    {
                        x--;
						//if(x==0)
						//break;
                    }
                }
                if (arr[i - 1] == '(')
                   return 0;
                if (x == 0)
                   return y;

                else
                    return 0;
            }
}
}