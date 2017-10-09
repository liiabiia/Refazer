using System;
using System.Collections.Generic;
public class Program {
  public static int Puzzle(string s) {
 Stack<char> stack = new Stack<char>();
            int level = 0, max = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push('(');
                }
                else
                if (s[i] == ')')
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                        level++;
                    }
                    else
                        return 0;
            }
			if (stack.Count>0)return 0;
            return Math.Max(level,Math.Max(max,0));
  }
}