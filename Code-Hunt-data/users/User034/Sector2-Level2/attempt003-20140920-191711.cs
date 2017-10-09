using System;

public class Program
{
    public static int Puzzle(string s)
    {
        int c = 0;
        int stack=0;
        int x = 0;
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
            else
            {
                x++;
            }
        }
            return stack==0 && x==0?c:0;
    }
}