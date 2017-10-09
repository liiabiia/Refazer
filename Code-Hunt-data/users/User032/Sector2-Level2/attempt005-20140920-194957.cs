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
                    continue;
                }
                if (chr == ')' && opened>0)
                {
                    opened--;
                    num++;
                }
            }
            if (opened > 0)
                num = 0;
				
				return num;
  }
}