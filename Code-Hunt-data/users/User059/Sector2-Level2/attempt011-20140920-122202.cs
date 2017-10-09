using System;

public class Program {
  public static int Puzzle(string s)
        {
            int i = 0, j = 0, countx = 0, county = 0, x = 0, y = 0,total=0;
            while (i < s.Length)
            {
             
                 if (s[i] == '(')
                 {
                     countx++;
                     j = i;
                     while (j < s.Length)
                     {
                         if (s[j] == ')')
                         {
                             total++;
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
                
             else if (s[i] == ')')
             {
                 county++;
             }
            
                i++;
            }

           if ((county-total)!=0) return 0;
          else  if (countx == county) return countx;
           else return 0;
        }
    }

