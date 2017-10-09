using System;

public class Program {
  public static int Puzzle(string s)
        {
            int i = 0, j = 0, countx = 0, county = 0, x = 0, y = 0,total=0;
			string store=null;
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
			for(int k=total;k>0;k--)
			{
				if(store[k]==')')
				store.Remove(k);
			}

         county -= total;
		 int b=0;
            if (county!= countx) return 0;
			else
			{
				int g;
				for(int m=0;m<store.Length;m++)
				{
					if(store[m]=='(' && store.IndexOf(')')!=-1)
					continue;
					else if(store[m]==')' &&( store.IndexOf('(')>m || store.IndexOf('(')==-1 ))
					return 0;
				}
			}
			
				
				
            return countx;
        
        }
    }

