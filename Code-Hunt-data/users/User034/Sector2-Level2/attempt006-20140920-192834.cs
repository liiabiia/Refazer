using System;

public class Program
{
    public static int Puzzle(string s)
    {
        int stack = 0, i;
        for (i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack++;
            }
            else if (s[i] == ')')
            {
                stack -= stack != 0 ? 1 : 0;
            }
            else
                break;
        }
        return stack == 0 && i == s.Length ? s.Length/2 : 0;
    }
}