

public class Program {
  public static int Puzzle(String s) {
    int cntopen=0,pair=0,cntclose=0;
     int len= s.length();
int i,f=0;
for(i=0;i<len;i++)
{
 if(s.charAt(i)=='(')
{
if(cntclose>cntopen)
{
 f=1;
break;
}
cntopen++;
}
 else if(s.charAt(i)==')')
 {
  if(cntopen>cntclose) pair++;
  cntclose++;
 }
}
if(f==1 || (cntopen!=cntclose))
return 0;
else return pair;
  }
}