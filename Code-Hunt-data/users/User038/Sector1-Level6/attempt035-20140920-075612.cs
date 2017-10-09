using System;

public class Program {
  public static int Puzzle(string s) {int count=0,len,i;
len=s.Length; for(i=0;i<=len;i++) { if(s[i]==' ') count++; }
    return count+1;
  }
}