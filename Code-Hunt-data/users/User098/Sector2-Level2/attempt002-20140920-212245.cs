using System;

public class Program {
  public static int Puzzle(string s) {
int oBcount=0;
int cBcount=0;
for(int i=0;i<s.Length;i++)
if(string[i]=='('  )
  oBcount++;
else if(string[i]==')'  )
  cBcount++;
if(oBcount==cBcount)
return oBcount;
else
return 0;
  }
}