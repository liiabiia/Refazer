using System;

public class Program {
  public static int Puzzle(string s) {int count=0,n=s.Length,c=0,b=0;
   for (int i =0; i <=s.Length/2; i++)
      {  if(s[i]=='('&&s[n-1-i]==')')
          count++;
          if(s[i]=='(') c++;
           if(s[i]==')')b++;}

}
        if(c!=b) return 0;
 else       return count;
  
  }
}