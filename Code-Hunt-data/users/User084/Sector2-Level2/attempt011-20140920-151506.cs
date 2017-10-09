using System;

public class Program {
  public static int Puzzle(string s) {
    Stack<int> parenthesis = new Stack<int>();
int last = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '(')
        parenthesis.Push(i);
    else if (s[i] == ')')
    {
        last = parenthesis.Pop();
    }
}
return last;
if (last == 0)
{
    // The matching parenthesis was the first letter.
}
  }
}