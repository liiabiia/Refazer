using System;
using System.Collections.Generic;
public class Program {
  public static int Puzzle(string s) {
    Stack<char> stack = new Stack<char>();
            int level = 0,max=int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '('){
                    stack.Push('(');
					level =0;
					if (max<level)max=level;
					}
                if (s[i] == ')' && stack.Count > 0)
                {
                    stack.Pop();
                    level++;
                }
            }
			return max;
  }
}