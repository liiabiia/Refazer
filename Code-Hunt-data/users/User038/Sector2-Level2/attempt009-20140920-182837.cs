using System;

public class Program {
  public static int Puzzle(string s) {int count=0,bount=0;
   for (int i = s.Length - 1; i >= 0; i--)
     { if(s[i]=='(')
         count++;
        if(s[i]==')')bount++;
        if(s[0]==')') count--;
}
    if(count==bount)
       return (count+bount)/2;
   else
    return 0;
  }
}