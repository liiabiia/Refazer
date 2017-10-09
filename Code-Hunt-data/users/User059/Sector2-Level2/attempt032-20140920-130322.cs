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
				int f=0;
				
				if(store[0]==')')
				b=0;
				else if(store[0]=='(')
				{
					
					int u=store.IndexOf(')');
					if(u!=-1)
					{
							b++;
						f=u++;
						do{
				if(store[f]==')') b=0;
				else if(store[f]=='(')
				{
					
					int u=store.IndexOf(')');
					if(u!=-1)
					{
							b++;
					
						
					}
				}
					f++;
				}
						
				
			while(f!=store.Length);
			return b;
			}
				}}
				
            return countx;
        
        }
    }

