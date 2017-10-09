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
oBcount++;
if(i<2)
oBj=i;
  
}
else if(s[i]==')' )
{
cBcount++;
if(i<2)
cBj=i;
  
}
if(cBj==0)
return 0;
else if(oBcount==cBcount)
return oBcount;
else
return 0;
  }
}