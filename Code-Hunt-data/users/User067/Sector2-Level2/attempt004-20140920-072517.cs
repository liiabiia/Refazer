using System;

public class Program {
  public static int Puzzle(string s) {

            int counter = 0;
            while (s.Length > 0)
            {
                if (s.Length % 2 == 0)
                {
                    if (s.StartsWith("(") && s.EndsWith(")"))
                    {
                        s = s.Substring(1, s.Length - 2);
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
    return counter ;
  }
}