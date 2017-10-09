

public class Program {
  public static int Puzzle(String s) {
int i,count=0,j=0;
for(i=0;i<s.length();i++)
{if(s.substring(i,i+1)=="(")
{count++;j++;}
if(s.substring(i,i+1)==")")
count--;
}
  if(count==0)  return j;
else return 0;
  }
}