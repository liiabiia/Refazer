using System;

public class Program {
  public static int Puzzle(string s) {
int oBcount=0;
int cBcount=0;
int oBj;
int cBj;
for(int i=0;i<s.Length;i++)
if(s[i]=='(' )
{obj=i;
  oBcount++;
}
else if(s[i]==')' )
{cBj=i;
  cBcount++;
}
if(cBj>obj)
return 0;
else if(oBcount==cBcount)
return oBcount;
else
return 0;
  }
}