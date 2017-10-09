using System;

public class Program {
  public static int Puzzle(string s) {int count=0;
   for (int i = s.Length - 1; i >= 0; i--)
     { if(s[i]=='(')
         count++;
        if(s[i]==')')bount++;
}
    if(count==bount)
       return (count+bound)/2;
   else
    return 0;
  }
}