using System;

public class Program {
  public static int Puzzle(string s) {
int oBcount=0;
int cBcount=0;
int oBj=0;
int cBj=0;
for(int i=0;i<s.Length;i++)
if(s[i]=='(' )
{
oBj=i;
oBcount++;
}
else if(s[i]==')' )
{
cBj=i;
cBcount++;
}
if(oBcount==cBcount&&oBj<cBj)
return oBcount;
else
return 0;
  }
}