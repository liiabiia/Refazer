

public class Program {
  public static int Puzzle(String s) {
    int cntopen=0,pair=0;
     int len= s.length();
int i;
for(i=0;i<len;i++)
{
 if(s.charAt(i)=='(')
  cntopen++;
 else if(s.charAt(i)==')')
 {
  if(cntopen>0) pair++;
  cntopen--;
 }
}
if(cntopen!=0)
 return 0;
else return pair;
  }
}