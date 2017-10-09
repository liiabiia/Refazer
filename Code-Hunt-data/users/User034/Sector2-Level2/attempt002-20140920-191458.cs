using System;

public class Program
{
    public static int Puzzle(string s)
    {
        int c = 0;
        int stack=0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                c++;
                stack++;
            }
            else if (s[i] == ')')
            {
                stack--;
            }
        }
            return stack==0?c:0;
    }
}