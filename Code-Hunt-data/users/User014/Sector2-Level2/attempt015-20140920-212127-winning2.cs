using System;
using System.Collections.Generic;

public class Program {
  public static int Puzzle(string s) {
bool justMatched = false;
            bool allMatched = true;
            int nestedMatch = 1;
            Stack<char> pStack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(')
                {
                    pStack.Push(c);
                    justMatched = false;
                }
                else if (c == ')')
                {
                    if (pStack.Count > 0)
                    {
                        if (justMatched)
                        {
                            nestedMatch++;
                        }
                        else
                        {
                            justMatched = true;
                        }
                        pStack.Pop();
                    }
                    else
                    {
                        justMatched = false;
                        allMatched = false;
                    }
                }
            }
            allMatched = allMatched && pStack.Count == 0;
            return !allMatched || nestedMatch == 1 ? 0 : nestedMatch;
  }
}