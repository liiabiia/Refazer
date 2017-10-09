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
                if (chr == ')')
                {
                    if (opened > 0)
                    {
                        opened--;
                        num++;
                    }
                    else
                    {
                        num = 0;
                        break;
                    }
                }

            }
            if (opened > 0)
                num = 0;
				
				return num;
  }
}