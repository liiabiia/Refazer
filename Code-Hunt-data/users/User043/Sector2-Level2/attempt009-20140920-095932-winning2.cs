using System;
using System.Collections.Generic;
public class Program {
  public static int Puzzle(string s) {
Stack<char> stack = new Stack<char>();
            int level = 0, max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (stack.Count==0) max++;
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
            if (stack.Count > 0) return 0;
            return max>1? max : level;
  }
}