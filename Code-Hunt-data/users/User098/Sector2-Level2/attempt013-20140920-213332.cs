using System;

public class Program {
  public static int Puzzle(string s) {
int oBcount=0;
int cBcount=0;
for(int i=0;i<s.Length;i++)
if(s[i]=='(' )
oBcount++;

else if(s[i]==')' )
cBcount++;

else if(oBcount==cBcount)
return oBcount;
else
return 0;
  }
}