using System;

public class Program {
   public static int Puzzle(string s)
        {
            int i = 0, j = 0, countx = 0, county = 0, x = 0, y = 0;
            while (i < s.Length)
            {
                if (s[0] == '(')
                {
                    countx++;
                    j = i;
                    while (j < s.Length)
                    {
                        if (s[j] == ')')
                        {
                            if (x > 0)
                            {
                                j++;
                                x--;

                            }
                            county++;
                            x++;
                            break;
                        }
                        j++;
                    }
                }
                else if (s[0] == ')')
                {
                    county++;
                    j = i;
                    while (j < s.Length)
                    {
                        if (s[j] == '(')
                        {
                            if (y > 0)
                            {
                                j++;
                                y--;

                            }
                            countx++;
                            x++;
                            break;
                        }
                        j++;
                    }
                }
                i++;
            }
            if (countx == county) return countx;
            return 0;
        }
    }