using System;
using System.Linq;
public class Program {
  public static int Puzzle(string s) {
            int num = 0;
            int opened = 0;
			foreach (var chr in s)
            {
                if (chr == '(')
                {
                    opened++;
                    num++;
                }
                else if (chr == ')')
                {
                    opened--;
                }
            }

				return (opened == 0) ? num : 0;
  }
}