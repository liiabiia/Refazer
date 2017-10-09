using System;

public class Program {
  public static int Puzzle(string s)
        {
            int i = 0, j = 0, countx = 0, county = 0, x = 0, y = 0,total=0;
			string store;
            while (i < s.Length)
            {
             
                 if (s[i] == '(')
                 {
					 store+='(';
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
							  store+=')';
                             x++;
                             break;
                         }
                         j++;
                     }
                 }
                
             else if (s[i] == ')')
             {
				  store+=')';
                 county++;
             }
            
                i++;
            }
			for(int i=0;i<total;i++)
			{
				county-=')';
			}

         county -= total;
		 
            if (county!= countx) return 0;
			else 
			{
				if(store[0]=')')
				return 0;
			}
        
            return countx;
        
        }
    }

